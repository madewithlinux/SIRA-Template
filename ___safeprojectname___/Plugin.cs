using IPA;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;
using ___safeprojectname___.Installers;

namespace ___safeprojectname___
{
	[NoEnableDisable, Plugin(RuntimeOptions.DynamicInit)]
	public class Plugin
	{
		[Init]
		public Plugin(IPALogger logger, Zenjector zenjector)
		{
			zenjector.UseLogger(logger);
			zenjector.Install<___safeprojectname___CoreInstaller>(Location.App);
		}
	}
}