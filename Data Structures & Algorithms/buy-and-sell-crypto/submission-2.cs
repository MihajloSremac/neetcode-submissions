public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 0;
        int sell = 1;

        int profit = 0;
        while (sell < prices.Length){
            if(prices[buy] > prices[sell]){
                buy = sell;
                sell++;
            }
            else{
                profit = Math.Max(profit, (prices[sell]-prices[buy]));
                sell++;
            }
        }

        return profit;
    }
}
