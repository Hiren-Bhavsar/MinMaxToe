﻿using System;
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
        private const Visibility collapsed = Visibility.Collapsed;

        public MainWindow() {
            InitializeComponent();
            
        }

        private void PVP_Click(object sender, RoutedEventArgs e) {
        }

        private void PVAI_Click(object sender, RoutedEventArgs e) {

        }

        private void Options_Click(object sender, RoutedEventArgs e) {
            MenuGrid.IsEnabled = false;
            MenuGrid.Visibility = collapsed;
        }
    }
}