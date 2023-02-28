using CadastroClientes.Repositories;

namespace CadastroClientes.Services;
public class Cliente
{
	public List<Entities.Cliente> ListaClientes()
	{
		return new ClienteRepository().ListarClientes();
	}
	public Entities.Cliente PesquisaCliente(int id)
	{
		return new ClienteRepository().ListarClientes().Where(x => x.Id == id).FirstOrDefault();
	}
	public List<Entities.Cliente> DeletaCliente(int id)
	{
		List<Entities.Cliente> clientes = new List<Entities.Cliente>();
		clientes = new ClienteRepository().ListarClientes();

		clientes.Remove(clientes.Where(x => x.Id == id).First());
		return clientes;
	}
}