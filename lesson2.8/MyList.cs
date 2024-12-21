namespace lesson2._8;

public class MyList<T> 
{
    private T[] items;
    private int count;
    private int item;

    public MyList()
    {
        items = new T[4];
        count = 0;
    }
    public MyList(int capasity)
    {
        items = new T[capasity];
        count = 0;
    }

    public void AddItem(T item)
    {
        if (count == items.Length)
        {
            Resize();
        }
        items[count++] = item;
    }

    public void AddItemsRange(T[] numbers)
    {
        foreach (var num in numbers)
        {
            AddItem(num);
        }
    }

    public int GetCapasity()
    {
        return items.Length;
    }

    public int GetCount()
    {
        return count;
    }

    public T GetItemAt(int index)
    {
        CheckIndex(index);
        return items[index];
    }

   

    public int GetItemIndex(T index)
    {
        for (int i = 0; i < count; i++)
        {
            if (object.Equals(items[i], item))
            {
                return i; 
            }

        }
        return -1;
    }

    public void RemoveItemAt(int index)
    {
        CheckIndex(index);
        for (var i = index; index < count - 1; ++i)
        {
            items[i] = items[i + 1];
        }
        count--;
        items[count] = default(T);

    }

    public void ReplaceAllItems(T oldElement, T newElement)
    {
        for (var i = 0; i < items.Length; i++)
        {
            if (object.Equals(items[i], oldElement) is true)
            {
                items[i] = newElement;
            }
        }
    }

    public void Resize()
    {
        var newItems = new T[items.Length * 2];
        for (var i = 0; i < items.Length; i++)
        {
            newItems[i] = items[i];
        }
        items = newItems;
    }
    private void CheckIndex(int index)
    {
        if (0 > index || count <= index)
        {
            throw new IndexOutOfRangeException ();
        }
    }

}
