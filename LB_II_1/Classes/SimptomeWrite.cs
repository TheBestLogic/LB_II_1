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
            public short ID;
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
            public short ID;
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

            public void New()
            {
                ID = 0;
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
                Summ = (Sym.SoreThroat) ? (Summ + SymC.SoreThroat) : (Summ);
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

        private static void ChangeCost(int DeseareIndex, SYMPTOME Sym, ref SYMPTOME_COST SymC)
        {
            switch (DeseareIndex)
            {
                case 1:
                    AnaliseCount(Sym.Cough, ref SymC.Cough);
                    AnaliseCount(Sym.FeverTemperature, ref SymC.FeverTemperature);
                    AnaliseCount(Sym.PainInLungs, ref SymC.PainInLungs);
                    AnaliseCount(Sym.RattlingInLungs, ref SymC.RattlingInLungs);
                    break;
                case 2:
                    AnaliseCount(Sym.JointPain, ref SymC.JointPain);
                    AnaliseCount(Sym.FeverTemperature, ref SymC.FeverTemperature);
                    AnaliseCount(Sym.SoreThroat, ref SymC.SoreThroat);
                    AnaliseCount(Sym.ASoreThroatPain, ref SymC.ASoreThroatPain);
                    break;
                case 3:
                    AnaliseCount(Sym.Cough, ref SymC.Cough);
                    AnaliseCount(Sym.FeverTemperature, ref SymC.FeverTemperature);
                    AnaliseCount(Sym.SoreThroat, ref SymC.SoreThroat);
                    AnaliseCount(Sym.ASoreThroatPain, ref SymC.ASoreThroatPain);
                    AnaliseCount(Sym.Rheum, ref SymC.Rheum);
                    break;
                case 4:
                    AnaliseCount(Sym.Cough, ref SymC.Cough);
                    AnaliseCount(Sym.FeverTemperature, ref SymC.FeverTemperature);
                    AnaliseCount(Sym.SoreThroat, ref SymC.SoreThroat);
                    AnaliseCount(Sym.ASoreThroatPain, ref SymC.ASoreThroatPain);
                    AnaliseCount(Sym.NotSay, ref SymC.NotSay);
                    break;
                case 5:
                    AnaliseCount(Sym.Cough, ref SymC.Cough);
                    AnaliseCount(Sym.Sputum, ref SymC.Sputum);
                    AnaliseCount(Sym.PainInLungs, ref SymC.PainInLungs);
                    AnaliseCount(Sym.RattlingInLungs, ref SymC.RattlingInLungs);
                    break;
                default:
                    break;
            }
        }

        private static void AnaliseCount(bool flag, ref short Count)
        {
            if (flag)
            {
                if ((Count+1)>26)
                {
                    ++Count;
                }
            }
            else
            {
                if ((Count - 1) > 0)
                {
                    --Count;
                }
            }
        }
        private static void GetSum(ref int[] SummMass, ref SYMPTOME Sym, ref SYMPTOME_COST[] SymC)
        {
            int i = 0;
            SummMass[0] = Pneumonia(Sym, SymC[0]);
            SummMass[1] = Angina(Sym, SymC[1]);
            SummMass[2] = Flu(Sym, SymC[2]);
            SummMass[3] = Pharyngitis(Sym, SymC[3]);
            SummMass[4] = Bronchitis(Sym, SymC[4]);

            //ChangeCost(
        }


    }
}
