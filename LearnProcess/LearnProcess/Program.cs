using System.Diagnostics;

namespace LearnProcess
{

    internal class Program
    {
        static void Foo()
        {
            int pid = Process.GetCurrentProcess().Id;
            Console.WriteLine($">>>>> PID : {pid}");
            Console.WriteLine($"스레드 실행 중: {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(1000); 
            Console.WriteLine($"스레드 종료: {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Main(string[] args)
        {
            /*
            int pid = Process.GetCurrentProcess().Id;
            Console.WriteLine($">>>>> PID : {pid}");

            Process childProcess = new Process();
            childProcess.StartInfo.FileName = "notepad.exe";
            childProcess.Start();
             // C# 에서는 C++과 다르게 fork()가 없어서 메모장 실행해봄
            Console.WriteLine($"자식 프로세스 생성됨. PID: {childProcess.Id}");
            */

            // 스레드 객체 생성
            Thread thread1 = new Thread(Foo);
            Thread thread2 = new Thread(Foo);
            Thread thread3 = new Thread(Foo);

            // 스레드 시작
            thread1.Start();
            thread2.Start();
            thread3.Start();

            // 스레드가 종료될 때까지 대기
            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("모든 스레드가 종료되었습니다.");
        }
    }
}
