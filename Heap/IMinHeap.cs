namespace Heap
{
    public interface IMinHeap
    {
        public void Insert(Int32 p);
        public void Remove(Int32 it);
        public Int32 GetMin();
        public Int32 ExtractMin();
        public void ChangePriority();
    }
}
