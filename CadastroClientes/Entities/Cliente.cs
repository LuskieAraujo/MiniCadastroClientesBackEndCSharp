namespace CadastroClientes.Entities;
public class Cliente
{
	public int Id { get; set; }
	public string Nome { get; set; }
	public string CPF { get; set; }
	public DateTime DataNascimento { get; set; }
	public Endereco Endereco { get; set; }
	public List<Contato>? Contatos { get; set; }
}
