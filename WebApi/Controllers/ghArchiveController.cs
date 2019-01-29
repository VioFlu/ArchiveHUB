using ghContract;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApi.Controllers
{
    [Route("api/ghArchive")]
    public class ghArchiveController : Controller
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public ghArchiveController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAllghArchives()
        {
            try
            {
                var gharchives = _repository.gharchive.GetAllghArchives();

                _logger.LogInfo($"Returned all owners from database.");

                return Ok(gharchives);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllOwners action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}