using System;
using NUnit.Framework;

namespace Player_damage_calculation.Test
{
    [TestFixture]
    public class RunTest
    {
        Run running = new Run();

        [Test, TestCaseSource("MovementTable")]
        public void defaultspeed(double run, double speed)
        {

            Assert.AreEqual(speed, running.speed(run), 0.01);
        }



        static object[] MovementTable =
        {
            new object[] { 1, 1},
        };
    }

    [TestFixture]
    public class WalkTest
    {
        Walk walking = new Walk();

        [Test, TestCaseSource("MovementTable")]
        public void defaultspeed(double walk, double speed)
        {

            Assert.AreEqual(speed, walking.speed(walk), 0.01);
        }



        static object[] MovementTable =
        {
            new object[] { 1, 0.75},
        };
    }
    [TestFixture]
    public class SprintTest
    {
        Sprint sprinting = new Sprint();

        [Test, TestCaseSource("MovementTable")]
        public void defaultspeed(double sprint, double speed)
        {

            Assert.AreEqual(speed, sprinting.speed(sprint), 0.01);
        }



        static object[] MovementTable =
        {
            new object[] { 1, 1.25},
        };
    }

    [TestFixture]
    public class StairsTest
    {
        Stairs stair = new Stairs();

        [Test, TestCaseSource("MovementTable")]
        public void defaultspeed(double stairs, double speed)
        {

            Assert.AreEqual(speed, stair.speed(stairs), 0.01);
        }



        static object[] MovementTable =
        {
            new object[] { 1, 0.8},
        };
    }

    [TestFixture]
    public class WaterTest
    {
        Water swimming = new Water();

        [Test, TestCaseSource("MovementTable")]
        public void defaultspeed(double water, double speed)
        {

            Assert.AreEqual(speed, swimming.speed(water), 0.01);
        }



        static object[] MovementTable =
        {
            new object[] { 1, 0.5},
        };
    }

    [TestFixture]
    public class HamstringTest
    {
        Hamstring slowed = new Hamstring();

        [Test, TestCaseSource("MovementTable")]
        public void defaultspeed(double hamstring, double speed)
        {

            Assert.AreEqual(speed, slowed.speed(hamstring), 1);
        }



        static object[] MovementTable =
        {
            new object[] { 1, 0.25},
        };
    }
}