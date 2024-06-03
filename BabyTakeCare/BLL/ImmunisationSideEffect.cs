using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BabyTakeCare.BLL
{
    public class ImmunisationSideEffect
    {
        //properties
        private DataRow dr;
        private int immunisationKode;
        private int sideEffectKode;
        private int sideEffectFrequency;
        private bool status;

        //constructor
        public ImmunisationSideEffect() { }

        public ImmunisationSideEffect(DataRow dr)
        {
            this.Dr = dr;
            immunisationKode = Convert.ToInt32(dr["numberIm"]);
            sideEffectKode = Convert.ToInt32(dr["numberSE"]);
            sideEffectFrequency =Convert.ToInt32( dr["frequencySE"]);
            status = Convert.ToBoolean(dr["status"]);
        }

        public void FillDataRow()
        {
            Dr["numberIm"] = immunisationKode;
            Dr["numberSE"] = sideEffectKode;
            Dr["frequencySE"] = sideEffectFrequency;
            Dr["status"] = status;
        }

        //Access methods
        public DataRow Dr { get => dr; set => dr = value; }
        public int ImmunisationKode { get => immunisationKode; set => immunisationKode = value; }
        public int SideEffectKode { get => sideEffectKode; set => sideEffectKode = value; }
        public int SideEffectFrequency { get => sideEffectFrequency; set => sideEffectFrequency = value; }
        public bool Status { get => status; set => status = value; }

        //Return immunistation as a noun
        public Immunisation ImmunistationOfImmunistationSideEffect()
        {
            ImmunisationDB tblImmunistation = new ImmunisationDB();
            return tblImmunistation.Find(immunisationKode);
        }

        //Return sideEffect as a noun
        public SideEffect SideEffectOfImmunistationSideEffect()
        {
            SideEffectDB tblSideEffect = new SideEffectDB();
            return tblSideEffect.Find(sideEffectKode);
        }

        //Return sideEffect as a noun
        public Freqenty FreqentyOfImmunistationSideEffect()
        {
            FreqentyDB tblFreqenty = new FreqentyDB();
            return tblFreqenty.Find(sideEffectFrequency);
        }


    }
}
