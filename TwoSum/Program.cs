
Console.WriteLine(TwoSum([2,5,5,11], 10));

int[] TwoSum(int[] nums, int target)
{
   for (int x = 0; x < nums.Length; x++)
   {
      for (int y = x + 1; y < nums.Length; y++)
      {
         Console.WriteLine(nums[y]);
         if (nums[x] + nums[y] == target )
         {
            nums = [x,y];
            return nums;
         }         
      }       
   }
   return nums;
}