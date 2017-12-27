using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_KPO5
{
    public abstract class Component
    {
        protected string name;
        protected double size;

        public Component(string name, double size)
        {
            this.name = name;
            this.size = size;
        }

        public virtual void Add(Component component) { }

        public virtual void Remove(Component component) { }

        public virtual void Print()
        {
            Console.WriteLine("Файл: " + name + " (Размер {0} мб)", size);
        }

        public virtual double SumSize()
        {
            return size;
        }
    }
}
