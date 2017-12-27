using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_KPO5
{
    public class Directory : Component
    {
        public List<Component> components = new List<Component>();

        public Directory(string name, double size)
            : base(name, size)
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }

        public override double SumSize()
        {
            size = 0;
            for (int i = 0; i < components.Count; i++)
            {
                size += components[i].SumSize();
            }
            return size;
        }

        public override void Print()
        {
            Console.WriteLine("Каталог: " + name + " (Размер {0} мб)", SumSize());
            Console.WriteLine("Подкаталоги:");
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print();
            }
        }
    }
}
