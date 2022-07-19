using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task3
{
    internal class Music : Item
    {
        protected string singer;
        protected double length;

        public Music(string name, uint size, string code, string singer, double length) : base(name, size, code)
        {
            category = "music";
            this.singer = singer;
            this.length = length;
        }

        public override void RetrieveInformation()
        {
            base.RetrieveInformation();
            Console.WriteLine($"- singer: {singer}");
            Console.WriteLine($"- length: {length} sec");
        }
    }
}
