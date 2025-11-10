using Backend.DataContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.DTOs;
using Service.ExtensionMethods;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class UsuariosController : ControllerBase
    {
        private readonly BiblioContext _context;

        public UsuariosController(BiblioContext context)
        {
            _context = context;
        }

        // GET: api/Usuarios
        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios([FromQuery] string filtro = "")
        {
            return await _context.Usuarios
                .AsNoTracking()
                .Include(u => u.CarrerasInscriptas)
                .ThenInclude(ci => ci.Carrera)
                .Where(u => u.Nombre.Contains(filtro)).ToListAsync();
        }

        [HttpGet("deleteds")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetDeletedsUsuarios()
        {
            return await _context.Usuarios
                .AsNoTracking()
                .IgnoreQueryFilters()
                .Where(a => a.IsDeleted).ToListAsync();
        }

        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuarios
                .AsNoTracking()
                .Include(u => u.CarrerasInscriptas)
                .ThenInclude(ci => ci.Carrera)
                .FirstOrDefaultAsync(u => u.Id.Equals(id));

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // GET: api/Usuarios/5
        [HttpGet("byemail")]
        [Authorize]
        public async Task<ActionResult<Usuario>> GetByEmailUsuario([FromQuery] string? email)
        {
            if (string.IsNullOrEmpty(email))
                return BadRequest("El parámetro email es obligatorio.");

            var usuario = await _context.Usuarios.AsNoTracking().FirstOrDefaultAsync(u => u.Email.Equals(email));

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        // PUT: api/Usuarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("login")]
        public async Task<ActionResult<bool>> LoginInSystem([FromBody] LoginDTO loginDTO)
        {
            var usuario = await _context.Usuarios
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Email.Equals(loginDTO.Username) &&
                                          u.Password.Equals(loginDTO.Password.GetHashSha256()));
            if (usuario == null)
                return Unauthorized("Credenciales inválidas");
            return true;
        }

        // POST: api/Usuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            var usuarioExistente = await _context.Usuarios
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Email == usuario.Email || u.Dni.Equals(usuario.Dni));
            if (usuarioExistente != null)
            {
                return Conflict("Ya existe un usuario con el mismo email o DNI");
            }
            //Attach de carreras en un UsuarioCarrera
            foreach (var usuarioCarrera in usuario.CarrerasInscriptas)
            {
                _context.TryAttach(usuarioCarrera.Carrera);
            }

            _context.Usuarios.Add(usuario);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException)
            {
                if (UsuarioExists(usuario.Id))
                {
                    return Conflict("Ya existe un usuario con el mismo correo");
                }
                else
                {
                    throw new Exception("Ocurrió un error al crear el usuario");
                }
            }

            return CreatedAtAction("GetUsuario", new { id = usuario.Id }, usuario);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            usuario.IsDeleted = true;
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("restore/{id}")]
        [Authorize]
        public async Task<IActionResult> RestoreUsuario(int id)
        {
            var usuario = await _context.Usuarios.IgnoreQueryFilters().FirstOrDefaultAsync(u => u.Id.Equals(id));
            if (usuario == null)
            {
                return NotFound();
            }
            usuario.IsDeleted = false;
            //Impacta en memoria
            _context.Usuarios.Update(usuario);
            //Aca recien impacta en la base de datos
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
