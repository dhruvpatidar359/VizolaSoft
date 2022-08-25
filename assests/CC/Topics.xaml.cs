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

namespace VizolaSoft.assests.CC
{
    /// <summary>
    /// Interaction logic for Topics.xaml
    /// </summary>
    public partial class Topics : UserControl
    {
        public Topics()
        {
            InitializeComponent();
        }



        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(string), typeof(Topics));




        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Topics));



        public string Genre
        {
            get { return (string)GetValue(GenreProperty); }
            set { SetValue(GenreProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Genre.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GenreProperty =
            DependencyProperty.Register("Genre", typeof(string), typeof(Topics));



        public string Price
        {
            get { return (string)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Price.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(string), typeof(Topics));

        private void mouse_leftDown(object sender, MouseButtonEventArgs e)
        {
             var processInfo = new ProcessStartInfo("C:\\Users\\dhruv\\Desktop\\interactive.exe");
             Process.Start(processInfo);

        }

      
    }
}
