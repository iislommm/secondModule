namespace lesson2._8
{
    public interface IMyList
    {
        void RemoveItemAt(int index);
        void AddItemsRange(int[] numbers);
        void ReplaceAllItems(int oldElement, int newElement);
        int GetItemIndex(int index);
        int GetCount();
        int GetCapasity();
    }
}