using Microsoft.AspNetCore.Mvc;

namespace CadastroClientes.Controllers;
[Route("api/[controller]")]
[ApiController]
public class Cliente : ControllerBase
{
	[HttpGet]
	public IEnumerable<Entities.Cliente> Get()
	{
		try
		{
			return new Services.Cliente().ListaClientes();
		}
		catch (Exception)
		{
			return new List<Entities.Cliente>();
		}
	}

	[HttpGet("{id}")]
	public Entities.Cliente Get(int id)
	{
		try
		{
			return new Services.Cliente().PesquisaCliente(id);
		}
		catch (Exception)
		{
			return new Entities.Cliente();
		}
	}

	// POST api/<Cliente>
	[HttpPost]
	public void Post([FromBody] string value)
	{
	}

	// PUT api/<Cliente>/5
	[HttpPut("{id}")]
	public void Put(int id, [FromBody] string value)
	{
	}

	// DELETE api/<Cliente>/5
	[HttpDelete("{id}")]
	public List<Entities.Cliente> Delete(int id)
	{
		return new Services.Cliente().DeletaCliente(id);
	}
}