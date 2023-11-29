using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TGDD_Clone_2.Data;
using TGDD_Clone_2;

[Route("laptops")]
[ApiController]
public class LaptopController : Controller{
    private readonly DBContext _db;
    
    public LaptopController(DBContext db){
        _db = db;
    }

    public async Task<ActionResult<List<Laptop>>> GetSpecials()
    {
        var laptops = await _db.Laptops.ToListAsync();
        return Ok(laptops);
    }
    
}
    