using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Player_damage_calculation
{



    public interface incoming_damage 
    {
        double damage(double value);
    }
    public class Headshot : incoming_damage
    {
        [MyLoggerClass]
        public double damage(double h)
        {
            Console.WriteLine("Headshot method was called");
            return h * 2;
            Console.WriteLine("Headshot damage :" + h * 2);
        }
    }

    public class Limbshot : incoming_damage
    {
        [MyLoggerClass]
        public double damage(double l)
        {
            Console.WriteLine("Limbshot method was called");
            return l * 0.5;
            Console.WriteLine("Limbshot damage :" + l*0.5);
        }
    }

    public class Bodyshot : incoming_damage
    {
        [MyLoggerClass]
        public double damage(double b)
        {
            Console.WriteLine("Bodyshot method was called");
            return b * 1;
            Console.WriteLine("Bodyshot damage :" + b * 1);
        }

    }

    public class InterceptedClass
    {


        private static void Main(string[] args)
        {
            InterceptedClass interceptedClass = new InterceptedClass();
            Bodyshot interceptedBodyshot = new Bodyshot();
            Headshot interceptedHeadshot = new Headshot();
            Limbshot interceptedLimbshot = new Limbshot();
            interceptedBodyshot.damage(1);
            interceptedHeadshot.damage(1);
            interceptedLimbshot.damage(1);

            Console.ReadLine();
        }
    }


}
