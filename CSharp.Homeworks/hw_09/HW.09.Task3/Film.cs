using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Task3
{
    internal class Film : Item
    {
        protected string? director;
        protected string? mainActor;
        protected string? mainActress;

        public Film(string name, uint size, string code, string director, string mainActor, string mainActress) : base(name, size, code)
        {
            category = "films";
            this.director = director;
            this.mainActor = mainActor;
            this.mainActress = mainActress;
        }

        public override void RetrieveInformation()
        {
            base.RetrieveInformation();
            Console.WriteLine($"- director: {director}");
            Console.WriteLine($"- main actor: {mainActor}");
            Console.WriteLine($"- main actress: {mainActress}");
        }
    }
}
