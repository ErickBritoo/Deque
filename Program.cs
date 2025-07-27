namespace DequeProject
{
    class Program
    {
        static void Main()
        {
            Deque deque = new(5);

            deque.AddFront("Erick");
            deque.AddFront("Maria");

            deque.AddRear("Elias");
            deque.AddRear("Diana");
            deque.AddRear("Enzzo");

            deque.AddRear("Ellen");


            string nome = deque.PeekFront();
            string lastName = deque.PeekRear();

            Console.WriteLine(nome);
            Console.WriteLine(lastName);
        }
    }
}