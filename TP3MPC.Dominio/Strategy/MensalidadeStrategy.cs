using System;
using System.Collections.Generic;
using System.Text;

namespace TP3MPC.Dominio.Strategy
{
    public class MensalidadeStrategy : IStrategy
    {
        public float DefinaMensalidade(string curso)
        {
            if (curso == "Direito") {
                float mensalidade = 1000;
                return mensalidade;
            }else if(curso == "Economia")
            {
                float mensalidade = 1500;
                return mensalidade;
            }
            else
            {
                throw new Exception("Não Oferecemos Este Curso");
            }
        }
    }
}
