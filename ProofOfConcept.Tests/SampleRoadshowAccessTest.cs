﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProofOfConcept.ComponentTests.TestObjects.Contexts;
using ProofOfConcept.ComponentTests.TestTemplates;

namespace ProofOfConcept.Samples
{
    [TestClass]
    public class SampleRoadshowAccessTest : UiTestDriverClosedBetweenTests
    {
        private LoginContext _loginContext;
        private InvestorContext _investorContext;
        
        [TestInitialize]
        public void InitContext()
        {
            _loginContext = new LoginContext();
            _investorContext = new InvestorContext();
        }

        [TestMethod]
        public void TestOpensRoadshowAccessWebsite()
        {
            _loginContext.OpenApplication();
            _loginContext.VerifyLoginPageUrl();
        }

        [TestMethod]
        public void TestLogsInAsInvestor()
        {
            _loginContext.OpenApplication();
            _loginContext.LoginToApplication();
            _investorContext.VerifyLandingPageUrl();
        }

        [TestMethod]
        public void TestSelectsDealTypeOnInvestorDashboard()
        {
            _loginContext.OpenApplication();
            _loginContext.LoginToApplication();
            _investorContext.SelectDealTypeOnInvestorDashboardPage("All Deals");
        }
    }
}
