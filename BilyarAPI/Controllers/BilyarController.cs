using BilyaranBusinessLayer;
using BilyaranCommon;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using BilyarAPI.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BilyarController : ControllerBase
    {
        private readonly BilyaranBLServices _billiardService;
        private readonly EmailNotificationService _emailService;

        public BilyarController(BilyaranBLServices billiardService, EmailNotificationService emailService)
        {
            _billiardService = billiardService;
            _emailService = emailService;
        }

        [HttpGet("tables")]
        public ActionResult<IEnumerable<BTables>> GetAllTables()
        {
            var tables = _billiardService.GetAllTables();
            return Ok(tables);
        }

        [HttpPost("addPlayers")]
        public ActionResult<bool> AddPlayersToTable(
            [FromQuery] int tableNumber,
            [FromQuery] string playerOne,
            [FromQuery] string playerTwo)
        {
            var result = _billiardService.AddPlayerToTable(tableNumber, playerOne, playerTwo);
            return Ok(result);
        }

        [HttpPatch("removePlayer")]
        public ActionResult<bool> RemovePlayerFromTable([FromQuery] int tableNumber)
        {
            var result = _billiardService.RemovePlayerFromATable(tableNumber);
            return Ok(result);
        }

        [HttpPatch("updatePayment")]
        public ActionResult<bool> UpdatePayment(
            [FromQuery] int tableNumber,
            [FromQuery] string playerName,
            [FromQuery] int price)
        {
            var result = _billiardService.UpdatePayment(tableNumber, playerName, price);
            return Ok(result);
        }       
        }
    }
}