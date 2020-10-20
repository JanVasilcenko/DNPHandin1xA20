using DNPHandin1.Models;
using FileData;
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DNPHandin1.Data.Implementation
{
    public class AdultService : IAdultsService
    {
        //private string adultsFile = "adults.json";
        //private List<Adult> adults;
        private FileContext fileContext;

        public AdultService()
        {
            fileContext = new FileContext();
            /*if (!File.Exists(adultsFile))
            {
                //Populate
                WriteAdultsToFile();
            }
            else
            {
                string content = File.ReadAllText(adultsFile);
                adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }*/
        }

        public void AddAdult(Adult adult)
        {
            int max = fileContext.Adults.Max(adult => adult.Id);
            adult.Id = (++max);
            //adults.Add(adult);
            fileContext.Adults.Add(adult);
            fileContext.SaveChanges();
            //WriteAdultsToFile();
        }

        public IList<Adult> GetAdults()
        {
            List<Adult> copy = new List<Adult>(fileContext.Adults);
            return copy;
        }

        public void RemoveAdult(int id)
        {
            Adult toRemove = fileContext.Adults.First(a => a.Id == id);
            //adults.Remove(toRemove);
            fileContext.Adults.Remove(toRemove);
            fileContext.SaveChanges();
            //WriteAdultsToFile();
        }

        /*public void WriteAdultsToFile() 
        {
            string productAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(adultsFile, productAsJson);
        }*/
    }
}
