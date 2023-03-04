using CadastroClientes.Repositories;

namespace CadastroClientes.Services;
public class Cliente
{
	public List<Entities.Cliente> Listar()
	{
		try
		{
			return new ClienteRepository().Lista();
		}
		catch (Exception)
		{
			return null;
		}
	}

	public Entities.Cliente Pesquisar(int id)
	{
		try
		{
			return new ClienteRepository().Pesquisa(id);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public bool? Salvar(int id, Entities.Cliente dadosNovos)
	{
		try
		{
			return id > 0 ? new ClienteRepository().Altera(id, dadosNovos) : new ClienteRepository().Insere(dadosNovos);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public bool? Deletar(int id)
	{
		try
		{
			return new ClienteRepository().Deleta(id);
		}
		catch (Exception)
		{
			return null;
		}
	}
}