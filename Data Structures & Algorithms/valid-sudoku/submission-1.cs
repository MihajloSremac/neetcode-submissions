public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        HashSet<int>[] boxes = new HashSet<int>[9];
        for(int i = 0; i < 9; i++)
            boxes[i] = new HashSet<int>();


        for(int i = 0; i < 9; i++){
            HashSet<int> row = new HashSet<int>();
            HashSet<int> column = new HashSet<int>();
            for(int j = 0; j < 9; j++){

                if(board[i][j] != '.' && !row.Add(board[i][j])) return false;

                if(board[j][i] != '.' && !column.Add(board[j][i])) return false;



                if (board[i][j] != '.') {
                    int boxIndex = (i / 3) * 3 + (j / 3);

                    if(!boxes[boxIndex].Add(board[i][j])) return false;
                }
            }
        }



        return true;
    }
}
