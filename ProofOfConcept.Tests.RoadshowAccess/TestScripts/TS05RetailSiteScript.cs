using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProofOfConcept.Tests.Component.TestObjects.Contexts;
using ProofOfConcept.Tests.Component.TestTemplates;

namespace ProofOfConcept.Tests.RoadshowAccess
{
    [TestClass]
    public class TS05RetailSiteScript : UiTestDriverClosedBetweenTests
    {
        private RetailSiteContext _retailSiteContext;
        private RetailDashboardContext _retailDashboardContext;

        [ClassInitialize]
        public static void SetupDriver(TestContext context)
        {
            CloseDriverBetweenSessions();
        }

        [TestInitialize]
        public void InitContext()
        {
            _retailSiteContext = new RetailSiteContext();
            _retailDashboardContext = new RetailDashboardContext();
        }

        [TestMethod]
        public void TestRetailSite()
        {
            _retailSiteContext.OpenApplication();
            _retailSiteContext.ViewAllDeals();
            _retailDashboardContext.VerifyRetailSitePageUrl();
            _retailDashboardContext.FiltersClick();
        }

    }
}
