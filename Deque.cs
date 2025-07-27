namespace DequeProject
{

    // Deque permite remoção e inserção em ambas extremidades
    // Então deve ter um addFront, addRear(), RemoveFront(), RemoveRear()
    internal class Deque
    {
        private string[] _items;   
        private int _front;
        private int _rear;
        private int _count;

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
            _count = 0;
        }


    }
}
