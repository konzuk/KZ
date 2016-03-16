using System.ComponentModel;

namespace LoanProject
{
    //Recommended code for design-time skin initialization. 
    //In Visual Studio 2012 and newer versions of Visual Studio, to ensure that your custom skin assembly is loaded and that the custom skin is registered at design time, please add the following code to your project. 
    public class SkinRegistration : Component
    {
        public SkinRegistration()
        {
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.KZSkinOffice).Assembly);
        }
    }
}