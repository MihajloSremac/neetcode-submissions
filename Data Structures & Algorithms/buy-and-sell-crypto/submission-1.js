class Solution {
    /**
     * @param {number[]} prices
     * @return {number}
     */
    maxProfit(prices) {
        let l = 0;
        let r = 1;

        let profit = 0;

        while(r < prices.length){
            if(prices[l] > prices[r]){
                l = r;
                r++;
            }
            else{
                let currProfit = prices[r] - prices[l];

                profit = Math.max(profit, currProfit);
                r++;
            }
        }

        return profit;
    }
}
