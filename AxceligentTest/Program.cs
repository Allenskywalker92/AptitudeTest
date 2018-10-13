using System;
using System.Linq;

namespace AxceligentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 1, 6, 1, 2, 6, 1, 6, 6 };
            Console.WriteLine(Challenge(test));
            Console.ReadLine();
        }

        public static int Challenge(int[] input)
        {
            var result = 0;
            var groupedList = (from index in input
                               orderby index
                               group index by index into grp
                               select new { key = grp.Key, count = grp.Count() })
                        .OrderByDescending(x => x.count).ToList();
            var minimumRepeat = groupedList[0].count - 1;
            var itemsLeft = groupedList.Where(x => x.count >= minimumRepeat).Select(x => x.key);

            var filteredInputList = input.Where(x => itemsLeft.Contains(x)).ToList();
            var sum = 0;
            for (int i = 0; i < filteredInputList.Count - 1; i++)
            {
                sum = filteredInputList[i] + filteredInputList[i + 1];
                if (sum >= result)
                {
                    result = sum;
                }
            }

            return result;
        }

    }
}
