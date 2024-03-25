using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Futbolcular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListFootballer()
        {
            using var c = new Context();
            var values = c.Footballers.ToList();
            return Ok(values);
        }

        [HttpGet("{number}")]
        public IActionResult GetOneFootballer(int number)
        {
            using var c = new Context();
            var values = c.Footballers.Find(number);

            if (values == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(values);
            }

        }

        [HttpPost]
        public IActionResult PostFootballer(Footballer footballer)
        {
            using var c = new Context();
            c.Add(footballer);
            c.SaveChanges();
            return Ok();
        }

        [HttpDelete("{number}")]
        public IActionResult DeleteFootballer(int number)
        {
            using var c=new Context();
            var futbolcu=c.Footballers.Find(number);
            if (futbolcu==null)
            {
               return NotFound();
            }
            else
            {
                c.Remove(futbolcu);
                c.SaveChanges();
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult PutFootballer(Footballer footballer)
        {
            using var c=new Context();  
            var futbolcu=c.Find<Footballer>(footballer.Number);
            if (footballer==null)
            {
                return NotFound();
            }

            else
            {
                futbolcu.Number= footballer.Number;
                c.Update(futbolcu);
                c.SaveChanges();
                return Ok();
            }
        }
        
    }
}
