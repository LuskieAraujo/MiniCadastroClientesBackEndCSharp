namespace CadastroClientes.Repositories;
public class ClienteRepository
{
	public List<Entities.Cliente> ListarClientes()
	{
		List<Entities.Cliente> clientes = new List<Entities.Cliente>();

		clientes.Add(new Entities.Cliente
		{
			Id = 0,
			Nome = "George Washington",
			CPF = "12345678901",
			DataNascimento = Convert.ToDateTime("22/02/1732"),
			Endereco = new Entities.Endereco
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
			Contatos = new List<Entities.Contato>
			{
				new Entities.Contato { Id = 0, Tipo = 1, Info = "george_washington@potus.com" },
				new Entities.Contato { Id = 1, Tipo = 0, Info = "12345678" }
			}
		});

		clientes.Add(new Entities.Cliente
		{
			Id = 1,
			Nome = "Benjamin Franklin",
			CPF = "12345678901",
			DataNascimento = Convert.ToDateTime("17/01/1706"),
			Endereco = new Entities.Endereco
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
			Contatos = new List<Entities.Contato>
			{
				new Entities.Contato { Id = 0, Tipo = 1, Info = "benjamin_franklin@potus.com" },
				new Entities.Contato { Id = 1, Tipo = 0, Info = "11234567" }
			}
		});

		clientes.Add(new Entities.Cliente
		{
			Id = 2,
			Nome = "Thomas Jefferson",
			CPF = "12345678901",
			DataNascimento = Convert.ToDateTime("13/04/1743"),
			Endereco = new Entities.Endereco
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
			Contatos = new List<Entities.Contato>
			{
				new Entities.Contato { Id = 0, Tipo = 1, Info = "thomas_jefferson@potus.com" },
				new Entities.Contato { Id = 1, Tipo = 0, Info = "11123456" }
			}
		});

		return clientes;
	}
}