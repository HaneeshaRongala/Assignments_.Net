using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DAL
{
    public class CountryCollection
    {
        public List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>()
            {
                new Country(){ CountryId=0 , CountryName="Select" },
                new Country(){ CountryId=1 , CountryName="India" },
                new Country(){ CountryId=2 , CountryName="USA" },
                new Country(){ CountryId=3 , CountryName="Australia" },

            };

            return countries;
        }
    }
}
