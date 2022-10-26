public class Kata
{
    public static int MinUnfairness(int[] arr, int k)
    {
        if(arr.Length<2 || k==0)
        {
            return 0;
        }
        Array.Sort(arr);
        List<int> list = new List<int>();
        list = arr.Where((x,i) => i<k && x>0).ToList();
        return list.Max()-list.Min();
    }
}