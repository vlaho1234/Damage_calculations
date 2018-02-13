using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Player_damage_calculation
{
    [Serializable]
    public class MyLoggerClass : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("This code got executed before the method was invoked");
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Console.WriteLine("This code got executed after the method was invoked");
        }
    }
}
