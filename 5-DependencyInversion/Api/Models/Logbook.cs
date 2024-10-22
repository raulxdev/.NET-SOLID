using System.Text;

namespace DependencyInversion
{
    public class Logbook : ILoogBook
    {
        public void Add(string description)
        {
            File.AppendAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logbook.txt"), $"{description}\n", Encoding.Unicode);
        }
    }
    
    public interface ILoogBook
    {
         void Add(string description);
    }
}