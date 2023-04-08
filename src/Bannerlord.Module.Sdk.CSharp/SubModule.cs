using TaleWorlds.MountAndBlade;

#if( AddBLSELoadingInterceptor )
namespace Bannerlord.BUTRLoader
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class BLSEInterceptorAttribute : Attribute { }
}
#endif

namespace BLNamespace
{
#if( AddBLSELoadingInterceptor )
    [BLSEInterceptor]
    public static class BLSELoadingInterceptor
    {
        public static void OnInitializeSubModulesPrefix()
        {

        }
        public static void OnLoadSubModulesPostfix()
        {

        }
    }
    
#endif
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();

        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();

        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();

        }
    }
}