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

	// POST api/<Cliente>
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

	// PUT api/<Cliente>/5
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

	// DELETE api/<Cliente>/5
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
}