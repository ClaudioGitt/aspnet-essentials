// Namespace é um conjunto de classes
using Microsoft.AspNetCore.Mvc;

namespace GerenciaTarefa.Controllers;

public class TarefaController:Controller{


// View é igual a uma página web ( site)
// Site possui funções
public IActionResult Index(){
    ViewData["Cabecalho"] = "Tarefa Diária";
    ViewData["Titulo"] = "Planejar Aula Senai";
    ViewData["Descricao"] = "Criar nova PEUC";
    return View();
}
    
}