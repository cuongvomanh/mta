using System;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            Bird bird = new Bird();
            Dog dog = new Dog();
            snake.go();
            snake.run();
            bird.go();
            bird.run();
        }
    }
}
