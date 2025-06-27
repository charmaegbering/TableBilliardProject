using Microsoft.AspNetCore.Mvc;
using BilyaranCommon;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BilliardController : ControllerBase
    {
         BilyaranBusinessLayer.BilyaranBLServices billiardService = new BilyaranBusinessLayer.BilyaranBLServices();

        [HttpGet("tables")]
        public IEnumerable<BTables> GetAllTables()
        {
            return billiardService.GetAllTables();
        }

        [HttpPost("addPlayers")]
        public ActionResult<bool> AddPlayersToTable(int tableNumber, string playerOne, string playerTwo)
        {
            var result = billiardService.AddPlayerToTable(tableNumber, playerOne, playerTwo);
            return Ok(result);
        }

        [HttpPatch("removePlayer")]
        public ActionResult<bool> RemovePlayerFromTable(int tableNumber)
        {
            var result = billiardService.RemovePlayerFromATable(tableNumber);
            return Ok(result);
        }

        [HttpPatch("updatePayment")]
        public ActionResult<bool> UpdatePayment(int tableNumber, string playerName, int payment)
        {
            var result = billiardService.UpdatePayment(tableNumber, playerName, payment);
            return Ok(result);
        }
    }
}
