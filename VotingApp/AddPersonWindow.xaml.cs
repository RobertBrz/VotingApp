using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VotingApp.NewFolder;

namespace VotingApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddPersonWindow : Window
    {
        public Person Person { get; set; }

        public AddPersonWindow(Person person)
        {
            InitializeComponent();
            Person = person;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            Person.SetName(NameTextBox.Text);
            Window.GetWindow(this).DialogResult = true;
            this.Close();
        }

        private void RemoveNoAlphabetSigns(object sender, TextChangedEventArgs e)
        {
            Regex rgx = new Regex("[^a-zA-Z-]");
            NameTextBox.Text = rgx.Replace(NameTextBox.Text, "");
        }
    }
}
