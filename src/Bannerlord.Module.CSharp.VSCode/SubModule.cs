using TaleWorlds.MountAndBlade;

#if( AddBLSELoadingInterceptor )
namespace Bannerlord.BUTRLoader
{
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public sealed class BLSEInterceptorAttribute : System.Attribute { }
}
#endif

namespace BLNamespace
{
#if( AddBLSELoadingInterceptor )
    [Bannerlord.BUTRLoader.BLSEInterceptor]
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