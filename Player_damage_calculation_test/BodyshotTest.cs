using System;
using NUnit.Framework;

namespace Player_damage_calculation.Test
{
    [TestFixture]
    public class BodyshotTest
    {
        Bodyshot bodyshotDamage = new Bodyshot();

        [Test, TestCaseSource("DamageTable")]
        public void Incoming_damage(double h, double i)
        {

            Assert.AreEqual(i, bodyshotDamage.damage(h), 1);
        }



        static object[] DamageTable =
        {
            new object[] { 1, 1},
            new object[] { 34, 34 },
            new object[] { 15, 15 },
            new object[] { 11.1, 12}
        };
    }
}