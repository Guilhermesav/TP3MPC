using System;
using System.Collections.Generic;
using System.Text;

namespace TP3MPC.Dominio.Strategy
{
    public class MensalidadeContext
    {
        private IStrategy _strategy;
        public MensalidadeContext()
        {
        }
        public MensalidadeContext(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public float RetornaMensalidade(string curso)
        {
            var mensalidade = _strategy.DefinaMensalidade(curso);
            return mensalidade;
        }
    }
}
