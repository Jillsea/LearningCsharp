using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
        }
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido();
            MetodoInterno();
        }    
    }


    class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            // Visível fora da classe "ModificadoresTeste".
        }
        private void MetodoPrivado()
        {
            // Visível apenas na classe "ModificadoresTeste".
        }
        protected void MetodoProtegido()
        {
            // Visivel apenas na classe "ModificadoresTeste" e derivados.
        }
        internal void MetodoInterno()
        {
            // Visivel apenas dentro do namespace/projeto.
        }
    }
}
