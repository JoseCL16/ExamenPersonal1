using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP1
{
    class Arcillas: Product
    {
        private float n1;
        private float w;
        private float s1;
        private float c1;
        

        public Arcillas(float n1, float w, float s1, float c1)
        {
            this.n1 = n1;
            this.w = w;
            this.s1 = s1;
            this.c1 = c1;
        }

        public override float Price()
        {
            return n1 * w * s1 * c1 ;
        }
    }
}
