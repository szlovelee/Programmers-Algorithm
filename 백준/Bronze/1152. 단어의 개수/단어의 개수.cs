public class Solution 
{
    static void Main(string[] args)
    {
        Solution solutionInstance = new Solution();
        string sentense = Console.ReadLine();
        solutionInstance.solution(sentense);
    }
    public void solution(string sentense)
    {
        int count = 0;
        bool hasWordStarted = false;
        foreach (char c in sentense)
        {
            if (!hasWordStarted)
            {
                if (c != ' ')
                {
                    hasWordStarted = true;
                    count ++;
                }
            }
            else 
            {
                if (c == ' ')
                {
                    hasWordStarted = false;
                }
            }
        }
        Console.WriteLine(count);
    } 
}