public class Solution {
    public bool IsValidSudoku(char[][] board) {

        HashSet<char>[] boxes = new HashSet<char>[9];

        for(int i = 0; i < 9; i++){
            boxes[i] = new HashSet<char>();
        }

        for(int i = 0; i < 9; i++){
            HashSet<char> row = new HashSet<char>();
            HashSet<char> column = new HashSet<char>();
            for(int j = 0; j < 9; j++){
                if(board[i][j] != '.' && !row.Add(board[i][j]))
                    return false;

                if(board[j][i] != '.' && !column.Add(board[j][i]))
                    return false;

                int boxNum = (i / 3) * 3 + (j / 3);

                if(board[i][j] != '.' && !boxes[boxNum].Add(board[i][j]))
                    return false;
            }
        }

        return true;
    }
}
