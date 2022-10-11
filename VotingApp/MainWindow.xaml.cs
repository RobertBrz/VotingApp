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

namespace VotingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ReturnEventHandler<string> GetStringPageFunction_Returned { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddVoters(object sender, RoutedEventArgs e)
        {
            GetStringPageFunction pageFunction = new GetStringPageFunction();
            pageFunction.Return += new ReturnEventHandler<String>(GetStringPageFunction_Returned);
            this.NavigationService.Navigate(pageFunction);
        }

        private void SubmitClick_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddVoters_Button(object sender, RoutedEventArgs e)
        {

        }
    }
}
