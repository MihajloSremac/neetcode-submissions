public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l = 0; int r = matrix.Length - 1;
        int row = SearchRow(l,r,matrix,target);

        if(row == -1) return false;
        
        l = 0; r = matrix[row].Length - 1; 

        return BinarySearch(l,r,matrix[row], target) != -1 ? true : false;
    }

    public int BinarySearch(int l, int r, int[] matrix, int target){
        if(l > r) return -1;

        int mid = l + ((r-l)/2);

        if(matrix[mid] == target) return mid;
        else if(matrix[mid] < target)
            return BinarySearch(mid+1,r,matrix,target);
        else
            return BinarySearch(l,mid-1,matrix,target);
    }

    public int SearchRow(int l, int r, int[][] matrix, int target){
        if(l>r) return -1;

        int mid = l + ((r-l)/2);

        int res = -1;

        if(matrix[mid][0] <= target && matrix[mid][matrix[mid].Length - 1] >= target)
            return mid;
        else if(matrix[mid][0] > target)
            res = SearchRow(l, mid - 1, matrix, target);
        else if(matrix[mid][matrix[mid].Length - 1] < target)
            res = SearchRow(mid + 1, r, matrix, target);

        return res;
    }
}
