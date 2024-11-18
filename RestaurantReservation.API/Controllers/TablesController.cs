using Microsoft.AspNetCore.Mvc;
using RestaurantReservation.Services.TabelsServices;
using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablesController : ControllerBase
    {
        private readonly ITablesServices _tablesServices;

        public TablesController(ITablesServices tablesServices)
        {
            _tablesServices = tablesServices;
        }

        // POST: api/table
        [HttpPost]
        public async Task<IActionResult> CreateTable([FromBody] Tabels table)
        {
            if (table is null)
            {
                return BadRequest("Table cannot be null.");
            }
            var createdTable = await _tablesServices.CreateTables(table);
            return CreatedAtAction(nameof(GetTableById), new { id = createdTable.TabelsId}, createdTable);
        }

        // GET: api/table/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTableById(int id)
        {
            var table = await _tablesServices.GetTablesById(id);
            if (table is null)
            {
                return NotFound();
            }
            return Ok(table);
        }

        // PUT: api/table
        [HttpPut]
        public async Task<IActionResult> UpdateTable([FromBody] Tabels table)
        {
            if (table is null)
            {
                return BadRequest("Table cannot be null.");
            }
            await _tablesServices.UpdateTables(table);
            return NoContent();
        }

        // DELETE: api/table/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTable(int id)
        {
            var table = await _tablesServices.GetTablesById(id);
            if (table is null)
            {
                return NotFound();
            }
            await _tablesServices.DeleteTables(table);
            return NoContent();
        }
    }
}
