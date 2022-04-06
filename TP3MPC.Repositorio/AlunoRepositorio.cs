using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TP3MPC.Dominio;
using TP3MPC.Repositorio.Data;

namespace TP3MPC.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        public static List<AlunoModel> _alunoList = new List<AlunoModel>();
        

        public void Atualizar(AlunoModel obj)
        {
             var aluno = _alunoList.FirstOrDefault(x => x.Id == obj.Id);
            _alunoList.Remove(aluno);
            _alunoList.Add(obj);
        }

        public void Excluir(int  id)
        {
            var aluno = _alunoList.FirstOrDefault(x => x.Id == id);
            _alunoList.Remove(aluno);
        }

        public AlunoModel Obter(int id)
        {
            return _alunoList.FirstOrDefault(x => x.Id == id);
        }

        public List<AlunoModel> ObterPorCriterio(Expression<Func<AlunoModel, bool>> expression)
        {
            return _alunoList.Where(expression.Compile()).ToList();
        }

        public List<AlunoModel> ObterTodos()
        {

            return _alunoList;
        }

        public void Salvar(AlunoModel obj)
        {
            _alunoList.Add(obj);
        }

        
    }
}
