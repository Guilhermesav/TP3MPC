using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP3MPC.Dominio;
using TP3MPC.Dominio.Factory;
using TP3MPC.Dominio.Strategy;
using TP3MPC.Repositorio;

namespace TP3MPC.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        private readonly MensalidadeContext _mensalidadeContext;
        public AlunoController(IAlunoRepositorio alunoRepositorio, MensalidadeContext mensalidadeContext)
        {
            _alunoRepositorio = alunoRepositorio;
            _mensalidadeContext = mensalidadeContext;
        }

        // GET: Aluno
        public IActionResult Index()
        {
            var alunos =  _alunoRepositorio.ObterTodos();
            return View(alunos);
        }
        public IActionResult Economia()
        {
            var alunos = _alunoRepositorio.ObterPorCriterio(x => x.Curso == "Economia");
            return View(alunos);
        }

        // GET: Aluno/Details/5
        public IActionResult Details(int id)
        {
            var aluno = _alunoRepositorio.Obter(id);    

            return View(aluno);
        }

        // GET: Aluno/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aluno/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection form)
        {
            if (ModelState.IsValid)
            {
                var nome = form["Nome"];
                var matricula = form["Matricula"];
                var curso = form["Curso"];
                _mensalidadeContext.SetStrategy(new MensalidadeStrategy());
                float mensalidade = _mensalidadeContext.RetornaMensalidade(curso);
                var alunoModel = new AlunoFactory()
                    .Criar(nome, matricula, curso,mensalidade);
                
                 _alunoRepositorio.Salvar(alunoModel);
                return RedirectToAction(nameof(Index));
            }
            return View("Index");
        }

        // GET: Aluno/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

           
            if (id == null)
            {
                return NotFound();
            }
            return View();
        }

        // POST: Aluno/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection form)
        {
          

            if (ModelState.IsValid)
            {
                var nome = form["Nome"];
                var matricula = form["Matricula"];
                var curso = form["Curso"];
                _mensalidadeContext.SetStrategy(new MensalidadeStrategy());
                float mensalidade = _mensalidadeContext.RetornaMensalidade(curso);
                var alunoModel = new AlunoFactory()
                    .Criar(nome, matricula, curso, mensalidade);

                _alunoRepositorio.Atualizar(alunoModel);
                return View("Index");
            }
            return View("/Home/Index");
        }

        // GET: Aluno/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (id == null)
            {
                return NotFound();
            }

            return View();
        }

        // POST: Aluno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _alunoRepositorio.Excluir(id);
            return RedirectToAction(nameof(Index));
        }

      
    }
}
