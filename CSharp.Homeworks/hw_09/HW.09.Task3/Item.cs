using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task3
{
    internal class Item
    {
        protected string? name;
        protected string? category;
        protected uint? size;
        protected string? code;

        public Item(string name, uint size, string code)
        {
            this.name = name;
            this.size = size;
            this.code = code;
        }

        public virtual void RetrieveInformation()
        {
            Console.WriteLine("\nInformation:");
            Console.WriteLine($"- name: {name}");
            Console.WriteLine($"- category: {category}");
            Console.WriteLine($"- size: {size} Mbyte" );
            Console.WriteLine($"- code: {code}");
        }
    }
}