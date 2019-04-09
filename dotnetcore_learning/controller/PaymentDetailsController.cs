using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetcore_learning.model;
using System.Web.Http.Description;

namespace dotnetcore_learning.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailsController : ControllerBase
    {
        private readonly PaymentContext _context;

        public PaymentDetailsController(PaymentContext context)
        {
            _context = context;
        }

        // GET: api/PaymentDetails
        [HttpGet]
        public IEnumerable<PaymentDetail> GetpaymentDetails()
        {
            return _context.PaymentDetails;
        }

        // GET: api/PaymentDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPaymentDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var paymentDetail = await _context.PaymentDetails.FindAsync(id);

            if (paymentDetail == null)
            {
                return NotFound();
            }

            return Ok(paymentDetail);
        }

        // PUT: api/PaymentDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentDetail([FromRoute] int id, [FromBody] PaymentDetail paymentDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != paymentDetail.paymentId)
            {
                return BadRequest();
            }

            _context.Entry(paymentDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PaymentDetails
        [HttpPost]
        public async Task<IActionResult> PostPaymentDetail([FromBody] PaymentDetail paymentDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PaymentDetails.Add(paymentDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaymentDetail", new { id = paymentDetail.paymentId }, paymentDetail);
        }

        // DELETE: api/PaymentDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePaymentDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var paymentDetail = await _context.PaymentDetails.FindAsync(id);
            if (paymentDetail == null)
            {
                return NotFound();
            }

            _context.PaymentDetails.Remove(paymentDetail);
            await _context.SaveChangesAsync();

            return Ok(paymentDetail);
        }

        private bool PaymentDetailExists(int id)
        {
            return _context.PaymentDetails.Any(e => e.paymentId == id);
        }
        [HttpGet("count")]
        [ResponseType(typeof(string))]
        public int GetCount()
        {
            return _context.PaymentDetails.Count();
        }
    }
}