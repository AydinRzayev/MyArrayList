using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

// Very commenting of your code. Can make it even better if you use XML comment. I changed comment for Add method just as an example.

// In some tasks I used boolean parameters for nearly similar tasks. You have already xplained the tasks about adding arrays to the arraylists so I didn't code it for avoid repetition.
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
        }
    }
}

public class MyList
{
    // It is better to rename variable _list since it is array and it might be confusing with List<T> class.
    private int[] _list = new int[0];

    //I have created ony the default constructor. Actually, didn't find a reason to add the contructors based on one element or array
    public MyList()
    {
        // You can save some lines of the code by moving array initialisation to the defenition of array.
        // Please see my changes. If you move initialisation this constructor can be removed.
        _list = new int[0];
    }

    /// <summary>
    /// Adds element to the end
    /// </summary>
    /// <param name="num"></param>
    public void Add(int num)
    {
        Array.Resize(ref _list, _list.Length + 1);
        _list[_list.Length - 1] = num;
    }
    
    //Deletes the first element equal to the value
    public int DeleteFirsValue(int val)
    {
        int count = 0;
        for (int i = 0; i < _list.Length; i++)
        {
            if (_list[i] == val)
            {
                _list[i] = _list[i + 1];
                count++;
            }
        }
        Array.Resize(ref _list, _list.Length - 1);
        return count;
    }
    
    //Deletes all elements equal to the value 
    public int DeleteValue(int val)
    {
        int count = 0;
        for (int i = 0; i < _list.Length; i++)
        {
            if (_list[i] == val)
            {
                _list[i] = _list[i + 1];
                count++;
            }
        }
        Array.Resize(ref _list, _list.Length - 1);
        return count;
    }
    
    //Sorts the list. If the descending parametr is tru then reverses the sorted list 
    public void Sort(bool descending)
    {
        Array.Sort(_list, 0, _list.Length);
        if (descending)
        {
            _list.Reverse();
        }
    }
    
    //finds the maximum value of the list
    public void MaxValue(bool index)
    {
        int max = _list[0];
        int index_value = 0;
        for (int i = 0; i < _list.Length; i++)
        {
            if (_list[i] > max)
            {
                max = _list[i];
                index_value = i;
            }
        }
        if (index)
        {
            Console.WriteLine($"The index of element is {index_value}");
        }
        Console.WriteLine($"Maximum value is {max}");
    }
    
    //Finds thge minimum vALUE OF the list
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
        if (index)
        {
            Console.WriteLine($"The index of element is {index_value}");
        }
        Console.WriteLine($"Maximum value is {min}");
    }
    
    // Reverses List 
    public void ReverseList()
    {
        int[] array = new int[_list.Length];
        for (int i = 0; i < _list.Length; i++)
        {
            array[i] = _list[_list.Length - i - 1];
        }
        _list = array;
    }

    //returns value of some index
    public int GetElement(int index)
    {
        return _list[index];
    }

    //Changes element in some index
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
    
    //Finds value of some index
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
    
    // returns the length of of list
    public int Length()
    {
        return _list.Length;
    }
    
    //Deletes element beginning from some element
    public void DeleteBy(int begin, int num)
    {
        for (int i = begin; i < _list.Length - num; i++)
        {
            _list[i] = _list[i + num];
        }
        Array.Resize(ref _list, _list.Length - num);
    }

    //Deletes n range of element
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
    
    //Deletes last element
    public void Delete(int index)
    {

        for (int i = index; i < _list.Length - 1; i++)
        {
            _list[i] = _list[i + 1];

        }
        Array.Resize(ref _list, _list.Length - 1);
    }
    
    //Adds element to the particular index
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
    
    //Adds element at the beginning
    public void AddAtTheBeginning(int num)
    {
        Array.Resize(ref _list, _list.Length + 1);
        for (int i = _list.Length - 1; i > 0; i--)
        {
            _list[i] = _list[i - 1];

        }
        _list[0] = num;
    }
    
    //prints the list
    public void Print()
    {
        for (int i = 0; i < _list.Length; i++)
        {
            Console.WriteLine(_list[i]);
        }
    }
}


