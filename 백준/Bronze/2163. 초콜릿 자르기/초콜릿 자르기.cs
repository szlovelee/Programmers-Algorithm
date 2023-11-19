public class Solution
{
    static void Main(string[] args)
    {
        Solution solutionInstance = new Solution();
        
        string input = Console.ReadLine();
        
        string[] splited = input.Split(" ");
        
        int a = int.Parse(splited[0]);
        int b = int.Parse(splited[1]);
        
        solutionInstance.SplitChocolate(a, b);
    }
    
    public void SplitChocolate(int a, int b)
    {
        int larger = (a >= b)? a : b;
        int smaller = (larger == b)? a : b;
        
        int answer = (larger - 1) + (smaller - 1) * larger;
        Console.WriteLine(answer);        
    }
}