using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TGDD_Clone.Data;
using TGDD_Clone;

[Route("phones")]
[ApiController]
public class PhoneController : Controller{
    private readonly DBContext _db;
    
    public PhoneController(DBContext db){
        _db = db;
    }

    public async Task<ActionResult<List<Phone>>> GetSpecials()
    {
        var phones = await _db.Phones.ToListAsync();
        return Ok(phones);
    }
}