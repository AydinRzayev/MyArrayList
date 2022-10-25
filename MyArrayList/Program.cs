


using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

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
            list.ReverseList();
            list.Print();

        }
    }
}

public class MyList
{
    private int[] _list = new int[0];

    public void Deletevalue()
    {
        /* for (int i = index; i < _list.Length - 1; i++)
        {
            _list[i] = _list[i + 1];

        }
        Array.Resize(ref _list, _list.Length - 1);
         */


    }

    public void Sort(bool descending)
    {
        Array.Sort(_list, 0, _list.Length);
        if (descending)
        {
            _list.Reverse();
        }
    }

    public void MaxValue(bool index)
    {
        int max = _list[0];
        int index_value = 0;
        for(int i = 0; i < _list.Length; i++)
        {
            if(_list[i] > max)
            {
                max = _list[i];
                index_value = i;
            }
        }
        if(index = true)
        {
            Console.WriteLine($"The index of element is {index_value}");
        }
        Console.WriteLine($"Maximum value is {max}");
    }
    public void MinValue(bool index)
    {
        int min = _list[0];
        int index_value = 0;
        for (int i = 0; i < _list.Length; i++)
        {
            if (_list[i] < min)
            {
                min = _list[i];
                index_value = i;
            }
        }
        if (index = true)
        {
            Console.WriteLine($"The index of element is {index_value}");
        }
        Console.WriteLine($"Maximum value is {min}");
    }
        
    

    public void ReverseList()
    {
        int [] array = new int[_list.Length];
        for(int i = 0; i < _list.Length; i++)
        {
            array[i] = _list[_list.Length - i - 1];
        }
        _list = array;
    }

    public int GetElement(int index)
    {
        return _list[index];
    }

    public void ChangeElement(int index, int value)
    {
        try
        {
            _list[index] = value;
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("There is not such an element. Use Add method.");
        }
    }

    public void GetIndexByValue(int Value)
    {
        int index = 0;
        int count = 0;
        for (int i = 0; i < _list.Length; i++)
        {
            if (_list[i] == Value)
            {
                index = i;
                count++;
                break;
            }
        }
        if (count == 0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(index);

        }

    }

    public int Length()
    {
        return _list.Length;
    }

    public void DeleteBy(int begin, int num)
    {
        for (int i = begin; i < _list.Length - num; i++)
        {
            _list[i] = _list[i + num];
        }
        Array.Resize(ref _list, _list.Length - num);
    }



    public void DeleteN(int num, bool beginning)
    {
        if ((beginning == false) && (num <= _list.Length))
        {
            Array.Resize(ref _list, _list.Length - num);
        }
        else if ((beginning == true) && (num <= _list.Length))
        {
            for (int i = 0; i < num; i++)
            {
                for (int k = 0; k < _list.Length - 1; k++)
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