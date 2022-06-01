using System;
using System.Collections.Generic;
using System.Text;

namespace testCampeones
{   
    interface Icampeon
    {
        void habilidadQ();
        void habilidadW();
        void habilidadE();
        void habilidadR();
    }
    class Campeon
    {
        private string name;
        private int health;
        private int AP;
        private int AD;
        private int mana;
        private int magicRest;
        private int movspeed;
        private int atkspeed;
        private int nivel;

        public Campeon(string n,int h,int ap,int ad,int m,int mr,int mvs,int atksp)
        {
            name = n;
            health = h;
            AP = ap;
            AD= ad;
            mana= m;
            magicRest=mr;
            movspeed= mvs;
            atkspeed = atksp;
            nivel = 0;
        }

        public override string ToString()
        {
            return " Nombre:"+name+ "\n vida:"+health+ "\n AP:"+AP
                + "\n AD:"+AD+ "\n MANA:"+mana+ "\n Resist. Magica:"+magicRest+ "\n Vel. Mov:"+movspeed+
                "\n Vel Atk:"+atkspeed+ "\n Niv:"+nivel;
        }
    }
}
