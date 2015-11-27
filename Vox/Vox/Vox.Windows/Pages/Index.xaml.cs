using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            
        }

        private void SetView(View view)
        {
            switch (view)
            {
                case View.ReadyToRecord:
                    StoryboardCollapse.Begin();
                    break;
                case View.Recording:
                    
                    break;
                case View.Recorded:
                    StoryboardExpand.Begin();
                    break;
                case View.Playing:
                    break;
                case View.Transforming:
                    break;
                case View.Files:
                    break;
                case View.NoFiles:
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void buttonRecord_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SetView(View.Recording);
        }

        private void buttonStop_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SetView(View.Recorded);
        }

        private void buttonPause_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
