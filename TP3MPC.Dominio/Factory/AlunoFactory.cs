using System;
using System.Collections.Generic;
using System.Text;
using TP3MPC.Dominio.ValueObject;

namespace TP3MPC.Dominio.Factory
{
    public class AlunoFactory
    {
        public  AlunoModel Criar(string nome, string matricula, string curso,float mensalidade)
        {
            return new AlunoModel(nome, new Matricula(matricula),curso,mensalidade);
        }

    }
}
