using BoutiqueWeb.Data;
using BoutiqueWeb.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BoutiqueWeb.Controllers;

[ApiController]
[Route("api/client")]
public class CourseController : ControllerBase
{
    private readonly BoutiqueWebContext _context;

    public CourseController(BoutiqueWebContext context)
    {
        _context = context;
    }

    // GET: api/course
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ClientDTO>>> GetClients()
    {
        var clients = _context.Clients.Select(x => new ClientDTO(x));
        return await clients.ToListAsync();
    }
}