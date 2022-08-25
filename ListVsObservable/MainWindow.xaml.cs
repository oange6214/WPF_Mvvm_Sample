using ListVsObservable.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace ListVsObservable
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Player> players = new ObservableCollection<Player>();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = GetPlayer();
        }

        public ObservableCollection<Player> GetPlayer()
        {
            players.Add(new Player() { Id = 1, Name = "Ronaldo" });
            players.Add(new Player() { Id = 2, Name = "Messi" });
            players.Add(new Player() { Id = 3, Name = "Neymar" });

            return players;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            players.Add(new Player() { Id = 4, Name = "Bale" });
        }
    }
}
