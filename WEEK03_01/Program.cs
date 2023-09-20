using System;
using System.Windows.Forms;

namespace WEEK03_01
{
    internal class Program
    {
        [STAThread] //쓰레드를 사용
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("WIndows Form 시작");
            Application.Run(new Form1());
            Console.WriteLine("Windows Form 종료");
        }
    }
}
