using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Player_damage_calculation
{



    public interface defaultSpeed
    {
        double speed(double value);
    }
    public class Run : defaultSpeed
    {
        
        public double speed(double run)
        {
            
            return run * 1;
            
        }
    }

    public class Sprint : defaultSpeed
    {
        [MyLoggerClass]
        public double speed(double sprint)
        {

            return sprint * 1.25;

        }
    }

    public class Walk : defaultSpeed
    {
        [MyLoggerClass]
        public double speed(double walk)
        {

            return walk * 0.75;

        }
    }

    public class Hamstring : defaultSpeed
    {
        [MyLoggerClass]
        public double speed(double hamstring)
        {

            return hamstring * 0.25;

        }
    }

    public class Stairs : defaultSpeed
    {
        [MyLoggerClass]
        public double speed(double stairs)
        {

            return stairs * 0.8;

        }
    }

    public class Water : defaultSpeed
    {
        [MyLoggerClass]
        public double speed(double water)
        {

            return water * 0.5;

        }
    }








}
