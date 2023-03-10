using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace WpfMasterDetailList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Movie> movies;
        public MainWindow()
        {
            InitializeComponent();
            movies = new ObservableCollection<Movie>();
            DataContext = movies;
            //ListBoxMovies.DataContext = movies;
            
        }

        private void ButtonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader sr = new StreamReader("Movies.txt"))
            {
                while(!sr.EndOfStream)
                {
                    //ObservableCollection<Movie> tempList = new ObservableCollection<Movie>();
                    Movie m = new Movie();
                    m.Name = sr.ReadLine();
                    m.RottenTomatosScore = Convert.ToInt32(sr.ReadLine());
                    m.Review= sr.ReadLine();
                    movies.Add(m);

                }

            }

        }


        /*private void OpenFile(object target, ExecutedRoutedEventArgs e)
        {

        }*/
    }
}
