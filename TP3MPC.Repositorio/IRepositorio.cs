using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TP3MPC.Repositorio
{
    public interface IRepositorio<T>
    {
        void Salvar(T obj);
        void Atualizar(T obj);
        void Excluir(int id);
        T Obter(int id);
        List<T> ObterTodos();

        List<T> ObterPorCriterio(Expression<Func<T, bool>> expression);
    }
}
