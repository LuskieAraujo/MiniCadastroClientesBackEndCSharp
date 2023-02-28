using CadastroClientes.Repositories;

namespace CadastroClientes.Services;
public class Cliente
{
	public List<Entities.Cliente> ListaClientes()
	{
		return new ClienteRepository().ListarClientes();
	}
}