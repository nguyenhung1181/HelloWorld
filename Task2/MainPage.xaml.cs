using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Task2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "HelloWorld";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) {
            Button mybutton = new Button();
            mybutton.Name = "ClickMeButton";
            mybutton.Content = "Click Me";
            mybutton.Width = 200;
            mybutton.Height = 100;
            mybutton.Margin = new Thickness(20, 20, 0, 0);
            mybutton.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Left;
            mybutton.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Top;
            mybutton.Background = new SolidColorBrush(Windows.UI.Colors.Red);
            mybutton.Click += Button_Click;

            LayoutGrid.Children.Add(mybutton);
        }
    }
}
