

namespace MyArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.DeleteN(9, true);
            list.Print();

        }
    }
}

public class MyList
{
    private int[] _list = new int[0];


    /*for (int i = index; i < _list.Length - 1; i++)
    {
        _list[i] = _list[i + 1];

    }
    Array.Resize(ref _list, _list.Length - 1);*/
    public void DeleteN(int num, bool beginning)
    {
        if((beginning == false) && (num <= _list.Length))
        {
            Array.Resize(ref _list, _list.Length - num);
        }
        else if((beginning == true) && (num <= _list.Length))
        {
            for(int i = 0; i < num; i++)
            {
                 for (int k = 0 ; k < _list.Length - 1; k++)
                 {
                   _list[k] = _list[k + 1];
                 }
            }
            Array.Resize(ref _list, _list.Length - num);
        }
       
        
        
       
        
    }

    public void Delete(int index)
    {

        for (int i = index; i < _list.Length - 1; i++)
        {
            _list[i] = _list[i + 1];

        }
        Array.Resize(ref _list, _list.Length - 1);
    }
    public void Add(int num, int index)
    {
        if (index == null)
        {
            Array.Resize(ref _list, _list.Length + 1);
            _list[_list.Length - 1] = num;
        }
        else
        {
            Array.Resize(ref _list, _list.Length + 1);
            for (int i = _list.Length - 1; i > index; i--)
            {
                _list[i] = _list[i - 1];

            }
            _list[index] = num;
        }

    }
    public void Add(int num)
    {
        Array.Resize(ref _list, _list.Length + 1);
        _list[_list.Length - 1] = num;
    }
    public void AddAtTheBeginning(int num)
    {
        Array.Resize(ref _list, _list.Length + 1);
        for (int i = _list.Length - 1; i > 0; i--)
        {
            _list[i] = _list[i - 1];

        }
        _list[0] = num;
    }

    public void Print()
    {
        for (int i = 0; i < _list.Length; i++)
        {
            Console.WriteLine(_list[i]);
        }
    }
}
