public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char> line = new HashSet<char>();

        for (int i = 0; i < 9; i++) {
            line = new HashSet<char>();

            for (int j = 0; j < 9; j++) {
                if (board[i][j] == '.') {
                    continue;
                }

                if (line.Contains(board[i][j])) {
                    return false;
                } else {
                    line.Add(board[i][j]);
                }
            }
        }

        for (int i = 0; i < 9; i++) {
            line = new HashSet<char>();

            for (int j = 0; j < 9; j++) {
                if (board[j][i] == '.') {
                    continue;
                }

                if (line.Contains(board[j][i])) {
                    return false;
                } else {
                    line.Add(board[j][i]);
                }
            }
        }

        for (int i = 0; i <= 6; i+=3) {
            for (int j = 0; j <= 6; j+=3) {
                if (!MiniSudoku(board, i, j)) {
                    return false;
                }
            }
        }

        return true;
    }

    private bool MiniSudoku(char[][] board, int line, int column) {
        HashSet<char> h = new HashSet<char>();

        for (int i = line; i < line + 3; i++) {
            for (int j = column; j < column + 3; j++) {
                if (board[i][j] == '.') {
                    continue;
                }

                if (h.Contains(board[i][j])) {
                    return false;
                } else {
                    h.Add(board[i][j]);
                }
            }
        }

        return true;
    }

    /*
    0 0, 0 3, 0 6
    3 0, 3 3, 3 6
    6 0, 6 3, 6 6
    */
}
