using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        static void Main(string[] args)
        {
            Triangle a = new Triangle(
                InteractiveInput.InputFloat("幅："),
                InteractiveInput.InputFloat("高さ："));
            Console.WriteLine($"面積は{a.GetSurface()}");
        }
    }
}
