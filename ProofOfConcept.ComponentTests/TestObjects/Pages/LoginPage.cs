﻿using ProofOfConcept.Selenium;
using ProofOfConcept.Tests.Component.TestObjects.Elements;

namespace ProofOfConcept.Tests.Component.TestObjects.Pages
{
    public class LoginPage : IPage
    {
        public static string Url = "https://roadshowaccess.qx.ipreo.com/";

        public string LoginValue = "qainvestor@ipreo.com";
        public string PasswordValue = "Password1";

        [FindBy(How.Id, "loginForm")]
        public LoginForm LoginForm;
    }
    
    public class LoginForm : IContainer
    {
        [FindBy(How.Name, "UserName")]
        [IsDisplayed]
        public HtmlTextField LoginField;

        [FindBy(How.ClassName, "input-sm")] 
        [HasAttribute("id", "Password")] 
        public HtmlTextField PasswordField;

        [FindBy(How.TagName, "button")]
        [IsDisplayed]
        [HasAttribute("type", "submit")] 
        public HtmlButton LoginButton;

    }

    public class DealSearchFilters : IContainer
    {
        [FindBy(How.Id, "startDate")]
        public HtmlTextField StartDateField;

        [FindBy(How.Id, "endDate")]
        public HtmlTextField EndDateField;

        [FindBy(How.Id, "assetTypeId")]
        public HtmlDropDown AssetClassDropDown;

        [FindBy(How.Id, "industryID")]
        public HtmlDropDown IndustryTypeDropDown;

        [FindBy(How.Id, "dealTypeId")]
        public HtmlDropDown DealTypeDropDown;

        [FindBy(How.TagName, "button")]
        [HasAttribute("type", "reset")] 
        public HtmlButton ResetFiltersButton;
    }

    public class DealSearchField : IContainer
    {
        [FindBy(How.Name, "dealCode")]
        public HtmlTextField SearchField;

        [FindBy(How.TagName, "button")]
        public HtmlButton GoButton;

        public void SearchDeal(string dealName)
        {
            SearchField.SetText(dealName);
            GoButton.Click();
        }
    }
}
