using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class City
    {
        //properties
        private DataRow dr;
        private int cityKode;
        private string cityName;

        //constructor
        public City() { }

        public City(DataRow dr)
        {
            this.Dr = dr;
            cityKode = Convert.ToInt32(dr["cityKode"]);
            cityName = dr["cityName"].ToString();
        }

        public void FillDataRow ()
        {
            Dr["cityKode"] = cityKode;
            Dr["cityName"] = cityName;

        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int CityKode { get => cityKode; set => cityKode = value; }
        public string CityName { get => cityName; set => cityName = value; }

        public override string ToString()
        {
            return cityName;
        }
    }
}
