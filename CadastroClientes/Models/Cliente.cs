using System.ComponentModel.DataAnnotations;

namespace CadastroClientes.Models;

public class Cliente
{
    public int Id {get; set;}
    
    [Required] // Campo obrigatório
    [StringLength(100)] // Tamanho máximo do texto em caracter
    public string Nome {get; set;} =string.Empty;

    [StringLength(14)]
    

    public string CPF {get; set;} // ? = aceita nulo

    [EmailAddress] // identificar que o campo é e-mail 
    [StringLength(150)] // Tamnha máximo de texto em caracter
    public string Email {get; set;}
    [Phone]
    [StringLength(20)]
    public string Telefone {get; set;}
    [StringLength(200)]
    public string Endereco {get; set;}  
    [StringLength(100)]  
    public string Cidade {get; set;}
    [StringLength(2)]
    public string Uf {get; set;}
    
    [DataType(DataType.Date)] // Mostrar somente a data (sem horas)
    [Display(Name = "Data de nascimento")] // mostra o campo ao usúario de outra forma 
    public DateTime DataNascimento {get; set;}
    public bool Ativo {get; set;} = true;
}
