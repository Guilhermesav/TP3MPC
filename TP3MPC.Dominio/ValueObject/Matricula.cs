using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TP3MPC.Dominio.ValueObject
{
    public class Matricula
    {
        public Matricula(string numero)
        {
            ValidarMatricula(numero);
            this.Numero = numero;
        }


        public void ValidarMatricula(string numero)
        {
            var tamanho = numero.Length;

            if(tamanho < 5)
            {
                throw new Exception("A matricula deve ter no minimo 5 numeros");
            }
        }
        public string Numero { get; set; }

       
    }
}
