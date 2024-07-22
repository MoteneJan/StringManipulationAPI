using Microsoft.AspNetCore.Mvc;
using StringManipulationAPI.Models;

namespace StringManipulationAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StringManipulationController : ControllerBase
    {
        private static string storedString;

        [HttpGet]
        public IActionResult Get([FromQuery] string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return BadRequest("Input string cannot be null or empty.");
            }

            var reversedString = StringUtilities.ReverseString(input);
            var isPalindrome = StringUtilities.IsPalindrome(input);

            var result = new
            {
                ReversedString = reversedString,
                IsPalindrome = isPalindrome
            };

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return BadRequest("Input string cannot be null or empty.");
            }

            storedString = input;

            var reversedString = StringUtilities.ReverseString(input);
            var isPalindrome = StringUtilities.IsPalindrome(input);

            var result = new
            {
                ReversedString = reversedString,
                IsPalindrome = isPalindrome
            };

            return CreatedAtAction(nameof(GetStoredString), new { }, result);
        }

        [HttpPut]
        public IActionResult Put([FromBody] string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return BadRequest("Input string should be null or empty.");
            }

            storedString = input;

            var reversedString = StringUtilities.ReverseString(input);
            var isPalindrome = StringUtilities.IsPalindrome(input);

            var result = new
            {
                ReversedString = reversedString,
                IsPalindrome = isPalindrome
            };

            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            storedString = null;
            return NoContent();
        }

        [HttpGet("stored")]
        public IActionResult GetStoredString()
        {
            if (string.IsNullOrEmpty(storedString))
            {
                return NotFound("No string is stored.");
            }

            var reversedString = StringUtilities.ReverseString(storedString);
            var isPalindrome = StringUtilities.IsPalindrome(storedString);

            var result = new
            {
                OriginalString = storedString,
                ReversedString = reversedString,
                IsPalindrome = isPalindrome
            };

            return Ok(result);
        }
    }
}
