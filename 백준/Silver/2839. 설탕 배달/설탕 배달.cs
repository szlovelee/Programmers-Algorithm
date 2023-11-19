public class Solution
{
    static void Main(string[] args)
    {
        Solution solutionInstance = new Solution();
        
        int sugar = int.Parse(Console.ReadLine());
        
        solutionInstance.BagCount(sugar);
    }
    
    public void BagCount(int sugar)
    {
        int bagCount = 0;
        while (sugar % 5 != 0 && sugar >= 3)
        {
            sugar -= 3;
            bagCount ++;
        }
        
        if (sugar != 0)
        {
            if (sugar % 5 == 0)
            {
                bagCount += sugar / 5;
            }
            else
            {
                bagCount = -1;
            }
        }
        
        Console.WriteLine(bagCount);
    }
}