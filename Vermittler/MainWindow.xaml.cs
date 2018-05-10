using GameStore;
using GameStore.Commands;
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

namespace Vermittler
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Game> _Games;
        public Game _currentGame;
        Dictionary<String, Type> commands = new Dictionary<string, Type>();

        public MainWindow()
        {
            InitializeComponent();
            Games = new ObservableCollection<Game>();
            DataContext = this;
            Games.Add(new Game("Game 1"));
            Games.Add(new Game("Game 2"));
            Games.Add(new Game("Game 3"));

            commands.Add("buy", typeof(BuyCommand));
            commands.Add("download", typeof(DownloadCommand));
            commands.Add("install", typeof(InstallCommand));
            commands.Add("lend", typeof(LendCommand));
            commands.Add("retrieve", typeof(RetrieveCommand));
            commands.Add("start", typeof(StartCommand));
            commands.Add("uninstall", typeof(UninstallCommand));
        }

        public ObservableCollection<Game> Games
        {
            get
            {
                return _Games;
            }
            set
            {
                _Games = value;
            }
        }

        public Game currentGame
        {
            get
            {
                return _currentGame;
            }
            set
            {
                _currentGame = value;
            }
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string cmd = btn.Name;

            try
            {
                GameStore.Interfaces.ICommand instance = (GameStore.Interfaces.ICommand)Activator.CreateInstance(commands[cmd], currentGame);
                instance.Execute();
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Invalid command");
            }
        }
    }
}
