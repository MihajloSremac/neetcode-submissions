public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;
        int r = 1;

        int profit = 0;
        while(r < prices.Length){
            if(prices[l] > prices[r]){
                l = r;
                r++;
            }
            if(r < prices.Length)
                profit = Math.Max(prices[r] - prices[l], profit);
            r++;
        }

        return profit;
    }
}
