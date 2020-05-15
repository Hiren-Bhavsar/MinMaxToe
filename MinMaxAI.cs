using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MinMaxToe {
    class MinMaxAI {

        public MinMaxAI() {
        }

        public int RandomMove(String[] board) {
            Random random = new Random();
            int randomMove = -1;

            while (randomMove == -1) {
                int temp = random.Next(0, board.Length);
                if (board[temp].Equals("-")) {
                    randomMove = temp;
                }
            }
            return randomMove;
        }

        //Determine if there are moves remaining
        private bool IsBoardFull(String[] board) {
            for (int x = 0; x < board.Length; x++) {
                if (board[x].Equals("-")) {
                    return false;
                }
            }
            return true;
        }

        //+10 Evaluation to 'O' Winning, -10 Evaluation to 'X' Winning
        private int EvaluateBoard(String[] board) {
            //Check Rows
            for (int x = 0; x < 7; x += 3) {
                string content1 = board[x];
                string content2 = board[x + 1];
                string content3 = board[x + 2];

                if (!(content1.Equals("")) && content1.Equals(content2) && content1.Equals(content3)) {
                    if (content1.Equals("O")) {
                        return 10;
                    }
                    else if (content1.Equals("X")) {
                        return -10;
                    }
                }
            }

            //Check Columns
            for (int x = 0; x < 3; x++) {
                string content1 = board[x];
                string content2 = board[x + 3];
                string content3 = board[x + 6];

                if (!(content1.Equals("")) && content1.Equals(content2) && content1.Equals(content3)) {
                    if (content1.Equals("O")) {
                        return 10;
                    }
                    else if (content1.Equals("X")) {
                        return -10;
                    }
                }
            }

            //Check Diagonals
            if (!(board[0].Equals(""))) {
                if (board[0].Equals(board[4]) && board[0].Equals(board[8])) {
                    if (board[0].Equals("O")) {
                        return 10;
                    }
                    else if (board[0].Equals("X")) {
                        return -10;
                    }
                }
            }

            if (!(board[2].Equals(""))) {
                if (board[2].Equals(board[4]) && board[2].Equals(board[6])) {
                    if (board[2].Equals("O")) {
                        return 10;
                    }
                    else if (board[2].Equals("X")) {
                        return -10;
                    }
                }
            }
            return 0;
        }

        private int minimax(String[] board, int depth, bool isMaximizer) {
            int score = EvaluateBoard(board);

            if (score == 10 || score == -10) {
                return score;
            }

            if (IsBoardFull(board)) {
                return 0;
            }

            if (isMaximizer) {
                int best = int.MinValue;
                for (int x = 0; x < board.Length; x++) {
                    if (board[x].Equals("-")) {
                        board[x] = "O";
                        best = Math.Max(best, minimax(board, depth + 1, !isMaximizer));
                        board[x] = "-";
                    }
                }
                return best;
            }
            else {
                int best = int.MaxValue;
                for (int x = 0; x < board.Length; x++) {
                    if (board[x].Equals("-")) {
                        board[x] = "X";
                        best = Math.Min(best, minimax(board, depth + 1, !isMaximizer));
                        board[x] = "-";
                    }
                }
                return best;
            }
        }

        public int FindBestMove(String[] board) {
            int bestValue = int.MinValue;
            int bestMove = -1;
            for (int x = 0; x < board.Length; x++) {
                if (board[x].Equals("-")) {
                    board[x] = "O";
                    int tempValue = minimax(board, 0, false);
                    board[x] = "-";
                    if (tempValue > bestValue) {
                        bestValue = tempValue;
                        bestMove = x;
                    }
                }
            }

            return bestMove;
        }

    }
}