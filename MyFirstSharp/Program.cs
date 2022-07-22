using System;

public class Solution
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] c = new int[2] { 1, 2 };
        int a  = solution.TwoSum(2, 3, "10", c);
        Console.WriteLine(a);
    }

    public int TwoSum(params object[] array)
    {
        int sum = 0;
        foreach (object element in array)
        {
            if (element.GetType() != typeof(System.Int32))
            {
                if (Int32.TryParse(element.ToString(), out int result))
                {
                    sum += result;
                    continue;

                }
                else
                {
                    Console.WriteLine($"Int32.TryParse could not parse '{element}' to an int.");
                    continue;
                }
            }
            
            sum += (int)element;
        }
        return sum;
    }
}

