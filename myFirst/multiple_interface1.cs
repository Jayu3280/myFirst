using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirst
{

    public interface IFather1
    {
        void Teach(string subject, int hours);

        void Guide(string topic);

    }
    public interface IFather2
    {
        void Play(string game, int duration);
        void Encourage(string activity);

    }
    public class Child : IFather1, IFather2
    {
        public void Teach(string subject, int hours)
        {
            Console.WriteLine($"Child Learning {subject} for {hours} hours form father1");

        }

        public void Guide(string topic)
        {
            Console.WriteLine($"Child is Guided on Topic {topic} by Father1");

        }
        public void Play(string game, int duration)

        {
            Console.WriteLine($"Child is playing {game}, for {duration} minuts with father 2");
        }
        public void Encourage(string activity)
        {
            Console.WriteLine($"Child is encourage to do {activity} by father 2");
        }
    }
    internal class multiple_interface1
    {
        static void Main(string[] args)
        {
            Child c = new Child();

            c.Teach("Math", 3);
            c.Guide("History Project");

            c.Play("Cricket", 40);
            c.Encourage("Teamwork");

            Console.ReadLine();
        }
    }
}
