namespace Heap
{
    public class MinHeap : List<Int32>, IMinHeap
    {
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
            return this[0];
        }

        public void Insert(Int32 p) 
        {
            this.Add(p);
            SiftDown();
        }

        public new void Remove(Int32 it)
        {
            return;
        }

        private void SiftDown()
        {
            Int32 i = this.Count - 1;
            while (this[i] < this[i / 2] && i / 2 >= 0 )
            {
                Int32 x = this[i];
                this[i] = this[i / 2];
                this[i / 2] = x;
                i = i / 2;
            }
        }
        private void SiftUp()
        {
            return;
        }
    }
}
