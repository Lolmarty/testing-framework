using ProofOfConcept.Selenium;
using ProofOfConcept.Tests.Component.TestObjects.Elements;

namespace ProofOfConcept.Tests.Component.TestObjects.Pages
{
    public class RetailDashboardPage: IPage
    {
        public static string Url = "https://roadshowaccess.qx.ipreo.com/Deal";

        [FindBy(How.ClassName, "input-group")]
        public DealSearchField DealSearchField;

        [FindBy(How.Id, "filter-button")]
        public HtmlButton FiltersButton;

        [FindBy(How.Id, "filter-tray")]
        public DealSearchFilters DealSearchFilters;

        //[FindBy(How.ClassName, "table-responsive")]
        //public HtmlTable DealTable;
    }
}
