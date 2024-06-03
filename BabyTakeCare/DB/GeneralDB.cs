using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BabyTakeCare.DAL;

namespace BabyTakeCare.BLL
{
    public abstract class  GeneralDB
    {
        //property
        protected DataTable table;

        //constructor
        public GeneralDB(string tableName)
        {
            Dal.GetInstance().AddTable(tableName);
            table = Dal.GetInstance().GetTable(tableName);
        }

        //return the tables' size
        public int Size()
        {
            return table.Rows.Count;
        }

        //if the table is empty
        public bool IsEmpty()
        {
            return table.Rows.Count == 0;
        }

        //save the table
        public virtual void Save()
        {
            Dal.GetInstance().Update(table.TableName);
        }

        //add new row to the table(ההצבעה תעבור אליה)
        public void Add(DataRow dr)
        {
            table.Rows.Add(dr);
            this.Save();
        }

        //return the whole table
        public DataTable GetTable()
        {
            return this.table;
        }

        //update the whole table with all the changes in DataSet
        public void UpDate()
        {
            Dal.GetInstance().Update(table.TableName);
        }
    }
}
