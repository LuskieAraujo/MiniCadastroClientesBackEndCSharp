﻿using Microsoft.AspNetCore.Mvc;

namespace CadastroClientes.Controllers;
[Route("api/[controller]")]
[ApiController]
public class Cliente : ControllerBase
{
	// GET: api/<Cliente>
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

	// GET api/<Cliente>/5
	[HttpGet("{id}")]
	public Entities.Cliente Get(int id)
	{
		try
		{
			return new Services.Cliente().ListaClientes().Where(x => x.Id == id).FirstOrDefault();
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
	public void Delete(int id)
	{
	}
}