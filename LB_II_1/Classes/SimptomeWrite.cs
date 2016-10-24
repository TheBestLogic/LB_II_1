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


        private static int Pneumonia(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            //if (Sym.RattlingInLungs)
            //{
                Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
                Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
                Summ = (Sym.PainInLungs) ? (Summ + SymC.PainInLungs) : (Summ);
                Summ = (Sym.RattlingInLungs) ? (Summ + SymC.RattlingInLungs) : (Summ);
                Summ = (Sym.Sputum) ? (Summ + SymC.Sputum) : (Summ);
            //}
            return Summ;
        }

        private static int Angina(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            //if (Sym.FeverTemperature && Sym.SoreThroat)
            //{
                Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
                Summ = (Sym.ASoreThroatPain) ? (Summ + SymC.ASoreThroatPain) : (Summ);
                Summ = (Sym.SoreThroat) ? (Summ + SymC.SoreThroat) : (Summ);
                Summ = (Sym.JointPain) ? (Summ + SymC.JointPain) : (Summ);
            //}
            return Summ;
        }

        private static int Flu(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            //if (Sym.FeverTemperature)
            //{
                Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
                Summ = (Sym.Rheum) ? (Summ + SymC.Rheum) : (Summ);
                Summ = (Sym.ASoreThroatPain) ? (Summ + SymC.ASoreThroatPain) : (Summ);
                Summ = (Sym.SoreThroat) ? (Summ + SymC.SoreThroat) : (Summ);
                Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
            //}
            return Summ;
        }

        private static int Pharyngitis(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            //if (Sym.SoreThroat)
            //{
                Summ = (Sym.NotSay) ? (Summ + SymC.NotSay) : (Summ);
                Summ = (Sym.ASoreThroatPain) ? (Summ + SymC.ASoreThroatPain) : (Summ);
                Summ = (Sym.SoreThroat) ? (Summ + SymC.SoreThroat) : (Summ);
                Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
                Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
            //}
            return Summ;
        }

        private static int Bronchitis(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
            //if (Sym.RattlingInLungs)
            //{
                Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
                Summ = (Sym.PainInLungs) ? (Summ + SymC.PainInLungs) : (Summ);
                Summ = (Sym.RattlingInLungs) ? (Summ + SymC.RattlingInLungs) : (Summ);
                Summ = (Sym.Sputum) ? (Summ + SymC.Sputum) : (Summ);
            //}
            return Summ;
        }

        private static SYMPTOME_COST ChangeCost(int DeseareIndex, SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            switch (DeseareIndex)
            {
                case 1:
                    SymC.Cough =AnaliseCount(Sym.Cough, SymC.Cough);
                    SymC.FeverTemperature = AnaliseCount(Sym.FeverTemperature, SymC.FeverTemperature);
                    SymC.PainInLungs = AnaliseCount(Sym.PainInLungs, SymC.PainInLungs);
                    SymC.RattlingInLungs = AnaliseCount(Sym.RattlingInLungs, SymC.RattlingInLungs);
                    SymC.Sputum = AnaliseCount(Sym.Sputum, SymC.Sputum);
                    break;
                case 2:
                    SymC.JointPain = AnaliseCount(Sym.JointPain, SymC.JointPain);
                    SymC.FeverTemperature = AnaliseCount(Sym.FeverTemperature, SymC.FeverTemperature);
                    SymC.SoreThroat = AnaliseCount(Sym.SoreThroat, SymC.SoreThroat);
                    SymC.ASoreThroatPain = AnaliseCount(Sym.ASoreThroatPain, SymC.ASoreThroatPain);
                    break;
                case 3:
                    SymC.Cough = AnaliseCount(Sym.Cough, SymC.Cough);
                    SymC.FeverTemperature = AnaliseCount(Sym.FeverTemperature, SymC.FeverTemperature);
                    SymC.SoreThroat = AnaliseCount(Sym.SoreThroat, SymC.SoreThroat);
                    SymC.ASoreThroatPain = AnaliseCount(Sym.ASoreThroatPain, SymC.ASoreThroatPain);
                    SymC.Rheum = AnaliseCount(Sym.Rheum, SymC.Rheum);
                    break;
                case 4:
                    SymC.Cough = AnaliseCount(Sym.Cough, SymC.Cough);
                    SymC.FeverTemperature = AnaliseCount(Sym.FeverTemperature, SymC.FeverTemperature);
                    SymC.SoreThroat = AnaliseCount(Sym.SoreThroat, SymC.SoreThroat);
                    SymC.ASoreThroatPain = AnaliseCount(Sym.ASoreThroatPain, SymC.ASoreThroatPain);
                    SymC.NotSay = AnaliseCount(Sym.NotSay, SymC.NotSay);
                    break;
                case 5:
                    SymC.Cough = AnaliseCount(Sym.Cough, SymC.Cough);
                    SymC.Sputum = AnaliseCount(Sym.Sputum, SymC.Sputum);
                    SymC.PainInLungs = AnaliseCount(Sym.PainInLungs, SymC.PainInLungs);
                    SymC.RattlingInLungs = AnaliseCount(Sym.RattlingInLungs, SymC.RattlingInLungs);
                    break;
                default:
                    break;
            }
            return SymC;
        }

        private static short AnaliseCount(bool flag, short Count)
        {
            if (flag)
            {
                if ((Count+1)<26)
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
            return Count;
        }
        public static int GetSum(ref SYMPTOME Sym, ref SYMPTOME_COST[] SymC)
        {
            int i = 0, Flag =1;
            int[] SummMass = new int[5];
            SummMass[0] = Pneumonia(Sym, SymC[0]);
            SummMass[1] = Angina(Sym, SymC[1]);
            SummMass[2] = Flu(Sym, SymC[2]);
            SummMass[3] = Pharyngitis(Sym, SymC[3]);
            SummMass[4] = Bronchitis(Sym, SymC[4]);
            for (i = 0; i < 5; ++i)
            {
                if(SummMass[i]> SummMass[Flag-1])
                {
                    Flag = i+1;
                }
            }
            SymC[Flag - 1] = ChangeCost(SymC[Flag - 1].ID, Sym, SymC[Flag - 1]);
            return Flag; 

        }


    }
}
