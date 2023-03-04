namespace CadastroClientes.Entities;
public class Cliente
{
	public int Id { get; set; }
	public string Nome { get; set; }
	public string CPF { get; set; }
	public DateTime DataNascimento { get; set; }
	public Endereco Endereco { get; set; }
	public List<Contato>? Contatos { get; set; }

	public List<Cliente> ListaClientes()
	{
		List<Cliente> clientes = new List<Cliente>();

		clientes.Add(new Cliente
		{
			Id = 0,
			Nome = "George Washington",
			CPF = "12345678901",
			DataNascimento = Convert.ToDateTime("22/02/1732"),
			Endereco = new Endereco
			{
				Id = 0,
				CEP = "01234567",
				Cidade = 9,
				CidadeNome = "Westmoreland",
				Estado = 17,
				EstadoNome = "Virgínia",
				Pais = 2,
				PaisNome = "Estados Unidos",
				Nome = "Rua de Terra",
				Numero = 3
			},
			Contatos = new List<Contato>
			{
				new Contato { Id = 0, Tipo = 1, Info = "george_washington@potus.com" },
				new Contato { Id = 1, Tipo = 0, Info = "12345678" }
			}
		});

		clientes.Add(new Cliente
		{
			Id = 1,
			Nome = "Benjamin Franklin",
			CPF = "12345678901",
			DataNascimento = Convert.ToDateTime("17/01/1706"),
			Endereco = new Endereco
			{
				Id = 0,
				CEP = "01234567",
				Cidade = 1,
				CidadeNome = "Boston",
				Estado = 1,
				EstadoNome = "Massachussets",
				Pais = 2,
				PaisNome = "Estados Unidos",
				Nome = "Rua Milk",
				Numero = 22,
				Complemento = "Apartment 2"
			},
			Contatos = new List<Contato>
			{
				new Contato { Id = 0, Tipo = 1, Info = "benjamin_franklin@potus.com" },
				new Contato { Id = 1, Tipo = 0, Info = "11234567" }
			}
		});

		clientes.Add(new Cliente
		{
			Id = 2,
			Nome = "Thomas Jefferson",
			CPF = "12345678901",
			DataNascimento = Convert.ToDateTime("13/04/1743"),
			Endereco = new Endereco
			{
				Id = 0,
				CEP = "01234567",
				Cidade = 1,
				CidadeNome = "Charlotesville",
				Estado = 1,
				EstadoNome = "Virgínia",
				Pais = 2,
				PaisNome = "Estados Unidos",
				Nome = "Fazenda Shadwell",
				Numero = 22,
				Complemento = ""
			},
			Contatos = new List<Contato>
			{
				new Contato { Id = 0, Tipo = 1, Info = "thomas_jefferson@potus.com" },
				new Contato { Id = 1, Tipo = 0, Info = "11123456" }
			}
		});

		return clientes;
	}
}