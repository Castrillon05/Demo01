using MyLibrary;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageWriter MyWriter = new MessageWriter();
            MyWriter.write("Hello, writer!");

            FiggleWriter Fwriter = new FiggleWriter();
            Fwriter.Write("Hello, Figgle!!!");
        }
    }
}
