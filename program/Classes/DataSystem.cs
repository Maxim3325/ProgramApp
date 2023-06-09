using Avalonia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace program.Classes
{
    internal static class DataSystem
    {
        public static List<Sportsman> Sportsmen { get; } = new List<Sportsman>();
        public static List<Sportsman> Treners { get; } = new List<Sportsman> { };
        public static List<Description> Description { get; } = new List<Description>()
        {
            new Description() { Name="Мужской" },
            new Description() { Name="Женский" }
        };
    }
}
