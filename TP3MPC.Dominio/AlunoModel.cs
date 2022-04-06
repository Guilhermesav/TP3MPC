using System;
using TP3MPC.Dominio.ValueObject;

namespace TP3MPC.Dominio
{
    public class AlunoModel
    {
        internal AlunoModel(string nome, Matricula matricula, string curso,float mensalidade)
        {
            Nome = nome;
            this.Matricula = matricula.Numero;
            Curso = curso;
            Mensalidade = mensalidade;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Matricula { get; set; }

        public string Curso { get; set; }

        public float Mensalidade { get; set; }
        
    }

}
