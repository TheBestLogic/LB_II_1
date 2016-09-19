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
            public bool ASoreThroat;//боль в горле
            public bool FeverTemperature;//жар
            public bool LowTemperature;//Низкая Температура
            public bool JointPain;//Боль в суставах
            public bool HighBloodPressure;//Высокое артериально давтение
            public bool LowBloodPressure;//Низкое артериально давтение
            public bool SoreThroat;//Воспаление горла
            public bool Sputum;//Макрота
            public bool RattlingInLungs;//Хрип в легких
            public bool Vomiting; //рвота

            public void SetStructFlag(SYMPTOME Sym)
            {
                Rheum = Sym.Rheum;
                Cough = Sym.Cough;
                ASoreThroat = Sym.ASoreThroat;
                FeverTemperature = Sym.FeverTemperature;
                LowTemperature = Sym.LowTemperature;
                JointPain = Sym.JointPain;
                HighBloodPressure = Sym.HighBloodPressure;
                LowBloodPressure = Sym.LowBloodPressure;
                SoreThroat = Sym.SoreThroat;
                Sputum = Sym.Sputum;
                RattlingInLungs = Sym.RattlingInLungs;
                Vomiting = Sym.Vomiting;
            }


        };

        public struct SYMPTOME_COST //стоимость симптома 
        {
            public short Rheum;//насморк
            public short Cough;//кашель
            public short ASoreThroat;//боль в горле
            public short FeverTemperature;//жар
            public short LowTemperature;//Низкая Температура
            public short JointPain;//Боль в суставах
            public short HighBloodPressure;//Высокое артериально давтение
            public short LowBloodPressure;//Низкое артериально давтение
            public short SoreThroat;//Воспаление горла
            public short Sputum;//Макрота
            public short RattlingInLungs;//Хрип в легких
            public short Vomiting; //рвота

            public void SetStructCost(SYMPTOME_COST Sym)
            {
                Rheum = Sym.Rheum;
                Cough = Sym.Cough;
                ASoreThroat = Sym.ASoreThroat;
                FeverTemperature = Sym.FeverTemperature;
                LowTemperature = Sym.LowTemperature;
                JointPain = Sym.JointPain;
                HighBloodPressure = Sym.HighBloodPressure;
                LowBloodPressure = Sym.LowBloodPressure;
                SoreThroat = Sym.SoreThroat;
                Sputum = Sym.Sputum;
                RattlingInLungs = Sym.RattlingInLungs;
                Vomiting = Sym.Vomiting;
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
                                //6-Гайморит
            SYMPTOME_COST SymCost;
        };

        public int CheckDisease(SYMPTOME Sym)
        {
            int MayBeItResult = 0;
            //
            Pneumonia(Sym);
            Angina(Sym);
            Flu(Sym);
            Pharyngitis(Sym);
            Bronchitis(Sym);
            Genyantritis(Sym);
            //
            return MayBeItResult;
        }

        bool Pneumonia(SYMPTOME Sym)//Воспаление легких
        {
            bool Flag = Sym.Rheum & Sym.Cough & Sym.ASoreThroat & Sym.FeverTemperature & Sym.LowTemperature & Sym.JointPain;
            Flag = Flag & Sym.HighBloodPressure & Sym.LowBloodPressure & Sym.SoreThroat & Sym.Sputum & Sym.RattlingInLungs & Sym.Vomiting;
            if (Flag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool Angina(SYMPTOME Sym)//ангина
        {
            bool Flag = Sym.Rheum & Sym.Cough & Sym.ASoreThroat & Sym.FeverTemperature & Sym.LowTemperature & Sym.JointPain;
            Flag = Flag & Sym.HighBloodPressure & Sym.LowBloodPressure & Sym.SoreThroat & Sym.Sputum & Sym.RattlingInLungs & Sym.Vomiting;
            if (Flag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool Flu(SYMPTOME Sym)//Грипп
        {
            bool Flag = Sym.Rheum & Sym.Cough & Sym.ASoreThroat & Sym.FeverTemperature & Sym.LowTemperature & Sym.JointPain;
            Flag = Flag & Sym.HighBloodPressure & Sym.LowBloodPressure & Sym.SoreThroat & Sym.Sputum & Sym.RattlingInLungs & Sym.Vomiting;
            if (Flag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool Pharyngitis(SYMPTOME Sym)//Фарингит
        {
            bool Flag = Sym.Rheum & Sym.Cough & Sym.ASoreThroat & Sym.FeverTemperature & Sym.LowTemperature & Sym.JointPain;
            Flag = Flag & Sym.HighBloodPressure & Sym.LowBloodPressure & Sym.SoreThroat & Sym.Sputum & Sym.RattlingInLungs & Sym.Vomiting;
            if (Flag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool Bronchitis(SYMPTOME Sym)//Бронхит
        {
            bool Flag = Sym.Rheum & Sym.Cough & Sym.ASoreThroat & Sym.FeverTemperature & Sym.LowTemperature & Sym.JointPain;
            Flag = Flag & Sym.HighBloodPressure & Sym.LowBloodPressure & Sym.SoreThroat & Sym.Sputum & Sym.RattlingInLungs & Sym.Vomiting;
            if (Flag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool Genyantritis(SYMPTOME Sym)//Гайморит
        {
            bool Flag = Sym.Rheum & Sym.Cough & Sym.ASoreThroat & Sym.FeverTemperature & Sym.LowTemperature & Sym.JointPain;
            Flag = Flag & Sym.HighBloodPressure & Sym.LowBloodPressure & Sym.SoreThroat & Sym.Sputum & Sym.RattlingInLungs & Sym.Vomiting;
            if (Flag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        
    }
}
