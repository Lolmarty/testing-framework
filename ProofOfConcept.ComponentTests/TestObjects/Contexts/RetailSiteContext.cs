using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProofOfConcept.Tests.Component.TestObjects.Pages;

namespace ProofOfConcept.Tests.Component.TestObjects.Contexts
{
    public class RetailSiteContext : ContextBase
    {
        private RetailSitePage _retailSitePage;

        public void OpenApplication()
        {
            NavigationService.NavigateTo(RetailSitePage.Url);
            _retailSitePage = PageFactory.Create<RetailSitePage>();
        }

        public void VerifyRetailSitePageUrl()
        {
            Assert.IsTrue(NavigationService.PageUrlEquals(RetailSitePage.Url),
                string.Format("Login page URL mismatch: expected [{0}], but found [{1}].",
                RetailSitePage.Url, NavigationService.GetCurrentUrl()));
        }

        public void ViewAllDeals()
        {
            _retailSitePage.ViewAllDealsLink.Click();
        }
    }
}
