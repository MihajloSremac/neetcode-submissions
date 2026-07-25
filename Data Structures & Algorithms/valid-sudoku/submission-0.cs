public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        Dictionary<string, List<int>> nbn = new Dictionary<string, List<int>>();

        for(int i = 0; i < 9; i++){
            HashSet<int> row = new HashSet<int>();
            HashSet<int> column = new HashSet<int>();
            for(int j = 0; j < 9; j++){
                if(row.Contains(board[i][j]) || column.Contains(board[j][i]))
                    return false;

                if(board[i][j] != '.')
                    row.Add(board[i][j]);

                if(board[j][i] != '.')
                    column.Add(board[j][i]);

                if (board[i][j] != '.') {
                    string nbnKey = (i / 3).ToString() + (j / 3).ToString();

                    if(nbn.ContainsKey(nbnKey)){
                       if(nbn[nbnKey].Contains(board[i][j]))
                            return false;
                        nbn[nbnKey].Add(board[i][j]);
                    }
                    else {
                        nbn.Add(nbnKey, new List<int> { board[i][j] });
                    }
                }
            }
        }



        return true;
    }
}
