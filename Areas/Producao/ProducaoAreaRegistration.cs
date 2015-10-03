using System.Web.Mvc;
using System.Web.Optimization;

namespace WebApplication2.Areas.Producao
{
    public class ProducaoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Producao";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Producao_default",
                "Producao/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );            

            // Bundle por controller
            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/Producao/Home")
                .Include( BundleConfig.bundleBootstrap.ToArray() )               
                .Include("~/Areas/Producao/Scripts/Home.js"));

            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/Producao/OutroTeste").Include(
                      "~/Areas/Producao/Scripts/OutroTeste.js"));
        }
    }
}