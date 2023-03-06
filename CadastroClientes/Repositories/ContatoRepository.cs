namespace CadastroClientes.Repositories;

public class ContatoRepository
{
	public bool? Insere(int idCliente, Entities.Contato contato)
	{
		try
		{
			return true;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public bool? Altera(int idCliente, Entities.Contato contato)
	{
		try
		{
			return true;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public bool? Deleta(int idCliente, Entities.Contato contato)
	{
		try
		{
			return true;
		}
		catch (Exception)
		{
			return null;
		}
	}
}