using IPA;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;

namespace $safeprojectname$
{
	[Plugin(RuntimeOptions.DynamicInit)]
	public class Plugin
	{
		[Init]
		public Plugin(IPALogger logger, Zenjector zenjector)
		{
			zenjector.UseLogger(logger);
			zenjector.Install<$safeprojectname$CoreInstaller>(Location.App);
		}
	}
}