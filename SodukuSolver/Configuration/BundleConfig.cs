
using System.Web.Optimization;

namespace SudukuSolver
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                       "~/lib/jquery/dist/jquery.min.js"));
        }
    }
}
