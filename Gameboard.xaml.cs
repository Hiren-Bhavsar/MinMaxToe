using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MinMaxToe {
    /// <summary>
    /// Interaction logic for Gameboard.xaml
    /// </summary>
    public partial class Gameboard : Window {

        private bool isPlayerOneTurn, AIPlayerEnabled, isAITurn;
        private SolidColorBrush playerOneColor = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FA163F"));
        private SolidColorBrush playerTwoColor = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#12CAD6"));
        private SolidColorBrush highlightColor = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#495060"));
        private SolidColorBrush backgroundColor = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#30343F"));
        private Button[] buttonBoard;
        private int p1Points = 0, p2Points = 0;

        public Gameboard(bool enableAI) {
            isPlayerOneTurn = true;
            AIPlayerEnabled = enableAI;
            isAITurn = false;
            InitializeComponent();

            buttonBoard = new Button[] { button0, button1, button2, button3, button4, button5, button6, button7, button8 };

        }

        private void MainMenu_Click(object sender, RoutedEventArgs e) {
            ResetGame();
            this.Close();
        }

        private void Reset_Click(object sender, RoutedEventArgs e) {
            ResetGame();
        }

        private void Game_Click(object sender, RoutedEventArgs e) {
            Button temp = (Button)sender;
            // Check that it is not the AI Player's turn and that the position has not yet been played.
            if (!isAITurn && temp.Content.Equals("")) {
                if (isPlayerOneTurn) {
                    temp.Foreground = playerOneColor;
                    temp.Content = "X";
                } else {
                    temp.Foreground = playerTwoColor;
                    temp.Content = "O";
                }
                CheckWin();
                SwitchPlayer();
            }
        }

        private MinMaxAI miniMax = new MinMaxAI();
        private void AI_Turn() {
            int testTemp = miniMax.testMove();

            if (buttonBoard[testTemp].Content.Equals("")) {
                buttonBoard[testTemp].Foreground = playerTwoColor;
                buttonBoard[testTemp].Content = "O";
            }
            CheckWin();
            isAITurn = false;
            SwitchPlayer();
        }

        private void ResetGame() {
            p1Points = 0;
            p2Points = 0;
            UpdatePoints("");
            ResetBoard();
        }

        private void ResetBoard() {
            foreach (Button temp in buttonBoard) {
                temp.Content = "";
            }
        }


        private void SwitchPlayer() {
            //Normal Player Toggle
            isPlayerOneTurn = !isPlayerOneTurn;

            //Adjust Background Highlight
            if (isPlayerOneTurn) {
                playerOnePoints.Background = highlightColor;
                playerTwoPoints.Background = backgroundColor;
            } else {
                playerOnePoints.Background = backgroundColor;
                playerTwoPoints.Background = highlightColor;
            }


            //Switch to AI Player if Enabled
            if (AIPlayerEnabled && !isPlayerOneTurn) {
                isAITurn = true;
                AI_Turn();
            }
        }

        private void CheckWin() {
            //Check Rows
            for (int x = 0; x < 7; x += 3) {
                string content1 = buttonBoard[x].Content.ToString();
                string content2 = buttonBoard[x + 1].Content.ToString();
                string content3 = buttonBoard[x + 2].Content.ToString();

                if (!(content1.Equals("")) && content1.Equals(content2) && content1.Equals(content3)) {
                    GenerateMessageBox(content1.Equals("X") ? "Player One Wins" : "Player Two Wins", "We Have A Winner!");
                    UpdatePoints(content1);
                    ResetBoard();
                }
            }

            //Check Columns
            for (int x = 0; x < 3; x++) {
                string content1 = buttonBoard[x].Content.ToString();
                string content2 = buttonBoard[x + 3].Content.ToString();
                string content3 = buttonBoard[x + 6].Content.ToString();

                if (!(content1.Equals("")) && content1.Equals(content2) && content1.Equals(content3)) {
                    GenerateMessageBox(content1.Equals("X") ? "Player One Wins" : "Player Two Wins", "We Have A Winner!");
                    UpdatePoints(content1);
                    ResetBoard();
                }
            }

            //Check Forward and Backward Diagonals
            if (!(buttonBoard[0].Content.Equals(""))) {
                if (buttonBoard[0].Content.Equals(buttonBoard[4].Content) && buttonBoard[0].Content.Equals(buttonBoard[8].Content)) {
                    GenerateMessageBox(buttonBoard[0].Content.Equals("X") ? "Player One Wins" : "Player Two Wins", "We Have A Winner!");
                    UpdatePoints(buttonBoard[0].Content.ToString());
                    ResetBoard();
                }
            }

            if (!(buttonBoard[2].Content.Equals(""))) {
                if (buttonBoard[2].Content.Equals(buttonBoard[4].Content) && buttonBoard[2].Content.Equals(buttonBoard[6].Content)) {
                    GenerateMessageBox(buttonBoard[2].Content.Equals("X") ? "Player One Wins" : "Player Two Wins", "We Have A Winner!");
                    UpdatePoints(buttonBoard[2].Content.ToString());
                    ResetBoard();
                }
            }

            //Check for Tie, No Points Awarded
            String tieCheck = "";
            foreach (Button temp in buttonBoard) {
                tieCheck += temp.Content;
            }
            if (tieCheck.Length == 9) {
                GenerateMessageBox("The Game Has Ended In A Tie!", "Tie Game!");
                ResetBoard();
            }

        }

        private void UpdatePoints(string winner) {
            if (winner.Equals("X")) {
                p1Points++;
            } else if (winner.Equals("O")) {
                p2Points++;
            }
            playerOnePoints.Content = "P1: " + p1Points;
            playerTwoPoints.Content = "P2: " + p2Points;
        }

        private void GenerateMessageBox(string message, string caption) {
            MessageBoxButton messageButtons = MessageBoxButton.OK;
            MessageBox.Show(message, caption, messageButtons, MessageBoxImage.Information);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

    }
}
