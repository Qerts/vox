using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
        public Index()
        {
            this.InitializeComponent();
            this.Loaded += Index_Loaded;
        }

        private void Index_Loaded(object sender, RoutedEventArgs e)
        {
            SetView(View.Init);
            //TODO check if there are any files loaded
            //TODO check if there are any effects loaded
        }

        private void SetView(View view)
        {
            switch (view)
            {
                case View.Init:
                    //init positions
                    break;
                case View.ShowRightBar:
                    throw new NotImplementedException();
                    break;
                case View.HideRightBar:
                    throw new NotImplementedException();
                    break;
                case View.ShowLeftBar:
                    throw new NotImplementedException();
                    break;
                case View.HideLeftBar:
                    throw new NotImplementedException();
                    break;
                case View.ShowBottomBar:
                    throw new NotImplementedException();
                    break;
                case View.HideBottomBar:
                    throw new NotImplementedException();
                    break;
                case View.ShowTopPanel:
                    throw new NotImplementedException();
                    break;
                case View.HodeTopPanel:
                    throw new NotImplementedException();
                    break;
                case View.ShowPurchasePanel:
                    throw new NotImplementedException();
                    break;
                case View.HidePurchasePanel:
                    throw new NotImplementedException();
                    break;
                case View.ShowRecordButton:
                    buttonRecord.Visibility = Visibility.Visible;
                    buttonStop.Visibility = Visibility.Collapsed;
                    break;
                case View.ShowStopButton:
                    buttonStop.Visibility = Visibility.Visible;
                    buttonRecord.Visibility = Visibility.Collapsed;
                    break;
                default:
                    break;
            }
        }

        private void buttonRecord_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SetView(View.ShowStopButton);
            Core.Properties.Recorder.StartRecording();
        }

        private void buttonStop_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SetView(View.ShowRecordButton);
            Core.Properties.Recorder.StopRecording();
        }

        private void buttonPause_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //TODO modify pause button to checkbutton
            Core.Properties.Recorder.PauseRecording();
        }
    }
}
