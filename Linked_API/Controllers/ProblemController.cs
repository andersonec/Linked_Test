using Linked_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Linked_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProblemController : ControllerBase
    {
        private readonly ProblemService _problemService;

        public ProblemController(ProblemService problemService)
        {
            _problemService = problemService;
        }


        [HttpPost("ProblemA")]
        public ActionResult ProblemA(int Width, int Length)
        {
            if (Width == 0 || Length == 0)
                return BadRequest("Width and Length must be more than 0.");

            var result = _problemService.ProblemA(Width, Length);
            if (result > 0)
                return Ok(result);

            return BadRequest();
        }

        [HttpPost("ProblemB")]
        public ActionResult Get(ProblemBModel model)
        {
            var result = _problemService.ProblemB(model.N, model.H, model.Input);

            if (result > 0)
                return Ok(result);

            return BadRequest();
        }

        [HttpPost("ProblemC")]
        public ActionResult Get(ProblemCModel model)
        {
            var result = _problemService.ProblemC(model.N, model.rows);

            if (result.Any())
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("ProblemD")]
        public ActionResult Get(ProblemDModel model)
        {
            var result = _problemService.ProblemD(model.N, model.Start, model.Arrival);

            if (result > 0)
                return Ok(result);

            return BadRequest();
        }

        [HttpPost("ProblemE/{N}")]
        public ActionResult Get(int N)
        {
            if (N < 1 && N > 1018)
                return BadRequest("N must be in range 1 to 1018.");

            var result = _problemService.ProblemE(N);

            if (result > 0)
                return Ok(result);

            return BadRequest();
        }
    }
}
