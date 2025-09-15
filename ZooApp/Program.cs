using ZooApp.Services;

namespace ZooApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new ZooService().Run();
          
        }
    }
}
