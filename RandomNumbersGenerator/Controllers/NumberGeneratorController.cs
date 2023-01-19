using Library;
using Microsoft.AspNetCore.Mvc;

namespace RandomNumbersGenerator.Controllers
{
  [ApiController]
  public class NumberGeneratorController : ControllerBase
  {
    private readonly ILogger<NumberGeneratorController> _logger;
    private INumberGenerator _numberGeneratorService;

    public NumberGeneratorController(ILogger<NumberGeneratorController> logger, INumberGenerator numberGeneratorService)
    {
      _logger = logger;
      _numberGeneratorService = numberGeneratorService;
    }

    [HttpGet]
    [Route("randomize")]
    public List<int> GetRandomNumbersList()
    {
      return _numberGeneratorService.GenerateRandomSequence(1,10000);
    }
  }
}