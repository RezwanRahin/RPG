using RPG.Dtos.Fight;
using RPG.Models;

namespace RPG.Services.FightService
{
	public class FightService : IFightService
	{
		public Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request)
		{
			throw new NotImplementedException();
		}
	}
}
