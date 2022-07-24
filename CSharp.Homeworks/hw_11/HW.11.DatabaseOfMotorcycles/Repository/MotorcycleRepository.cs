using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace HW._11.DatabaseOfMotorcycles.Repository
{
    internal class MotorcycleRepository : IMotorcycleRepository<Motorcycle>
    {
      

        private static List<Motorcycle> motorcycles = new();

        public void CreateMotorcycle(params Motorcycle[] motorcycle)
        {          
            Log.Information("Started the process of creating a motorcycle");

            foreach (var moto in motorcycle)
            {
                if(moto is not null)
                {
                    motorcycles.Add(moto);
                    Log.Information($"Add motocycle: {moto}");
                }
                else
                {                 
                    Log.Information("[Error]: Object reference is null");
                    throw new NullReferenceException();
                }              
            }           
        }

        public void DeleteMotorcycle(Motorcycle motorcycle)
        {
            Log.Information("Started the process of deleting the motorcycle");

            Motorcycle foundMotot = null;

            foreach (Motorcycle moto in motorcycles)
            {
                if (moto.GetId().Equals(motorcycle.GetId()))
                {
                    Log.Information("Motorcycle found");
                    foundMotot = moto;
                    break;
                }
            }

            try
            {
                if(foundMotot is null)
                {
                    throw new Exception("MotorcycleNotFoundException");
                }
                else
                {
                    Log.Information($"Motorcycle remove: {foundMotot}");
                    motorcycles.Remove(foundMotot);                    
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "[Error]: motorcycle not found");
            }           
        }

        public Motorcycle? GetMotorcycleByID(Guid id)
        {
            Log.Information("Started the process of searching motorcycle by id");

            Motorcycle foundMotot = null;

            foreach (Motorcycle moto in motorcycles)
            {
                if (moto.GetId().Equals(id))
                {
                    Log.Information($"Motorcycle found: {moto}");
                    foundMotot = moto;
                    break;
                }
            }

            try
            {
                if (foundMotot is null)
                {
                    throw new Exception("MotorcycleNotFoundException");
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "[Error]: Motorcycle not found");
            }

            return foundMotot;
        }
         
        public List<Motorcycle> GetMotorcycles()
        {
            Log.Information("Get all motorcycles");
            return motorcycles;
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            Log.Information("Started the process of updating motorcycle");

            bool foundMoto = false;

            if (motorcycle is not null)
            {               
                foreach (Motorcycle moto in motorcycles)
                {
                    if (moto.GetId().Equals(motorcycle.GetId()))
                    {
                        foundMoto = true;   
                        moto.Name = motorcycle.Name;
                        moto.Model = motorcycle.Model;
                        moto.Odometer = motorcycle.Odometer;
                        moto.Year = motorcycle.Year;
                        Log.Information($"Motorcycle changed: {moto}");
                        break;                     
                    }
                }

                try
                {
                    if (!foundMoto)
                    {
                        throw new Exception("MotorcycleNotFoundException");
                    }   
                }
                catch(Exception ex)
                {
                    Log.Error(ex, "[Error]: Motorcycle not found");
                }
            }
            else
            {
                Log.Information("Object reference is null");
                throw new NullReferenceException();
            }
        }
    }
}
