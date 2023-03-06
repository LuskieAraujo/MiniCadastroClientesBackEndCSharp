using Microsoft.AspNetCore.Mvc;

namespace CadastroClientes.Controllers;
[Route("api/[controller]")]
[ApiController]
public class Cliente : ControllerBase
{
	[HttpGet]
	public ActionResult<List<Entities.Cliente>> Get()
	{
		try
		{
			return Ok(new Services.Cliente().Listar());
		}
		catch (Exception)
		{
			return BadRequest();
		}
	}

	[HttpGet("{id}")]
	public ActionResult<Entities.Cliente> Get(int id)
	{
		try
		{
			return Ok(new Services.Cliente().Pesquisar(id));
		}
		catch (Exception)
		{
			return BadRequest();
		}
	}

	[HttpPost]
	public ActionResult Post([FromBody] Entities.Cliente novoCliente)
	{
		try
		{
			return Ok(new Services.Cliente().Salvar(novoCliente.Id, novoCliente));
		}
		catch (Exception)
		{
			return BadRequest();
		}
	}

	[HttpPut("{id}")]
	public ActionResult<bool> Put(int id, [FromBody] Entities.Cliente cliente)
	{
		try
		{
			bool? result = new Services.Cliente().Salvar(id, cliente);
			return result.Value ? Ok() : NoContent();
		}
		catch (Exception)
		{
			return BadRequest();
		}
	}

	[HttpPut("{id}/c/{id}")]
	public ActionResult<bool> PutContact(int id, [FromBody] Entities.Cliente cliente)
	{
		try
		{
			bool? result = new Services.Cliente().Salvar(id, cliente);
			return result.Value ? Ok() : NoContent();
		}
		catch (Exception)
		{
			return BadRequest();
		}
	}

	[HttpPut("{id}/e/{id}")]
	public ActionResult<bool> PutAddress(int id, [FromBody] Entities.Cliente cliente)
	{
		try
		{
			bool? result = new Services.Cliente().Salvar(id, cliente);
			return result.Value ? Ok() : NoContent();
		}
		catch (Exception)
		{
			return BadRequest();
		}
	}

	[HttpDelete("{id}")]
	public ActionResult<List<Entities.Cliente>> Delete(int id)
	{
		try
		{
			bool? result = new Services.Cliente().Deletar(id);
			return result.Value ? Ok() : NoContent();
		}
		catch (Exception)
		{
			return BadRequest();
		}
	}

	[HttpDelete("{id}/c/{id}")]
	public ActionResult<bool> DeleteContact(int id, int contato)
	{
		try
		{
			return Ok();
		}
		catch (Exception)
		{
			return BadRequest();
		}
	}

	[HttpDelete("{id}/e/{id}")]
	public ActionResult<bool> DeleteAddress(int id, int contato)
	{
		try
		{
			return Ok();
		}
		catch (Exception)
		{
			return BadRequest();
		}
	}
}