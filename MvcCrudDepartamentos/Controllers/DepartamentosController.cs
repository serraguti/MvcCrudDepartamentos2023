using Microsoft.AspNetCore.Mvc;
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
    }
}
