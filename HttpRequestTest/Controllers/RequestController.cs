using AutoMapper;
using HttpRequestExamples.Dtos;
using HttpRequestExamples.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Text.RegularExpressions;

namespace HttpRequestExamples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RequestController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly Interfaces.IHttpClientFactory _httpClientFactory;
        private readonly ILogger<RequestController> _logger;

        public RequestController(IMapper mapper,
            ILogger<RequestController> logger,
            Interfaces.IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _mapper = mapper;
            _httpClientFactory = httpClientFactory;
        }


        [HttpGet("GetAddressData")]
        public async Task<IActionResult> GetAddressData(string address)
        {
            try
            {
                var content = await _httpClientFactory.GetContent(address);
                if (content == null)
                {
                    _logger.LogError($"Error content ${content}");
                }

                return Ok(_mapper.Map<AddressDto>(content));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error while standardizing address: {address}");
                return StatusCode(500, ex.Message);
            }
        }
    }
}