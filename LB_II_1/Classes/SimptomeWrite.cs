using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static LB_II_1.Classes.ResourcesConfigEditClass;
using static LB_II_1.Classes.DatabaseInteraction;


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

            public SYMPTOME SetStructFlag(SYMPTOME Sym)
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
                return this;
            }

            public SYMPTOME Clear()
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
                return this;
            }

            public SYMPTOME New()
            {
                ID = 0;
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
                return this;
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


            public SYMPTOME_COST SetStructCost(SYMPTOME_COST Sym)
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
                return this;
            }

            public SYMPTOME_COST Clear()
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
                return this;
            }

            public SYMPTOME_COST New()
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
                return this;
            }

            public int AverageValue()
            {
                float Avr = 0;
                int ActiveElements = 0;
                ActiveElements += (Rheum==0) ? (1) : (0);
                ActiveElements += (Cough == 0) ? (1) : (0);
                ActiveElements += (ASoreThroatPain == 0) ? (1) : (0);
                ActiveElements += (FeverTemperature == 0) ? (1) : (0);
                ActiveElements += (JointPain == 0) ? (1) : (0);
                ActiveElements += (SoreThroat == 0) ? (1) : (0);
                ActiveElements += (Sputum == 0) ? (1) : (0);
                ActiveElements += (RattlingInLungs == 0) ? (1) : (0);
                ActiveElements += (NotSay == 0) ? (1) : (0);
                ActiveElements += (PainInLungs == 0) ? (1) : (0);
                if (ActiveElements != 0)
                {
                    Avr = (Rheum + Cough + ASoreThroatPain + FeverTemperature + JointPain + SoreThroat + Sputum + RattlingInLungs + NotSay + PainInLungs) / ActiveElements;
                }
                    
                return (int)Avr;
            }

            public SYMPTOME_COST DefVPne()
            {
                Rheum = 0;
                ASoreThroatPain = 0;
                JointPain = 0;
                SoreThroat = 0;
                NotSay = 0;
                ID = 1;
                Cough = 3;
                Sputum = 2;
                FeverTemperature = 3;
                PainInLungs = 3;
                RattlingInLungs = 3;
                return this;
            }

            public SYMPTOME_COST DefVAng()
            {
                Rheum = 0;
                Cough = 0;
                Sputum = 0;
                RattlingInLungs = 0;
                NotSay = 0;
                PainInLungs = 0;
                ID = 2;
                JointPain = 2;
                FeverTemperature = 3;
                SoreThroat = 3;
                ASoreThroatPain = 3;
                return this;
            }

            public SYMPTOME_COST DefVFlu()
            {
                JointPain = 0;
                Sputum = 0;
                RattlingInLungs = 0;
                NotSay = 0;
                PainInLungs = 0;
                ID = 3;
                Cough = 2;
                FeverTemperature = 3;
                SoreThroat = 3;
                ASoreThroatPain = 3;
                Rheum = 2;
                return this;
            }

            public SYMPTOME_COST DefVPha()
            {
                Rheum = 0;
                JointPain = 0;
                Sputum = 0;
                RattlingInLungs = 0;
                PainInLungs = 0;
                ID = 4;
                Cough = 2;
                FeverTemperature = 2;
                SoreThroat = 3;
                ASoreThroatPain = 3;
                NotSay = 4;
                return this;
            }

            public SYMPTOME_COST DefVBro()
            {
                Rheum = 0;
                ASoreThroatPain = 0;
                FeverTemperature = 0;
                JointPain = 0;
                SoreThroat = 0;
                NotSay = 0;
                ID = 5;
                Cough = 2;
                Sputum = 2;
                PainInLungs = 3;
                RattlingInLungs = 3;
                return this;
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
            Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
            Summ = (Sym.PainInLungs) ? (Summ + SymC.PainInLungs) : (Summ);
            Summ = (Sym.RattlingInLungs) ? (Summ + SymC.RattlingInLungs) : (Summ);
            Summ = (Sym.Sputum) ? (Summ + SymC.Sputum) : (Summ);
            Summ = (Sym.NotSay) ? (Summ + SymC.NotSay) : (Summ);
            Summ = (Sym.ASoreThroatPain) ? (Summ + SymC.ASoreThroatPain) : (Summ);
            Summ = (Sym.SoreThroat) ? (Summ + SymC.SoreThroat) : (Summ);
            Summ = (Sym.FeverTemperature) ? (Summ + SymC.FeverTemperature) : (Summ);
            Summ = (Sym.Rheum) ? (Summ + SymC.Rheum) : (Summ);
            Summ = (Sym.JointPain) ? (Summ + SymC.JointPain) : (Summ);
            return Summ;
        }

        private static int Deseare(SYMPTOME Sym, SYMPTOME_COST SymC)
        {
            int Summ = 0;
                Summ = (Sym.Cough) ? (Summ + SymC.Cough) : (Summ);
                Summ = (Sym.PainInLungs) ? (Summ + SymC.PainInLungs) : (Summ);
                Summ = (Sym.RattlingInLungs) ? (Summ + SymC.RattlingInLungs) : (Summ);
                Summ = (Sym.Sputum) ? (Summ + SymC.Sputum) : (Summ);
            
            return Summ;
        }
    private static SYMPTOME_COST ChangeCost( SYMPTOME Sym, SYMPTOME_COST SymC,int DeseareIndex= 0)
        {
            switch (DeseareIndex)
            {
                case 1:
                    SymC.Cough =AnaliseCount(Sym.Cough, SymC.Cough, SymC.AverageValue());
                    SymC.FeverTemperature = AnaliseCount(Sym.FeverTemperature, SymC.FeverTemperature, SymC.AverageValue());
                    SymC.PainInLungs = AnaliseCount(Sym.PainInLungs, SymC.PainInLungs, SymC.AverageValue());
                    SymC.RattlingInLungs = AnaliseCount(Sym.RattlingInLungs, SymC.RattlingInLungs, SymC.AverageValue());
                    SymC.Sputum = AnaliseCount(Sym.Sputum, SymC.Sputum, SymC.AverageValue());
                    SymC.SoreThroat = AnaliseCount(Sym.SoreThroat, SymC.SoreThroat, SymC.AverageValue(), false);
                    SymC.ASoreThroatPain = AnaliseCount(Sym.ASoreThroatPain, SymC.ASoreThroatPain, SymC.AverageValue(), false);
                    SymC.NotSay = AnaliseCount(Sym.NotSay, SymC.NotSay, SymC.AverageValue(), false);
                    SymC.Rheum = AnaliseCount(Sym.Rheum, SymC.Rheum, SymC.AverageValue(), false);
                    SymC.JointPain = AnaliseCount(Sym.JointPain, SymC.JointPain, SymC.AverageValue(), false);
                    break;
                case 2:
                    SymC.JointPain = AnaliseCount(Sym.JointPain, SymC.JointPain, SymC.AverageValue());
                    SymC.FeverTemperature = AnaliseCount(Sym.FeverTemperature, SymC.FeverTemperature, SymC.AverageValue());
                    SymC.SoreThroat = AnaliseCount(Sym.SoreThroat, SymC.SoreThroat, SymC.AverageValue());
                    SymC.ASoreThroatPain = AnaliseCount(Sym.ASoreThroatPain, SymC.ASoreThroatPain, SymC.AverageValue());
                    SymC.Cough = AnaliseCount(Sym.Cough, SymC.Cough, SymC.AverageValue(), false);
                    SymC.Sputum = AnaliseCount(Sym.Sputum, SymC.Sputum, SymC.AverageValue(), false);
                    SymC.PainInLungs = AnaliseCount(Sym.PainInLungs, SymC.PainInLungs, SymC.AverageValue(), false);
                    SymC.RattlingInLungs = AnaliseCount(Sym.RattlingInLungs, SymC.RattlingInLungs, SymC.AverageValue(), false);
                    SymC.NotSay = AnaliseCount(Sym.NotSay, SymC.NotSay, SymC.AverageValue(), false);
                    SymC.Rheum = AnaliseCount(Sym.Rheum, SymC.Rheum, SymC.AverageValue(), false);
                    break;
                case 3:
                    SymC.Cough = AnaliseCount(Sym.Cough, SymC.Cough, SymC.AverageValue());
                    SymC.FeverTemperature = AnaliseCount(Sym.FeverTemperature, SymC.FeverTemperature, SymC.AverageValue());
                    SymC.SoreThroat = AnaliseCount(Sym.SoreThroat, SymC.SoreThroat, SymC.AverageValue());
                    SymC.ASoreThroatPain = AnaliseCount(Sym.ASoreThroatPain, SymC.ASoreThroatPain, SymC.AverageValue());
                    SymC.Rheum = AnaliseCount(Sym.Rheum, SymC.Rheum, SymC.AverageValue());
                    SymC.Sputum = AnaliseCount(Sym.Sputum, SymC.Sputum, SymC.AverageValue(), false);
                    SymC.PainInLungs = AnaliseCount(Sym.PainInLungs, SymC.PainInLungs, SymC.AverageValue(), false);
                    SymC.RattlingInLungs = AnaliseCount(Sym.RattlingInLungs, SymC.RattlingInLungs, SymC.AverageValue(), false);
                    SymC.NotSay = AnaliseCount(Sym.NotSay, SymC.NotSay, SymC.AverageValue(), false);
                    SymC.JointPain = AnaliseCount(Sym.JointPain, SymC.JointPain, SymC.AverageValue(), false);
                    break;
                case 4:
                    SymC.Cough = AnaliseCount(Sym.Cough, SymC.Cough, SymC.AverageValue());
                    SymC.FeverTemperature = AnaliseCount(Sym.FeverTemperature, SymC.FeverTemperature, SymC.AverageValue());
                    SymC.SoreThroat = AnaliseCount(Sym.SoreThroat, SymC.SoreThroat, SymC.AverageValue());
                    SymC.ASoreThroatPain = AnaliseCount(Sym.ASoreThroatPain, SymC.ASoreThroatPain, SymC.AverageValue());
                    SymC.NotSay = AnaliseCount(Sym.NotSay, SymC.NotSay, SymC.AverageValue());
                    SymC.Sputum = AnaliseCount(Sym.Sputum, SymC.Sputum, SymC.AverageValue(), false);
                    SymC.PainInLungs = AnaliseCount(Sym.PainInLungs, SymC.PainInLungs, SymC.AverageValue(), false);
                    SymC.RattlingInLungs = AnaliseCount(Sym.RattlingInLungs, SymC.RattlingInLungs, SymC.AverageValue(), false);
                    SymC.Rheum = AnaliseCount(Sym.Rheum, SymC.Rheum, SymC.AverageValue(), false);
                    SymC.JointPain = AnaliseCount(Sym.JointPain, SymC.JointPain, SymC.AverageValue(), false);
                    break;
                case 5:
                    SymC.Cough = AnaliseCount(Sym.Cough, SymC.Cough, SymC.AverageValue());
                    SymC.Sputum = AnaliseCount(Sym.Sputum, SymC.Sputum, SymC.AverageValue());
                    SymC.PainInLungs = AnaliseCount(Sym.PainInLungs, SymC.PainInLungs, SymC.AverageValue());
                    SymC.RattlingInLungs = AnaliseCount(Sym.RattlingInLungs, SymC.RattlingInLungs, SymC.AverageValue());
                    SymC.FeverTemperature = AnaliseCount(Sym.FeverTemperature, SymC.FeverTemperature, SymC.AverageValue(),false);
                    SymC.SoreThroat = AnaliseCount(Sym.SoreThroat, SymC.SoreThroat, SymC.AverageValue(), false);
                    SymC.ASoreThroatPain = AnaliseCount(Sym.ASoreThroatPain, SymC.ASoreThroatPain, SymC.AverageValue(), false);
                    SymC.NotSay = AnaliseCount(Sym.NotSay, SymC.NotSay, SymC.AverageValue(), false);
                    SymC.Rheum = AnaliseCount(Sym.Rheum, SymC.Rheum, SymC.AverageValue(), false);
                    SymC.JointPain = AnaliseCount(Sym.JointPain, SymC.JointPain, SymC.AverageValue(), false);
                    break;
                default:
                    SymC.Cough = AnaliseCount(Sym.Cough, SymC.Cough, SymC.AverageValue());
                    SymC.Sputum = AnaliseCount(Sym.Sputum, SymC.Sputum, SymC.AverageValue());
                    SymC.PainInLungs = AnaliseCount(Sym.PainInLungs, SymC.PainInLungs, SymC.AverageValue());
                    SymC.RattlingInLungs = AnaliseCount(Sym.RattlingInLungs, SymC.RattlingInLungs, SymC.AverageValue());
                    SymC.FeverTemperature = AnaliseCount(Sym.FeverTemperature, SymC.FeverTemperature, SymC.AverageValue());
                    SymC.SoreThroat = AnaliseCount(Sym.SoreThroat, SymC.SoreThroat, SymC.AverageValue());
                    SymC.ASoreThroatPain = AnaliseCount(Sym.ASoreThroatPain, SymC.ASoreThroatPain, SymC.AverageValue());
                    SymC.NotSay = AnaliseCount(Sym.NotSay, SymC.NotSay, SymC.AverageValue());
                    SymC.Rheum = AnaliseCount(Sym.Rheum, SymC.Rheum, SymC.AverageValue());
                    SymC.JointPain = AnaliseCount(Sym.JointPain, SymC.JointPain, SymC.AverageValue());
                    break;
            }
            return SymC;
        }

        private static short AnaliseCount(bool flag, short Count, int Avr, bool key_symptom = true)
        {
            if (key_symptom)
            {
                if (flag)
                {
                    if ((Count + 1) < 26)
                    {
                        ++Count;
                    }
                }
                else
                {
                    if (((Count - 1) > 0) && (Count>Avr))
                    {
                        --Count;
                    }
                }
            }
            else
            {
                if (flag)
                {
                    if (Count < 21)
                    {
                        ++Count;
                    }
                }
                else
                {
                    if (Count  > 0)
                    {
                        --Count;
                    }
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
            SymC[Flag - 1] = ChangeCost( Sym, SymC[Flag - 1],SymC[Flag - 1].ID);
            return Flag; 

        }

        public static int BetaGetSum(ref SYMPTOME Sym, ref SYMPTOME_COST[] SymC)
        {
            int i = 0, Flag = 1;
            int[] SummMass = new int[5];
            SummMass[0] = Deseare(Sym, SymC[0]);
            SummMass[1] = Deseare(Sym, SymC[1]);
            SummMass[2] = Deseare(Sym, SymC[2]);
            SummMass[3] = Deseare(Sym, SymC[3]);
            SummMass[4] = Deseare(Sym, SymC[4]);
            for (i = 0; i < 5; ++i)
            {
                if (SummMass[i] > SummMass[Flag - 1])
                {
                    Flag = i + 1;
                }
            }
            SymC[Flag - 1] = ChangeCost(Sym, SymC[Flag - 1]);
            return Flag;

        }


        public static void Study(SqlConnection Connection)
        {
            SYMPTOME[] Sym = new SYMPTOME[75];
            SYMPTOME_COST SymC = new SYMPTOME_COST();
            Sym = StartStudy(Sym);
            for(int i = 0; i < 75; ++i)
            {
                if( i == 0 || i == 15 || i == 30 || i == 45 || i == 60)
                {
                    
                    if (i == 0)
                    {
                        SymC.DefVPne();
                    }
                    if (i == 15)
                    {
                        SymC.DefVAng();
                    }
                    if (i == 30)
                    {
                        SymC.DefVFlu();
                    }
                    if (i == 45)
                    {
                        SymC.DefVPha();
                    }
                    if (i == 60)
                    {
                        SymC.DefVBro();
                    }
                }
                SymC = ChangeCost(Sym[i], SymC);
                if (i == 14 || i == 29 || i == 44 || i == 59 || i == 74)
                {
                    BetaUpdateTable(Connection, SymC: SymC);
                }
            }
        }
    }
}
