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
            var candidate = (Candidate)addPersonPage.Person;
            if (!string.IsNullOrEmpty(candidate.Name) &&
                !CandidatesCollection.Any(c => c.Name == candidate.Name)) CandidatesCollection.Add(candidate);
        }

        private void AddVoters_Button(object sender, RoutedEventArgs e)
        {
            AddPersonWindow addPersonPage = new AddPersonWindow(new Voter());
            addPersonPage.ShowDialog();
            var voter = (Voter)addPersonPage.Person;
            if (!string.IsNullOrEmpty(voter.Name) &&
                !VotersCollection.Any(v => v.Name == voter.Name)) VotersCollection.Add(voter);
        }

        private void SubmitClick_Click(object sender, RoutedEventArgs e)
        {
            var selectedVoter = (Voter)PickVoter_Combobox.SelectedItem;
            var selectedCandidate = (Candidate)PickCandidate_Combobox.SelectedItem;

            if (selectedVoter.HasVoted || selectedVoter == null || selectedCandidate == null) return;

            CandidatesCollection.Remove(selectedCandidate);
            VotersCollection.Remove(selectedVoter);
            selectedVoter.SetVoteState();
            selectedCandidate.IncrementVotes();
            VotersCollection.Add(selectedVoter);
            CandidatesCollection.Add(selectedCandidate);
        }
    }
}
