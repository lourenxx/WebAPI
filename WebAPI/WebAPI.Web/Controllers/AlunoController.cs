using Microsoft.AspNetCore.Mvc;
using WebAPI.Api.Models;

namespace WebAPI.Web.Controllers
{
    public class AlunoController : Controller
    {
        private readonly HttpClient _httpClient;

        public AlunoController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("api/aluno");
            response.EnsureSuccessStatusCode();
            var alunos = await response.Content.ReadFromJsonAsync<List<Usuarios>>();
            return View(alunos);
        }
    }
}
