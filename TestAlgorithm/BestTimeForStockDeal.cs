
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithm
{
    class BestTimeForStockDeal
    {
        public static int MaxProfit(int[] prices)
        {
           
            int len = prices.Length;
            int profit = 0;
            int[,] profits = new int[len,len];
            for(int i=0;i<prices.Length;i++)
            {
                for(int j = i + 1; j < prices.Length; j++)
                {
                    int m = profits[i, j] - profits[i, 0];
                    profits[i, j] = m > 0 ? m : 0;

                }
            }
            
            return profit;
           
        }
        
        public static void Test()
        {
            int[] arr = new int[5]{1,2,3,4,5};
            int profit = MaxProfit(arr);
            Console.WriteLine($"最大利润{profit}");
        }

    }
}
