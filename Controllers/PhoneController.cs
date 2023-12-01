using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TGDD_Clone_2.Data;
using TGDD_Clone_2;

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
    [HttpGet("{Id}")]
    public async Task<ActionResult<Phone>> GetPhoneDetail(int Id)
    {
        
        var phone = await _db.Phones
            .Where(o => o.Id.Equals(Id))
            .SingleOrDefaultAsync();

        if (phone == null)
        {
            return NotFound();
        }

        return phone;
    }
}