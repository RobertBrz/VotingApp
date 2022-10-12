using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using VotingApp.NewFolder;

namespace VotingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Candidate> CandidatesCollection { get; set; } = new ObservableCollection<Candidate>();
        public ObservableCollection<Voter> VotersCollection { get; set; } = new ObservableCollection<Voter>();


        public MainWindow()
        {
            InitializeComponent();
            this.CandidatesGrid.ItemsSource = CandidatesCollection;
            this.VotersGrid.ItemsSource = VotersCollection;
            this.PickVoter_Combobox.ItemsSource = VotersCollection;
            this.PickCandidate_Combobox.ItemsSource = CandidatesCollection;
        }

        private void AddCandidate(object sender, RoutedEventArgs e)
        {
            AddPersonWindow addPersonPage = new AddPersonWindow(new Candidate());
            addPersonPage.ShowDialog();
            var person = addPersonPage.Person;
            if (string.IsNullOrEmpty(person.Name)) return;

            CandidatesCollection.Add((Candidate)person);
        }

        private void AddVoters_Button(object sender, RoutedEventArgs e)
        {
            AddPersonWindow addPersonPage = new AddPersonWindow(new Voter());
            addPersonPage.ShowDialog();
            var person = addPersonPage.Person;
            if (string.IsNullOrEmpty(person.Name)) return;

            VotersCollection.Add((Voter)person);
        }

        private void SubmitClick_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
