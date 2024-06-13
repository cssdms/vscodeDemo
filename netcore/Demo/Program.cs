namespace Demo;
class Program
{
    static void Main(string[] args)
    {
        string str = "";
        Console.WriteLine("Hello, World!");
        str += "你1好";
        System.Console.WriteLine(str);
        System.Console.WriteLine("这是一个中文乱码测试");

        if (string.IsNullOrEmpty(""))
        {

        }

        Console.ReadKey();
    }
}
