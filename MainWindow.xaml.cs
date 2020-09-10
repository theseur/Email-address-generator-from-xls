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
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CSV_opening_and_manipulating
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Starting_Click(object sender, RoutedEventArgs e)
        {
            ATablazatlista aTablazatlista;
            StreamReader sr = new StreamReader(@"G:\c#\CSV-opening-and-manipulating\probaemailcím.csv");
            int k = 0;
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Eredeti.Text += line;
                string[] values = line.Split(';');
                Eredetinev.Text = values[4];
                values[4] = values[4].ToLower();
                Ujnev.Text = values[4];
                aTablazatlista = new ATablazatlista(values[0], values[1], values[2], values[3], values[4].ToLower());
                uj.Text += aTablazatlista.ToString();
                
            }
            
    }

        private void EXiting_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
