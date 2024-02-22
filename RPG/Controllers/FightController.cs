using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RPG.Dtos.Fight;
using RPG.Models;
using RPG.Services.FightService;

namespace RPG.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FightController : ControllerBase
	{
		private readonly IFightService _fightService;

		public FightController(IFightService fightService)
		{
			_fightService = fightService;
		}

		[HttpPost("Weapon")]
		public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
		{
			return Ok(await _fightService.WeaponAttack(request));
		}

		[HttpPost("Skill")]
		public async Task<ActionResult<ServiceResponse<AttackResultDto>>> SkillAttack(SkillAttackDto request)
		{
			return Ok(await _fightService.SkillAttack(request));
		}

		[HttpPost]
		public async Task<ActionResult<ServiceResponse<FightResultDto>>> Fight(FightRequestDto request)
		{
			return Ok(await _fightService.Fight(request));
		}

		[HttpGet]
		public async Task<ActionResult<ServiceResponse<List<HighscoreDto>>>> GetHighscore()
		{
			return Ok(await _fightService.GetHighscore());
		}
	}
}
