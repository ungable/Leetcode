TwoSum([2,7,11,15], 9);
TwoSum([3,2,4], 6);
TwoSum([3,3], 6);
TwoSum([2,5,5,11], 10);


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