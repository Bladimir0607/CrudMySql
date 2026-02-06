using Microsoft.AspNetCore.Mvc;
using CrudMySql.Data;
using CrudMySql.Models;

namespace CrudMySql.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TareasController : ControllerBase
{
    private readonly AppDbContext _context;

    public TareasController(AppDbContext context)
    {
        _context = context;
    }

    // CREATE
    [HttpPost]
    public IActionResult Crear(Tarea tarea)
    {
        _context.Tareas.Add(tarea);
        _context.SaveChanges();
        return Ok(tarea);
    }

    // READ
    [HttpGet]
    public IActionResult Obtener()
    {
        return Ok(_context.Tareas.ToList());
    }

    // UPDATE
    [HttpPut("{id}")]
    public IActionResult Editar(int id, Tarea tarea)
    {
        var t = _context.Tareas.Find(id);
        if (t == null) return NotFound();

        t.Titulo = tarea.Titulo;
        t.Estado = tarea.Estado;
        _context.SaveChanges();

        return Ok(t);
    }

    // DELETE
    [HttpDelete("{id}")]
    public IActionResult Eliminar(int id)
    {
        var t = _context.Tareas.Find(id);
        if (t == null) return NotFound();

        _context.Tareas.Remove(t);
        _context.SaveChanges();

        return Ok();
    }
}