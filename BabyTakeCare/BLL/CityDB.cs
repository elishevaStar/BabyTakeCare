using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class CityDB:GeneralDB
    {
        //property
        List<City> lstCity = new List<City>();

        //constructor
        public CityDB() : base("tbl_City") { }

        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
               lstCity.Add(new City(dr));
            }
        }

        public List<City> GetLstCities()
        {
            lstCity.Clear();
            DataTableToList();
            return lstCity;
        }

        //Search for city by cityKode
        public City Find(int code)
        {
            return this.GetLstCities().Find(x => x.CityKode== code);
        }

        //Delete row in the table by the key
        public void DeleteRow(int code)
        {
            City C = this.Find(code);
            if (C != null)
            {
                C.Dr.Delete();
                this.UpDate();
            }
        }

        //Update row in the table by the noun
        public void UpDateRow(City c)
        {
            c.FillDataRow();
            this.UpDate();
        }

        //Add new City
        public void AddNew(City c)
        {
            c.Dr = table.NewRow();
            c.FillDataRow();
            this.Add(c.Dr);
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetLstCities().Max(x => x.CityKode) + 1;
        }
    }
}
