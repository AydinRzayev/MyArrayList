namespace MyArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
        }
    }
}

public class MyList
{
    private int[] _list = new int[0];

    private void FillListBy(int num, bool AtTheEnd, bool AtTheBeginning)
    {
        if(AtTheEnd == true)
        {
            Array.Resize(ref _list, 1);
            _list[_list.Length - 1] = num;
        }
        else if(AtTheBeginning == true)
        {

        }
    }
}