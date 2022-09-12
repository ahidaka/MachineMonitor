using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MachineMonitor
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            // Set initial output value.
            //Control1Output.Text = (bool)Toggle1.IsChecked ? "On" : "Off";
        }

        private void myButton_Click0(object sender, RoutedEventArgs e)
        {
            //myButton0.Content = "ON";
        }
        private void myButton_Click1(object sender, RoutedEventArgs e)
        {
            //myButton1.Content = "ON";
        }
        private void myButton_Click2(object sender, RoutedEventArgs e)
        {
            //myButton2.Content = "ON";
        }
        private void myButton_Click3(object sender, RoutedEventArgs e)
        {
            //myButton3.Content = "ON";
        }
    }
}
