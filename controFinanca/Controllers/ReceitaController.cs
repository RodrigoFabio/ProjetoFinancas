using controFinanca.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace appFinancas.Controllers.Receita;
[ApiController]
[Route("/api/v1/receita")]
public class ReceitaController : ControllerBase
{

    ReceitaService _receitaService;
    public ReceitaController(ReceitaService receitaService)
    {
        _receitaService = receitaService;
    }

    [HttpGet]
    [Route("/listar")]
    public ActionResult GetReceita([FromQuery] int skip, int take)
    {
        //buscar receita com id especificado
        var receitas = _receitaService.GetReceitas(skip, take);

        if (receitas.Count() == 0)
        {
            return new EmptyResult();
        }

        return Ok(JsonSerializer.Serialize(receitas));
    }
}

