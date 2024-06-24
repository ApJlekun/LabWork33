using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Game> games = new List<Game>
            {
                new Game { IdGame = 1, Name = "game 1", Site = "site 1", Category = "category 1", Price = 10.0 },
                new Game { IdGame = 2, Name = "game 2", Site = "site 2", Category = "category 2", Price = 20.0 },
                new Game { IdGame = 3, Name = "game 3", Site = "site 3", Category = "category 3", Price = 30.0 },
                new Game { IdGame = 4, Name = "game 4", Site = "site 4", Category = "category 4", Price = 40.0 },
                new Game { IdGame = 5, Name = "game 5", Site = "site 5", Category = "category 5", Price = 50.0 }
            };
            ListView.ItemsSource = games;
        }
    }
}