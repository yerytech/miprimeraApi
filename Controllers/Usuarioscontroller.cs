using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Data;
using Microsoft.EntityFrameworkCore;
using MiPrimeraApi.Models;

namespace MiPrimeraApi.Controllers
{
  [ApiController]
  [Route("[controller]")]

  public class UsuariosController : ControllerBase
  {
    // datos quemados 
    private readonly AppDbContext _context;

    public UsuariosController(AppDbContext context)
    {
      _context = context;
    }

    // obtengo todos los usuarios 
    [HttpGet]
    public async  Task<ActionResult<IEnumerable<Usuario>>> Get()
    {
      return await _context.usuarios.ToListAsync();
    }

    // otengo por id
    [HttpGet("{id}")]
    public async Task< ActionResult<Usuario>> GetById(int id)
    {
      var usuario = await _context.usuarios.FindAsync(id);
      if (usuario == null)
        return NotFound("Usuario no disponible con el id:" + id);

      return usuario;
    }

    //   crear usuario 
    [HttpPost]

    public async Task<ActionResult<Usuario>> Create(Usuario nuevo)
    {
      _context.usuarios.Add(nuevo);
      await _context.SaveChangesAsync();
      return CreatedAtAction(nameof(GetById), new { id = nuevo.Id }, nuevo);
    }
    // actualizo 
    [HttpPut("{id}")]

    public async Task<IActionResult> Update(int id, Usuario newDatos)
    {
      var usuario = await _context.usuarios.FindAsync(id);
      if (usuario == null)
        return NotFound("Usuario no disponible con el id" + id);

      usuario.Nombre = newDatos.Nombre;
      usuario.Email = newDatos.Email;
      await _context.SaveChangesAsync();
      return NoContent();
    }

    //  elimina
    [HttpDelete("{id}")]
    public async  Task<IActionResult> Delete(int id)
    {
      var usuario = await _context.usuarios.FindAsync(id);
      if (usuario == null)
        return NotFound("Usuario No Disponible con el id:" + id);
       _context.usuarios.Remove(usuario);
      await _context.SaveChangesAsync();

      return NoContent();
    }


  }

  
  

}