using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace HW._11.DatabaseOfMotorcycles.Repository
{
    internal class Motorcycle: BaseEntity
    {
        protected override Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }
        
        public Motorcycle(string name, string model)
        {
            Id = Guid.NewGuid();
            Name = name;
            Model = model;
            Year = int.Parse(DateTime.Now.ToString("yyyy"));
            Odometer = default;
            Log.Information($"Motorcycle created: {ToString()}");
        }

  
        public override string ToString()
        {
            return ($"Name: {Name}, Model: {Model}, Year: {Year}, Odometer: {Odometer}km, Id: {Id}");
        }

        public override Guid GetId()
        {
            return Id;
        }

    }
}