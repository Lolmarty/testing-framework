﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProofOfConcept.ComponentTests.TestObjects.Contexts;
using ProofOfConcept.ComponentTests.TestObjects.Elements;
using ProofOfConcept.ComponentTests.TestTemplates;

namespace ProofOfConcept.ComponentTests.ElementBehaviorTests
{
    [TestClass]
    public class HtmlCheckBoxTests : UiTestDriverSharedBetweenTests
    {
        private LoginContext _loginContext;
        //private DisclaimerPage _disclaimerPage;
        private HtmlCheckBox _disclaimerCheckBox;

        private const string CHECKBOX_LABEL = @"I acknowledge that I have read the disclaimer";

        //[TestInitialize]
        //public void Init()
        //{
        //    _loginContext = new LoginContext();
        //    _loginContext.OpenApplication();
        //    _loginContext.LoginToApplication();

        //    //_disclaimerPage = DependencyManager.Kernel.Get<IPageFactory>().Create<DisclaimerPage>();
        //    //_disclaimerCheckBox = _disclaimerPage.DisclaimerCheckBox;
        //}

        //[TestMethod]
        //public void CheckTest()
        //{
        //    _disclaimerCheckBox.Check();

        //    Assert.IsTrue(((IWebElement)_disclaimerCheckBox.NativeElement).Selected);
        //}

        //[TestMethod]
        //public void UncheckTest()
        //{
        //    _disclaimerCheckBox.Uncheck();

        //    Assert.IsFalse(((IWebElement)_disclaimerCheckBox.NativeElement).Selected);
        //}

        //[TestMethod]
        //public void IsCheckedTest()
        //{
        //    Assert.Equals(_disclaimerCheckBox.IsChecked(), ((IWebElement)_disclaimerCheckBox.NativeElement).Selected);
        //}

        //[TestMethod]
        //public void GetTextTest()
        //{
        //    Assert.Equals(_disclaimerCheckBox.GetText().Trim(), CHECKBOX_LABEL);
        //}
    }
}