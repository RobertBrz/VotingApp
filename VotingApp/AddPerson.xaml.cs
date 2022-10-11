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
    /// Interaction logic for AddPerson.xaml
    /// </summary>
    public partial class AddPerson : Page
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }

        public AddPerson()
        {
            InitializeComponent();
        }

        private string  Add(object sender, RoutedEventArgs e)
        {
            return string.Join(" ", FirstName, LastName);
        }

        private void SetNameClick(object sender, TextChangedEventArgs e)
        {
            FirstName = FirstNameBox.Text;
        }

        private void SetLastName_Click(object sender, TextChangedEventArgs e)
        {
            LastName = LastNameBox.Text;
        }
    }
}
