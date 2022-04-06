using System;
using System.Collections.Generic;
using System.Text;

namespace TP3MPC.Dominio.Strategy
{
    public interface IStrategy
    {
        float DefinaMensalidade(string curso);
    }
}
