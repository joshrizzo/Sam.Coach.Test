using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sam.Coach
{
    internal class LongestRisingSequenceFinder : ILongestRisingSequenceFinder
    {
        public Task<IEnumerable<int>> Find(IEnumerable<int> numbers) => Task.Run(() =>
        {
            var longestSeq = new List<int>();
            var nums = numbers.ToList();

            for (int i = 0; i < nums.Count() - 1; i++)
            {
                List<int> thisSeq = GetSeqFrom(nums, i);

                if (thisSeq.Count > longestSeq.Count)
                {
                    longestSeq = thisSeq;
                }
            }

            return longestSeq.AsEnumerable();
        });

        private List<int> GetSeqFrom(List<int> nums, int i)
        {
            var thisSeq = new List<int>() { nums[i] };
            var thisNum = nums[i];
            var nextNum = nums[i + 1];
            var currentIndex = i;

            while (nextNum > thisNum)
            {
                thisSeq.Add(nextNum);

                if (currentIndex == nums.Count - 2) break;

                currentIndex++;
                thisNum = nums[currentIndex];
                nextNum = nums[currentIndex + 1];
            }

            return thisSeq;
        }
    }
}
