using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy_eSports_BE
{
    public class HeroeBE
    {
        private int mvarid_heroe;
        public int IdHeroe
        {
            get { return mvarid_heroe; }
            set { mvarid_heroe = value; }
        }
        private String mvarnom_heroe;
        public String NomHeroe
        {
            get { return mvarnom_heroe; }
            set { mvarnom_heroe = value; }
        }
        private String mvaratributo_heroe;
        public String Atributo
        {
            get { return mvaratributo_heroe; }
            set { mvaratributo_heroe = value; }
        }
        private String mvartipo_heroe;
        public String Tipo
        {
            get { return mvartipo_heroe; }
            set { mvartipo_heroe = value; }
        }
        private String mvarcomplejidad_heroe;
        public String Complejidad
        {
            get { return mvarcomplejidad_heroe; }
            set { mvarcomplejidad_heroe = value; }
        }

    }
}
