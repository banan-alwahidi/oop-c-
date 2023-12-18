using System;
public class program
{
    public static void Main()
    {
        // value type : built-in
        int number;
        Console.WriteLine("Enter your number");
        number=int.Parse(Console.ReadLine());
        Console.WriteLine(number);
        // Refernce type : built-in
        int[] nums = new int[number];
        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] =int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}