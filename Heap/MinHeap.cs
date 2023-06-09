namespace Heap
{
    public class MinHeap : IMinHeap
    {
        private List<int> _heap = new List<int> { };
        public void ChangePriority()
        {
            throw new NotImplementedException();
        }

        public int ExtractMin()
        {
            throw new NotImplementedException();
        }

        public int GetMin()
        {
            return _heap[0];
        }

        public void Insert(Int32 p) 
        {
            _heap.Add(p);
        }

        public void Remove(int it)
        {
            throw new NotImplementedException();
        }
    }
}
