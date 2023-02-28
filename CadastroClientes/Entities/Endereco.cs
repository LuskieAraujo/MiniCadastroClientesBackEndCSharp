namespace CadastroClientes.Entities;
public class Endereco
{
	public int Id { get; set; }
	public int? Numero { get; set; }
	public string? Complemento { get; set; }
	public string Nome { get; set; }
	public int Cidade { get; set; }
	public string CidadeNome { get; set; }
	public int Estado { get; set; }
	public string EstadoNome { get; set; }
	public int Pais { get; set; }
	public string PaisNome { get; set; }
	public string CEP { get; set; }
}