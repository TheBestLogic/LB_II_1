using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


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
                PainInLungs = Sym.PainInLungs;
            }

            public void Clear()
            {
                Rheum = false;
                Cough = false;
                ASoreThroatPain = false;
                FeverTemperature = false;
                JointPain = false;
                SoreThroat = false;
                Sputum = false;
                RattlingInLungs = false;
                NotSay = false;
                PainInLungs = false;
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
                PainInLungs = Sym.PainInLungs;
            }

            public void Clear()
            {
                Rheum = 0;
                Cough = 0;
                ASoreThroatPain = 0;
                FeverTemperature = 0;
                JointPain = 0;
                SoreThroat = 0;
                Sputum = 0;
                RattlingInLungs = 0;
                NotSay = 0;
                PainInLungs = 0;
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

        public static int CheckDisease(SYMPTOME Sym)
        {
            ////
            SYMPTOME_COST SymC = new SYMPTOME_COST();
            SymC.Clear();
            ////
            int MayBeItResult = 0;
            int[] mass = { Pneumonia(Sym, SymC), Angina(Sym, SymC), Flu(Sym, SymC), Pharyngitis(Sym, SymC) , Bronchitis(Sym, SymC)}; 
            //

            //
            return MayBeItResult;
        }
        
       private static int Pneumonia(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            if (Sym.RattlingInLungs)
            {
                Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
                Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
                Summ = (Sym.PainInLungs) ? (Summ + SymC.PainInLungs) : (Summ);
                Summ = (Sym.RattlingInLungs) ? (Summ + SymC.RattlingInLungs) : (Summ);
            }
            return Summ;
        }

        private static int Angina(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            if (Sym.FeverTemperature && Sym.SoreThroat)
            {
                Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
                Summ = (Sym.ASoreThroatPain) ? (Summ + SymC.ASoreThroatPain) : (Summ);
                Summ = (Sym.SoreThroat) ? (Summ + SymC.SoreThroat) : (Summ);
                Summ = (Sym.JointPain) ? (Summ + SymC.JointPain) : (Summ);
            }
            return Summ;
        }


        private static int Flu(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            if (Sym.FeverTemperature)
            {
                Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
                Summ = (Sym.Rheum) ? (Summ + SymC.Rheum) : (Summ);
                Summ = (Sym.ASoreThroatPain) ? (Summ + SymC.ASoreThroatPain) : (Summ);
                Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
            }
            return Summ;
        }

        private static int Pharyngitis(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            if (Sym.SoreThroat)
            {
                Summ = (Sym.NotSay) ? (Summ + SymC.NotSay) : (Summ);
                Summ = (Sym.ASoreThroatPain) ? (Summ + SymC.ASoreThroatPain) : (Summ);
                Summ = (Sym.SoreThroat) ? (Summ + SymC.SoreThroat) : (Summ);
                Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
                Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
            }
            return Summ;
        }

        private static int Bronchitis(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            if (Sym.RattlingInLungs)
            {
                Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
                Summ = (Sym.PainInLungs) ? (Summ + SymC.PainInLungs) : (Summ);
                Summ = (Sym.RattlingInLungs) ? (Summ + SymC.RattlingInLungs) : (Summ);
                Summ = (Sym.Sputum) ? (Summ + SymC.Sputum) : (Summ);
            }
            return Summ;
        }




    }
}
