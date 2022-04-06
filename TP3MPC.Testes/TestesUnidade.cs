using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using TP3MPC.Controllers;
using TP3MPC.Dominio;
using TP3MPC.Dominio.Factory;
using TP3MPC.Repositorio;
using Xunit;

namespace TP3MPC.Testes
{
    public class TestesUnidade
    {
        
        [Fact]
        public void testeDeAdicaoABancoDeDados()
        {
            //Arrange
            var alunoModel = new AlunoFactory()
                    .Criar("joao", "12345678", "economia",1500);
            
            IRepositorio<AlunoModel> repo = new AlunoRepositorio();
            AlunoRepositorio._alunoList.Clear();

            //Act
            repo.Salvar(alunoModel);
            var lista = repo.ObterTodos();
            //Assert
            Assert.True(lista.Count == 1);

        }

        [Fact]
        public void testeDeDeleçãoDoBancoDeDados()
        {
            //Arrange
            var alunoModel2 = new AlunoFactory()
                    .Criar("jonas", "12345678", "economia",1500);
            
            IRepositorio<AlunoModel> repo = new AlunoRepositorio();
            AlunoRepositorio._alunoList.Clear();


            //Act
            repo.Salvar(alunoModel2);
            repo.Excluir(alunoModel2.Id);
            var lista = repo.ObterTodos();
            //Assert
            Assert.True(lista.Count == 0);

        }

        [Fact]

        public void testDeAtualizaçãoNoBancoDeDados()
        {
            //Arrange
            var alunoModel3 = new AlunoFactory()
                    .Criar("maria", "12345678", "economia",1500);
            alunoModel3.Id = 3; 
            IRepositorio<AlunoModel> repo = new AlunoRepositorio();
            AlunoRepositorio._alunoList.Clear();

            //Act
            repo.Salvar(alunoModel3);
            alunoModel3.Curso = "ADM";
            repo.Atualizar(alunoModel3);
            var aluno = repo.Obter(alunoModel3.Id);
            //Assert
            Assert.True(aluno.Curso == "ADM");
        }
    }
}
