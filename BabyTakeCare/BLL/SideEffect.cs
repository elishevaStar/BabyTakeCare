using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class SideEffect
    {
        //properties
        private DataRow dr;
        private int sideEffectKode;
        private string sideEffectDis;
        private string sideEffectKind;

        //constructor
        public SideEffect() { }

        public SideEffect(DataRow dr)
        {
            this.Dr = dr;
            sideEffectKode = Convert.ToInt32(dr["numberSE"]);
            sideEffectDis = dr["discrabitionSE"].ToString();
            sideEffectKind = dr["kindSE"].ToString();
        }

        public void FillDataRow()
        {
            Dr["numberSE"] = sideEffectKode;
            Dr["discrabitionSE"] = sideEffectDis;
            Dr["kindSE"] = sideEffectKind;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int SideEffectKode { get => sideEffectKode; set => sideEffectKode = value; }
        public string SideEffectDis { get => sideEffectDis; set => sideEffectDis = value; }
        public string SideEffectKind { get => sideEffectKind; set => sideEffectKind = value; }
    }
}
