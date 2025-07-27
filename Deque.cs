namespace DequeProject
{

    // Deque permite remoção e inserção em ambas extremidades
    // Então deve ter um addFront, addRear(), RemoveFront(), RemoveRear()
    internal class Deque
    {
        private string[] _items;   
        private int _front;
        private int _rear;
        public int Count { get; private set; }

        public Deque(int size)
        {
            /* O Deque começará do meio da lista
             * Existem algumas vantagens da utilização dessa abordagem
             * Vai evitar a realocação de memória imediatamente
             * A lista vai poder crescer nas duas extremidades 
             */

            _items = new string[size];
            _front = size / 2;
            _rear = _front;
            Count = 0;
        }

        public bool IsEmpty => Count == 0;
        public bool IsFull => Count == _items.Length;


        public bool AddFront(string element)
        {
            if (IsFull || _front == 0)
                return false;

            _front--;
            _items[_front] = element;
            Count++;
            return true;
        }

        public bool AddRear(string element)
        {
            if (IsFull || _rear == _items.Length) return false;

            _items[_rear] = element;
            Count++;
            _rear++;
            return true;
        }

        public string PeekFront()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Deque está vazio");

            return _items[_front];
        }

        public string PeekRear()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Deque está vazio");

            return _items[_rear - 1];
        }
    }
}
