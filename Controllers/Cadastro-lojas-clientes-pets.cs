using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja_Pets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Cadastro_lojas_clientes_pets : ControllerBase
    {
        private readonly ConnectionStrings con;

        public UserController(ConnectionStrings c)
        {
            con = c;
        }

        [HttpGet("/clientes/{id}")]
        public IActionResult Get ()
        {
            using (var c = new MySqlConnection(conmySQL))
            {
                var sql = @"SELECT * FROM clintes WHERE id = @id or true";
            }
        }

    }
}
