using LoanManagementLoanService.Models;
using Microsoft.AspNetCore.Mvc;
using LoanManagementLoanService.Interfaces;

namespace LoanManagementLoanService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ControllerBase
    {
        private readonly ILoanServices _service;

        public LoanController(ILoanServices service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() 
        { 
            return Ok(await _service.GetAllLoansAsync()); 
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var loan = await _service.GetLoanByIdAsync(id);
            if (loan == null) return NotFound();
            return Ok(loan);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] LoanModel loan)
        {
            var created = await _service.CreateLoanAsync(loan);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] LoanModel loan)
        {
            if (id != loan.Id) return BadRequest();
            await _service.UpdateLoanAsync(loan);
            return Ok();
        }

        [HttpPut("delete/{id}")]
        public async Task<IActionResult> DeleteLoan(int id)
        {

            var loan = await _service.GetLoanByIdAsync(id);
            if (loan == null) return NotFound();
            loan.isActive = false;

            await _service.UpdateLoanAsync(loan);
            return Ok();
        }

        //HardDelete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteLoanAsync(id);
            return Ok();
        }
    }

}
