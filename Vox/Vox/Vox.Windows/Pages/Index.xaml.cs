using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Vox.Base;
using Vox.Enums;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Vox.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Index : Page
    {
        private bool _isPaused = false;
        private Recorder _recorder = null;
        private FileManager _fileManager = null;

        public Index()
        {
            this.InitializeComponent();
            this.Loaded += Index_Loaded;
        }

        private void Index_Loaded(object sender, RoutedEventArgs e)
        {
            _recorder = new Recorder();
            _fileManager = new FileManager();
        }

        private void SetView(View view)
        {
            switch (view)
            {
                case View.ReadyToRecord:
                    StoryboardCollapseButtons.Begin();
                    break;
                case View.Recording:
                    StoryboardExpandButtons.Begin();
                    break;
                case View.Recorded:
                    StoryboardCollapseButtons.Begin();
                    break;
                case View.Playing:
                    break;
                case View.Transforming:
                    break;
                case View.Files:
                    StoryboardExpandBars.Begin();
                    break;
                case View.NoFiles:
                    StoryboardCollapseBars.Begin();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void buttonRecord_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SetView(View.Recording);
            Task.Run(async () => {
                await _recorder.StartRecording();
            });
            
        }

        private void buttonStop_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SetView(View.Recorded);
            Task.Run(async () =>
            {
                try
                {
                    await _recorder.StopRecording();
                    SetView(View.Files);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            });
            
        }

        private void buttonPause_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (_isPaused)
            {
                _isPaused = false;
                //set pause button style to tapped
                _recorder.ResumeRecording();
            }
            else
            {
                _isPaused = true;
                //set pause button style to no tapped
                _recorder.PauseRecording();
            }
        }
    }
}
