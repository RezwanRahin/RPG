using RPG.Dtos.Fight;
using RPG.Models;

namespace RPG.Services.FightService
{
	public interface IFightService
	{
		Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
	}
}
