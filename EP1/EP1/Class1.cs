using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP1
{
    class Tela: Product
    {
        private float n;
        private float s;
        private float m;
        private float c;
        

        public Tela(float n, float s, float m, float c)
        {
            this.n = n;
            this.s = s;
            this.m = m;
            this.c = c;
            
        }

        public override float Price()
        {
            return n*s*m*c; 
        }
    }
}
