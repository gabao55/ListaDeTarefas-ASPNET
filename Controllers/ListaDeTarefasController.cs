using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListaDeTarefas.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ListaDeTarefasController : ControllerBase
    {
        private readonly List<string> ListaTarefas = new List<string>();

        [HttpGet]
        public string[] GetTarefas()
        {
            return ListaTarefas.ToArray();
        }

        [HttpPost]
        public string PostTarefas([FromBody] string tarefa)
        {
            ListaTarefas.Add(tarefa);

            return $"Tarefa {tarefa} adicionada com sucesso";
        }

        [HttpDelete("{tarefa}")]
        public string DeleteTarefas(string tarefa)
        {
            ListaTarefas.Remove(tarefa);

            return $"Tarefa {tarefa} removida com sucesso";
        }
    }
}