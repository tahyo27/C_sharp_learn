﻿namespace ThreadingE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World! 1");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello, World! 2");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello, World! 3");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello, World! 4");
            //Thread.Sleep(1000);
            //Console.WriteLine("Hello, World! 5");

            new Thread(() => 
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();

            var taskCompletionSource = new TaskCompletionSource<bool>();
            var test = taskCompletionSource.Task.Result;

            Console.ReadKey();
        }
    }
}
