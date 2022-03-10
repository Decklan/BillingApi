using BillingApi.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BillingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillingController : ControllerBase
    {
        private readonly ILogger<BillingController> _logger;

        public BillingController(ILogger<BillingController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Pay a bill.. cuz bills need to be paid ya know?
        /// </summary>
        /// <remarks>
        /// Sample Request
        /// POST /Billing/PayBill
        /// {
        ///     "firstName": "Joe",
        ///     "lastName": "Schmoe",
        ///     "amount": 50.00,
        ///     "accountNumber": 12345
        /// }
        /// </remarks>
        /// <param name="paymentInfo">Payment info for the payment</param>
        /// <response code="200">A successful payment was made</response>
        /// <response code="500">The payment that was attempted failed</response>
        /// <returns>Whether or not the payment was successful and a payment number</returns>
        [HttpPost]
        [Route("PayBill")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PayBill([FromBody]PaymentInformationDto paymentInfo)
        {
            return Ok(new PaymentResponseDto { Success = true, PaymentNumber = "54321" });
        }
    }
}
