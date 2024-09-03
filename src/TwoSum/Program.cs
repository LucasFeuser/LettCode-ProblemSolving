public class Program
{
    static void Main(string[] args)
    {
        Random rd = new Random();
        int[] nums = { rd.Next(0,9), rd.Next(0,9), rd.Next(0,9), rd.Next(0,9), rd.Next(0,9) };
        int target = nums[rd.Next(0,4)] + nums[rd.Next(0,4)];
        Console.WriteLine("Target: {0} | Array: {1}, {2}, {3}, {4}, {5}", target, nums[0], nums[1], nums[2], nums[3], nums[4]);
        
        var resultOn2 = TwoSum(nums, target);
        Console.WriteLine(resultOn2[0] + " " + resultOn2[1]);
        
        var resultOn = TwoSum(nums, target, 0);
        Console.WriteLine(resultOn[0] + " " + resultOn[1]);
    }

    //O(n^2)
    static int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return result;
    }

    //O(n)
    static int[] TwoSum(int[] nums, int target, int overload = 0)
    {
        Dictionary<int, int> hashMap = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int diferenca = target - nums[i];

            if (hashMap.ContainsKey(diferenca))
            {
                return [hashMap[diferenca], i];
            }
            
            hashMap[nums[i]] = i;
        }

        return null;
    }
}