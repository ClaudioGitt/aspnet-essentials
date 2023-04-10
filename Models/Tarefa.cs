// Namespace é um conjunto de classes
namespace GerenciaTarefa.Models;
public class Tarefa{
 //class é um conjunto de objetos.
 //public quer dizer que as classes podem acessar e mecher.
 //Preciso ter duas coisas: Propriedades e Funcionalidades.
 // propriedades Automáticas
 // agrupar classes
 public int id { get; set; } //inteiro
 public string? Cabecalho { get; set; }
  public string? Titulo { get; set; }
 public string? Descricao { get; set; } //texto

 public bool TaCompleta { get; set; } //bool quer dizer verdadeiro ou falso/true or false
 //Funcionalidades
 // a classe tem 3 propriedades automáticas:

}