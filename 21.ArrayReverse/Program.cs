using System;
using System.Linq;

namespace _21.ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type how many numbers you will insert in the array:");
            //type how many numbers will insert
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Type numbers in array:");
            //array
            int[] nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            //sort
                for (int i = 0; i < nums.Length / 2; i++)
                {
                    int ReverseArrayRecursively = nums[i];
                    nums[i] = nums[nums.Length - i - 1];
                    nums[nums.Length - i - 1] = ReverseArrayRecursively;
                    
                }
                //print
            Console.WriteLine(string.Join(" ", nums));



            /*направих я така, защото не се сетих как мога да я направя както е по условието
            тук просто се въвеждат числа всяко на нов ред като първо се задава колко числа ще се въвеждат
            и при достигане на крайния брой числа извежда масива в обратен ред.
            Условието малко ме обърка и много ме забави с тази задача, и понеже не успях да я подкарам
            както трябва да е все нещо крашваше я оставих така.*/
        }
    }
}
