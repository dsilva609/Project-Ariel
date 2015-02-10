using BusinessLogic.Models;
using UI.Models;

namespace UI.App_Start
{
	public static class AutoMapperConfig
	{
		public static void RegisterMappings()
		{
			AutoMapper.Mapper.CreateMap<PlayerViewModel, Player>();
			AutoMapper.Mapper.CreateMap<Player, PlayerViewModel>();
		}
	}
}