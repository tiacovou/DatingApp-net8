using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using Api.Entities;
using Api.Data;


namespace Api;

[ApiController]
[Route("api/[controller]")]

public class UsersController(DataContext context) : ControllerBase
{

[HttpGet]

public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()

{

var users = context.Users.ToList();
return users;

}

[HttpGet("{id:int}")]

public async Task<ActionResult<AppUser>> GetUser(int id)

{

var user = await context.Users.FindAsync(id);

if (user == null) return NotFound();

return user;




}

}