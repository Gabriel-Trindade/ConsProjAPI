namespace ConsProjAWS.Models;

public class Produto
{ 
    public int ProdutoId { get; set; }

    public string? ProdutoName { get; set;}

    public string? Description { get; set;} 

    public decimal Price { get; set; }

    public string? ImageURL { get; set; }

    public float stock { get; set;}

    public DateTime DataCadastro { get; set; }


}
