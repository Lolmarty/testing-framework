using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProofOfConcept.Tests.Component.TestObjects.Pages;

namespace ProofOfConcept.Tests.Component.TestObjects.Contexts
{
    public class RetailDashboardContext : ContextBase
    {
        private RetailDashboardPage _retailDashboardPage;

        public void OpenApplication()
        {
            NavigationService.NavigateTo(RetailDashboardPage.Url);
            _retailDashboardPage = PageFactory.Create<RetailDashboardPage>();
        }

        public void VerifyRetailSitePageUrl()
        {
            Assert.IsTrue(NavigationService.PageUrlEquals(RetailDashboardPage.Url),
                string.Format("Login page URL mismatch: expected [{0}], but found [{1}].",
                RetailDashboardPage.Url, NavigationService.GetCurrentUrl()));
        }

        public void FiltersClick()
        {
            if (_retailDashboardPage == null)
            {
                _retailDashboardPage = PageFactory.Create<RetailDashboardPage>();
            }
            _retailDashboardPage.FiltersButton.Click();
            
            Assert.IsTrue(_retailDashboardPage.DealSearchFilters.StartDateField.Displayed,
                string.Format("On the page {0} missing element {1}.", _retailDashboardPage.ToString(), 
                _retailDashboardPage.DealSearchFilters.StartDateField.ToString()));
            Assert.IsTrue(_retailDashboardPage.DealSearchFilters.EndDateField.Displayed,
                string.Format("On the page {0} missing element {1}.", _retailDashboardPage.ToString(), 
                _retailDashboardPage.DealSearchFilters.EndDateField.ToString()));
            Assert.IsTrue(_retailDashboardPage.DealSearchFilters.AssetClassDropDown.Displayed,
                string.Format("On the page {0} missing element {1}.", _retailDashboardPage.ToString(), 
                _retailDashboardPage.DealSearchFilters.AssetClassDropDown.ToString()));
            Assert.IsTrue(_retailDashboardPage.DealSearchFilters.DealTypeDropDown.Displayed,
                string.Format("On the page {0} missing element {1}.", _retailDashboardPage.ToString(), 
                _retailDashboardPage.DealSearchFilters.DealTypeDropDown.ToString()));
            Assert.IsTrue(_retailDashboardPage.DealSearchFilters.IndustryTypeDropDown.Displayed,
                string.Format("On the page {0} missing element {1}.", _retailDashboardPage.ToString(), 
                _retailDashboardPage.DealSearchFilters.IndustryTypeDropDown.ToString()));
            Assert.IsTrue(_retailDashboardPage.DealSearchFilters.ResetFiltersButton.Displayed,
                string.Format("On the page {0} missing element {1}.", _retailDashboardPage.ToString(), 
                _retailDashboardPage.DealSearchFilters.ResetFiltersButton.ToString()));
        }



    }
}
