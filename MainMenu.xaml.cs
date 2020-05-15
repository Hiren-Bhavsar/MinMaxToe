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

namespace MinMaxToe {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private OptionsMenu optionsMenu = new OptionsMenu();
        private Gameboard gameBoard;

        public MainWindow() {
            InitializeComponent();

        }

        private void PVP_Click(object sender, RoutedEventArgs e) {
            gameBoard = new Gameboard(false);
            gameBoard.Show();
        }

        private void PVAI_Click(object sender, RoutedEventArgs e) {
            gameBoard = new Gameboard(true);
            gameBoard.Show();
        }

        private void Options_Click(object sender, RoutedEventArgs e) {
            optionsMenu.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            base.OnClosed(e);

            App.Current.Shutdown();
        }
    }
}