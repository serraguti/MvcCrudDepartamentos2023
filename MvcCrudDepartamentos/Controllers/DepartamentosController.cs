﻿using Microsoft.AspNetCore.Mvc;
using MvcCrudDepartamentos.Models;
using MvcCrudDepartamentos.Repositories;

namespace MvcCrudDepartamentos.Controllers
{
    public class DepartamentosController : Controller
    {
        RepositoryDepartamentos repo;

        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        //AQUI MOSTRAMOS TODOS LOS DEPARTAMENTOS
        public IActionResult Index()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            return View(departamentos);
        }

        public IActionResult Create()
        {
            return View();
        }
        //VAMOS A RECIBIR TODO EL OBJETO DEPARTAMENTO
        //TENEMOS DOS OPCIONES:
        //1) RECIBIMOS TODO EL OBJETO
        //2) RECIBIMOS CADA VARIABLE
        [HttpPost]
        public IActionResult Create(Departamento dept)
        {
            this.repo.InsertDepartamento(dept.IdDepartamento, dept.Nombre, dept.Localidad);
            //EN LUGAR DE MOSTRAR UN MENSAJE O ALGO, LO QUE VAMOS A REALIZAR
            //ES VOLVER A LA VISTA DONDE ESTAN TODOS LOS DEPARTAMENTOS (Index)
            return RedirectToAction("Index");
        }
    }
}
