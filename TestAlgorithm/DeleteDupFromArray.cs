// ************************************************************************
//  
// Copyright © 2010-2018 wuhan wangyou tec.Corporation,All Rights Reserved.
// 版权所有：     武汉网友科技有限公司
//
// 作者(Author):                    毛善丽
//
// 数据表(Table):
//
// 创建日期(Create Time):
//
// 说明（Description):
//
// 修改记录（Revision History)：
//    R1: 
//           
// ************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithm
{
    class DeleteDupFromArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int number = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                // 相邻两个值比较，不同才做统计操作
                if (nums[i] != nums[number])
                {
                    number++;
                    nums[number] = nums[i];
                }
            }
            // 不同数字为总量= number+1
            return ++number;

           
        }
        public static void Test()
        {
            int[] arr = new int[4];
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 1;
            arr[3] = 4;
            int len = RemoveDuplicates(arr);

            // 在函数里修改输入数组对于调用者是可见的。
            // 根据你的函数返回的长度, 它会打印出数组中该长度范围内的所有元素。
            for (int i = 0; i < len; i++)
            {
               Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
