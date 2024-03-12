namespace arrays_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 21, 34, 5, 67, 8 };
            int minelement = nums[0];
            for(int i=0 ; i<nums.Length; i++)
            {
             if (nums[i] < minelement)
                {
                    minelement = nums[i];
                }
            } Console.WriteLine(minelement);
        }
    }
}