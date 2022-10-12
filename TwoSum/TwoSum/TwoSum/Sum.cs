using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace TwoSum;

public class Sum
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> indexMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int requiredNum = target - nums[i];
            if (indexMap.ContainsKey(requiredNum))
            {
                return new int[] { indexMap[requiredNum], i };
            }

            if (indexMap.ContainsKey(nums[i]))
            {
                indexMap[nums[i]] = i;
            }
            else
            {
                indexMap.Add(nums[i], i);
            }
        } 
        return new int[0];
    }

    public static int[] TwoSumHash(int[] nums, int target)
    {
        string[] cars;
        cars = new string[] { };
        string[] result = new string[] { };

        Hashtable hash = new Hashtable();
        for (var i = 0; i < nums.Length; i++)
        {
            if (hash.Contains(nums[i]))
            {
                return new int[] { (int)hash[nums[i]], 1 };
            }

            if (!hash.Contains(target - nums[1]))
            {
                hash.Add(target-nums[i], i);
            }
        }

        return new int[] { 0, 0 };
    }

    public static int[] TwoSumHashOnePass(int[] nums, int target)
    {
        var Hash = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var result = target - nums[i];


            if (Hash.ContainsKey(result))
            {
                Hash.ToList().ForEach(x => Console.WriteLine(x.Key));
                return new int[] { Hash[result], i };
                // return new int[] { Hash.FirstOrDefault(x => x.Value == result).Key, nums[i] };
            }

            Hash[nums[i]] = i;
        }
        return new int[] { 0, 0 };
    }
    
    
    public static string[] inArray(string[] array1, string[] array2)
    {

        List<string> result = new List<string>();
        Array.Sort<string>(array1);
        
        for (var i = 0; i < array1.Length; i++) 
        {
            for (var x = 0; x < array2.Length; i++)
            {
                if (array2[x].IndexOf(array1[i]) != -1)
                {
                    result.Add(array1[i]);
                }
            }
        }

        var final = result.ToArray();
        return final;
        
    }
}