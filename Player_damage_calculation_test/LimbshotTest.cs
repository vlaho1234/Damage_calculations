using System;
using NUnit.Framework;

namespace Player_damage_calculation.Test
{
    [TestFixture]
    public class LimbshotTest
    {
        Limbshot limbshotDamage = new Limbshot();

        [Test, TestCaseSource("DamageTable")]
        public void Incoming_damage(double h, double i)
        {

            Assert.AreEqual(i, limbshotDamage.damage(h), 1);
        }



        static object[] DamageTable =
        {
            new object[] { 1, 1 },
            new object[] { 34, 17 },
            new object[] { 15, 8 },
            new object[] { 11.1, 6 }
        };
    }
}