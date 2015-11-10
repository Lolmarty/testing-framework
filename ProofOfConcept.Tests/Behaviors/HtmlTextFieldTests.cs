using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using OpenQA.Selenium;
using ProofOfConcept.Configuration;
using ProofOfConcept.Tests.Component.TestObjects.Contexts;
using ProofOfConcept.Tests.Component.TestObjects.Pages;

namespace ProofOfConcept.Tests.Samples.Behaviors
{
    [TestClass]
    public class HtmlTextFieldTests
    {
        private LoginContext _loginContext;
        private InvestorDashboardPage _dashboard;

        [TestInitialize]
        public void Init()
        {
            _loginContext = new LoginContext();
            _loginContext.OpenApplication();
            _loginContext.LoginToApplication();

            _dashboard = DependencyManager.Kernel.Get<IPageFactory>().Create<InvestorDashboardPage>();
        }

        [TestMethod]
        public void SetTextTest()
        {
            var textValue = "Hello, World!";
            _dashboard.DealAccessCode.SetText(textValue);

            Assert.AreEqual(textValue, ((IWebElement)_dashboard.DealAccessCode.NativeElement).GetAttribute("value"));
        }

        [TestMethod]
        public void GetTextTest()
        {
            Assert.AreEqual(_dashboard.DealAccessCode.GetText(), ((IWebElement)_dashboard.DealAccessCode.NativeElement).GetAttribute("value"));
        }

        [TestMethod]
        public void AppendTextTest()
        {
            var textValue1 = "Hello";
            var textValue2 = ", World!";

            _dashboard.DealAccessCode.AppendText(textValue1);
            StringAssert.EndsWith(textValue1, _dashboard.DealAccessCode.GetText());

            _dashboard.DealAccessCode.AppendText(textValue2);
            StringAssert.EndsWith(_dashboard.DealAccessCode.GetText(), string.Format("{0}{1}", textValue1, textValue2));
        }

        [TestMethod]
        public void ClearTest()
        {
            var textValue = "Hello, World!";
            _dashboard.DealAccessCode.SetText(textValue);

            Assert.AreEqual(textValue, _dashboard.DealAccessCode.GetText());

            _dashboard.DealAccessCode.Clear();
            Assert.IsTrue(string.IsNullOrEmpty(_dashboard.DealAccessCode.GetText()));
        }
    }
}