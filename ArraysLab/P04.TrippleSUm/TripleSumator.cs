namespace P04.TrippleSUm
{
    using System;                   ////////////////////////////
    using System.Linq;              //    works but does not  //
                                    //    compile in judje    //
    class TripleSumator             //                        //
    {                               //                        //
        static void Main()          ////////////////////////////
        {
            var nums =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int y = i+1; y < nums.Length; y++)
                {
                    if (nums.Contains(nums[i] + nums[y]))
                    {
                        Console.WriteLine($"{nums[i]} + {nums[y]} == {nums[i] + nums[y]}");

                    }
                }
            }
        }
    }
}
