using System;
using System.Collections.Generic;
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

namespace DataTemplate1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Movie CurrentMovie { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            CurrentMovie = new Movie();
            CurrentMovie.Name = "Matrix";
            CurrentMovie.Year = 1999;
            CurrentMovie.HoursWatched = 20000;
            CurrentMovie.Cast = new List<string>(){"Keanu Reeves","Laurance Fishburne","Carrie Moss"};

            DataContext = this;
        }
    }
}
