namespace CadastroClientes.Repositories;
public class ClienteRepository
{
	public List<Entities.Cliente> Lista() => new Entities.Cliente().ListaClientes().OrderBy(cliente => cliente.Nome).ToList();

	public Entities.Cliente Pesquisa(int id) => new Entities.Cliente().ListaClientes().Where(x => x.Id == id).First();

	public bool Insere(Entities.Cliente cliente)
	{
		List<Entities.Cliente> clientes = new Entities.Cliente().ListaClientes();
		clientes.Add(cliente);

		return true;
	}

	public bool? Altera(int id, Entities.Cliente cliente)
	{
		try
		{
			List<Entities.Cliente> clientes = new Entities.Cliente().ListaClientes();
			Entities.Cliente clienteUpdate = clientes.Find(cli => cli.Id == id);

			if (clienteUpdate != null)
			{
				clientes.Remove(clienteUpdate);
				clientes.Add(cliente);
				return true;
			}
			else
			{
				return false;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return null;
		}
	}

	public bool Deleta(int id)
	{
		int rowsBefore, rowsAfter;
		List<Entities.Cliente> clientes = new Entities.Cliente().ListaClientes();
		rowsBefore = clientes.Count;

		clientes.Remove(clientes.Where(x => x.Id == id).First());
		rowsAfter = clientes.Count;

		return rowsAfter != rowsBefore;
	}
}