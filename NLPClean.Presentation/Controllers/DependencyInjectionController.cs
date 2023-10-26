using Microsoft.AspNetCore.Mvc;
using NLPCleanArchitecture.Application;
using NLPWithCleanArhitecture.Domain.DataModel;

namespace NLPClean.Presentation.Controllers
{
    [Route("Dependency/[Controller]")]
    [ApiController]
    public class DependencyInjectionController : ControllerBase
    {
        private readonly IDependencyInjectionService _dependencyInjectionService;
        public DependencyInjectionController(IDependencyInjectionService dependencyInjectionService)
        {
            _dependencyInjectionService = dependencyInjectionService;
        }


        [HttpGet]
        [Route("setPosCounter")]
        public async Task<IActionResult> setPosCounter(long AccountId, long BranchId)
        {
            return Ok(await _dependencyInjectionService.setPosCounter(AccountId, BranchId));
        }


        [HttpGet]
        [Route("GetAllPOSCounter")]
        public async Task<IActionResult> GetAllPOSCounter()
        {
            return Ok(await _dependencyInjectionService.GetAllPOSCounter());
        }


        [HttpGet]
        [Route("setAndGetPosCounter")]
        public async Task<IActionResult> setAndGetPosCounter(long AccountId, long BranchId)
        {
            return Ok(await _dependencyInjectionService.setAndGetPosCounter(AccountId, BranchId));
        }
    }
}
