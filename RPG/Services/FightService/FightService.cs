using RPG.Data;
using RPG.Dtos.Fight;
using RPG.Models;

namespace RPG.Services.FightService
{
	public class FightService : IFightService
	{
		private readonly DataContext _context;

		public FightService(DataContext context)
		{
			_context = context;
		}

		public Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request)
		{
			throw new NotImplementedException();
		}
	}
}
