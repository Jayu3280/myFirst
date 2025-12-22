using System;

namespace myFirst
{
    class Device
    {
        public virtual void TurnOn()
        {
            Console.WriteLine("Turning on Generic Device");
        }
    }

    class TV : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("TV is On");
        }
    }

    class AC : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("AC is On");
        }
    }

    class MusicSystem : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Music is On now, Enjoy the Song");
        }
    }

    class Fan : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Fan is On");
        }
    }

    internal class method_overriding
    {
        static void Main(string[] args)
        {
            Device r1 = new TV();
            r1.TurnOn();

            Device r2 = new AC();
            r2.TurnOn();

            Device r3 = new MusicSystem();
            r3.TurnOn();

            Device r4 = new Fan();
            r4.TurnOn();

            Console.ReadLine();
        }
    }
}
