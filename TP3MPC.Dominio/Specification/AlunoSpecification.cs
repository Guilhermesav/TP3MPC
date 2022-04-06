using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TP3MPC.Dominio.Specification
{
    public static class AlunoSpecification
    {
        public static Expression<Func<AlunoModel, bool>> ObterJogadorPorPosicao(string curso) =>
          x => x.Curso == curso;
      
    }
}
