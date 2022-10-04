using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VizolaSoft
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            System.Threading.Thread.Sleep(1500);
            InitializeComponent();
        }

        private void Polygon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void minmizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       
        private void maximizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState  = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
            
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            VIZOLA.Foreground = Brushes.Yellow;
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            VIZOLA.Foreground = Brushes.White;
        }

        private void Topics_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void mouse_leftDown(object sender, MouseButtonEventArgs e)
        {
            var processInfo = new ProcessStartInfo("C:\\Users\\dhruv\\Desktop\\interactive\\interactive.exe");
            Process.Start(processInfo);


        }

        private void Topics_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var processInfo = new ProcessStartInfo("C:\\Users\\dhruv\\Desktop\\prototype\\prototype.exe");
            Process.Start(processInfo);
        }
    }
}
