using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if (A.Length <= 2)
            return 0;
        
        int left = 0, right = A.Length-1;
        double left2Avrg = (A[left] + A[left+1]) / 2.0;
        double right2Avrg = (A[right] + A[right-1]) / 2.0;
        
        double temp1 = 0.0, temp2 = 0.0;
        
        while (true)
        {
            if (left2Avrg > right2Avrg)
            {
                left++;
            }
            else
            {
                right--;
            }
            
            if (left >= right)
                break;
            
            temp1 = (A[left] + A[left+1]) / 2.0;
            temp2 = (left+2 < A.Length) ? (A[left] + A[left+1] + A[left+2]) / 3.0: temp1;
            left2Avrg = Math.Min(temp1, temp2);
            
            temp1 = (A[right] + A[right-1]) / 2.0;
            temp2 = (right-2 >= 0) ? (A[right] + A[right-1] + A[right-2]) / 3.0 : temp1;
            right2Avrg = Math.Min(temp1, temp2);
        }
        return left;
    }
}
