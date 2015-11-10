using ProofOfConcept.Selenium;
using ProofOfConcept.Tests.Component.TestObjects.Elements;

namespace ProofOfConcept.Tests.Component.TestObjects.Pages
{
    public class RetailSitePage : IPage
    {
        public static string Url = "https://roadshowaccess.qx.ipreo.com/retail"; //no way to switch it if we are running this on demo or prod

        [FindBy(How.LinkText,"View All Deals")]
        public HtmlButton ViewAllDealsLink;
    }

}
