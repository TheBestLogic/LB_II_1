using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_II_1.Classes
{
    class SimptomeWrite
    {

        public struct SYMPTOME  //симптомы
        {
            public bool Rheum;//насморк
            public bool Cough;//кашель
            public bool ASoreThroatPain;//боль в горле
            public bool FeverTemperature;//жар
            public bool JointPain;//Боль в суставах
            public bool SoreThroat;//Воспаление горла
            public bool Sputum;//Макрота
            public bool RattlingInLungs;//Хрип в легких
            public bool PainInLungs;//Боль в легких
            public bool NotSay;//Немота

            public void SetStructFlag(SYMPTOME Sym)
            {
                Rheum = Sym.Rheum;
                Cough = Sym.Cough;
                ASoreThroatPain = Sym.ASoreThroatPain;
                FeverTemperature = Sym.FeverTemperature;
                JointPain = Sym.JointPain;
                SoreThroat = Sym.SoreThroat;
                Sputum = Sym.Sputum;
                RattlingInLungs = Sym.RattlingInLungs;
                NotSay = Sym.NotSay;
            }


        };

        public struct SYMPTOME_COST //стоимость симптома 
        {
            public short Rheum;//насморк
            public short Cough;//кашель
            public short ASoreThroatPain;//боль в горле
            public short FeverTemperature;//жар
            public short JointPain;//Боль в суставах
            public short SoreThroat;//Воспаление горла
            public short Sputum;//Макрота
            public short RattlingInLungs;//Хрип в легких
            public short PainInLungs;//Боль в легких
            public short NotSay;//Немота

            public void SetStructCost(SYMPTOME_COST Sym)
            {
                Rheum = Sym.Rheum;
                Cough = Sym.Cough;
                ASoreThroatPain = Sym.ASoreThroatPain;
                FeverTemperature = Sym.FeverTemperature;
                JointPain = Sym.JointPain;
                SoreThroat = Sym.SoreThroat;
                Sputum = Sym.Sputum;
                RattlingInLungs = Sym.RattlingInLungs;
                NotSay = Sym.NotSay;
            }
        };

        public struct DISEASE
        {
            short DiseaseIndex;//индекс (имени) болезни
                                //1-Воспаление легких
                                //2-ангина
                                //3-Грипп
                                //4-Фарингит
                                //5-Бронхит
            SYMPTOME_COST SymCost;
        };

        public int CheckDisease(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int MayBeItResult = 0;
            //
            Pneumonia(Sym, SymC);
            Angina(Sym, SymC);
            Flu(Sym, SymC);
            Pharyngitis(Sym, SymC);
            Bronchitis(Sym, SymC);
            //
            return MayBeItResult;
        }
        
       public int Pneumonia(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
            Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
            Summ = (Sym.PainInLungs) ? (Summ + SymC.PainInLungs) : (Summ);
            Summ = (Sym.RattlingInLungs) ? (Summ + SymC.RattlingInLungs) : (Summ);
            return Summ;
        }

        public int Angina(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
            Summ = (Sym.ASoreThroatPain) ? (Summ + SymC.ASoreThroatPain) : (Summ);
            Summ = (Sym.SoreThroat) ? (Summ + SymC.SoreThroat) : (Summ);
            Summ = (Sym.JointPain) ? (Summ + SymC.JointPain) : (Summ);
            return Summ;
        }
        

        public int Flu(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
            Summ = (Sym.Rheum) ? (Summ + SymC.Rheum) : (Summ);
            Summ = (Sym.ASoreThroatPain) ? (Summ + SymC.ASoreThroatPain) : (Summ);
            Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
            return Summ;
        }

        public int Pharyngitis(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            Summ = (Sym.NotSay) ? (Summ + SymC.NotSay) : (Summ);
            Summ = (Sym.ASoreThroatPain) ? (Summ + SymC.ASoreThroatPain) : (Summ);
            Summ = (Sym.SoreThroat) ? (Summ + SymC.SoreThroat) : (Summ);
            Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
            Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
            return Summ;
        }

        public int Bronchitis(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
            Summ = (Sym.PainInLungs) ? (Summ + SymC.PainInLungs) : (Summ);
            Summ = (Sym.RattlingInLungs) ? (Summ + SymC.RattlingInLungs) : (Summ);
            Summ = (Sym.Sputum) ? (Summ + SymC.Sputum) : (Summ);
            return Summ;
        }




    }
}
