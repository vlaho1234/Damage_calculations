using System;
using NUnit.Framework;

namespace Player_damage_calculation.Test
{
    [TestFixture]
    public class HeadshotTest
    {
        Headshot headshotDamage = new Headshot();

        [Test, TestCaseSource("DamageTable")]
        public void Incoming_damage(double h, double i)
        {

            Assert.AreEqual(i, headshotDamage.damage(h), 0.1);
        }



        static object[] DamageTable =
        {
            new object[] { 1, 2 },
            new object[] { 34, 68 },
            new object[] { 15, 30 },
            new object[] { 11.1, 22 }
        };
    }
}