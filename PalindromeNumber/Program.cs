Console.WriteLine(IsPalindrome(101));

bool IsPalindrome(int x)
{
   // if (x < 0) return false;
   // string str = Convert.ToString(x);
   // for (int y = 0; y < str.Length / 2; y++)
   // {
   //    if(str[y] != str[str.Length - 1 - y]) return false;
   // }
   // return true;


   // мне нравится больше всего это решение
   
   // if (x < 0) return false;
   // string str = x.ToString();
   // int left = 0;
   // int right = str.Length - 1;
   // while (left < right)
   // {
   //    if(str[left] != str[right])
   //    {
   //       return false;
   //    }
   //    left++;
   //    right--;
   // }
   // return true;


   int y = 0, z = x;
   while (z > 0)
   {
      y = y * 10 + z % 10;
      z /= 10;
   }
   return x == y;
}