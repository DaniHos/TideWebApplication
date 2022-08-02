using System;
using TechTalk.SpecFlow;
using TideWebApplication.CommonMethod;

namespace TideWebApplication.stepFile
{
    [Binding]
    public class TideWebApplicationSteps
    {
        CommonMethods obj = new CommonMethods();
        [Given(@"Load the given Tide Website")]
        public void GivenLoadTheGivenTideWebsite()
        {
            obj.OpenURL();
            
        }
        
        [When(@"you click on Register Button at top")]
        public void WhenYouClickOnRegisterButtonAtTop()
        {
            obj.ClickOn();
        }
        
        [When(@"Click on sign up button a new tab Should open")]
        public void WhenClickOnSignUpButtonANewTabShouldOpen()
        {
            obj.SignUpclick();
        }

        [When(@"Enter FirstName,Email Adress,Password")]
        public void WhenEnterFirstNameEmailAdressPassword()
        {
            obj.SendKeys();
        }

        [Then(@"click on create account button and you are Regitered\.")]
        public void ThenClickOnCreateAccountButtonAndYouAreRegitered_()
        {
            obj.Createaccount();
            obj.scr("Register");
        }

        [Given(@"Load the Website")]
        public void GivenLoadTheWebsite()
        {
            obj.OpenURL1();
        }

        [When(@"we click on Contact us button contact page displays")]
        public void WhenWeClickOnContactUsButtonContactPageDisplays()
        {
            obj.ContactUs();
        }

        [When(@"we should click on How can i get tide coupons")]
        public void WhenWeShouldClickOnHowCanIGetTideCoupons()
        {
            obj.Coupons();
        }

        [Then(@"it should diplay the  page")]
        public void ThenItShouldDiplayThePage()
        {
            obj.Verify();
            obj.scr("ContactUs");
        }

        [Given(@"Load the Website given")]
        public void GivenLoadTheWebsiteGiven()
        {
            obj.OpenURL3();
        }

        [When(@"we Click on Live chat button")]
        public void WhenWeClickOnLiveChatButton()
        {
            obj.Livechat();
        }

        [When(@"Click on ChatNow button")]
        public void WhenClickOnChatNowButton()
        {
            obj.ChatNow();
        }

        [Then(@"it should take us to the support page")]
        public void ThenItShouldTakeUsToTheSupportPage()
        {
            obj.Support();
            obj.scr("LiveChat");
        }

        [Given(@"Open the website")]
        public void GivenOpenTheWebsite()
        {
            obj.OpenURL4();
        }

        [When(@"i move the cursor to shop products it should display products")]
        public void WhenIMoveTheCursorToShopProductsItShouldDisplayProducts()
        {
            obj.Shopproducts();
        }

        [When(@"click on Packs and its should show products")]
        public void WhenClickOnPacksAndItsShouldShowProducts()
        {
            obj.Packs();
        }

        [When(@"select product to buy and click on find retailers")]
        public void WhenSelectProductToBuyAndClickOnFindRetailers()
        {
            obj.Findretailers();
        }

        [Then(@"click the option Buy")]
        public void ThenClickTheOptionBuy()
        {
            obj.Buy();
            obj.scr("BuyProducts");
        }

        [Given(@"Open website")]
        public void GivenOpenWebsite()
        {
            obj.OpenURL5();
        }

        [When(@"i click on Us-English bar at top page should open")]
        public void WhenIClickOnUs_EnglishBarAtTopPageShouldOpen()
        {
            obj.Changelanguage();
        }

        [Then(@"Click on suitable language and changes should be applied")]
        public void ThenClickOnSuitableLanguageAndChangesShouldBeApplied()
        {
            obj.Selectlanguage();
            obj.scr("Changelanguage");
        }


        [Given(@"open the given tide webpage")]
        public void GivenOpenTheGivenTideWebpage()
        {
            obj.OpenURL6();
        }

        [When(@"i click on search bar and type Tidepowder page should open")]
        public void WhenIClickOnSearchBarAndTypeTidepowderPageShouldOpen()
        {
            obj.Searchbar();
        }

        [When(@"click on News and articles")]
        public void WhenClickOnNewsAndArticles()
        {
            obj.ClickNews();
        }

        [Then(@"Page will open and Click on readmore")]
        public void ThenPageWillOpenAndClickOnReadmore()
        {
            obj.Readmore();
            obj.scr("searchbar");
            
        }

        [Given(@"open webpage")]
        public void GivenOpenWebpage()
        {
            obj.OpenURL7();
        }

        [When(@"i click on Language bar at top")]
        public void WhenIClickOnLanguageBarAtTop()
        {
            obj.Changelanguage1();
        }

        [Then(@"click on Us-Spanish and changes should be done")]
        public void ThenClickOnUs_SpanishAndChangesShouldBeDone()
        {
            obj.Selectlanguage1();
            obj.scr("Changelanguage1");
        }

        [Given(@"Open the webpage")]
        public void GivenOpenTheWebpage()
        {
            obj.OpenURL8();
        }

        [When(@"i click language change bar at top")]
        public void WhenIClickLanguageChangeBarAtTop()
        {
            obj.Changelanguage2();
        }

        [Then(@"click on Canada-French and change is done")]
        public void ThenClickOnCanada_FrenchAndChangeIsDone()
        {
            obj.Selectlanguage2();
            obj.scr("Changelanguage2");
        }

        [Given(@"Open the given webpage")]
        public void GivenOpenTheGivenWebpage()
        {
            obj.OpenURL9();
        }

        [When(@"i click on  Register page should open")]
        public void WhenIClickOnRegisterPageShouldOpen()
        {
            obj.ClickOn1();
        }

        [When(@"i should click on Signup")]
        public void WhenIShouldClickOnSignup()
        {
            obj.SignUpclick1();
        }

        [When(@"a new tab should open click on Login")]
        public void WhenANewTabShouldOpenClickOnLogin()
        {
            obj.Login();
        }

        [When(@"Enter Email and password")]
        public void WhenEnterEmailAndPassword()
        {
            obj.EnterParticular();
        }

        [Then(@"click on Login")]
        public void ThenClickOnLogin()
        {
            obj.Login1();
            obj.scr("Login");
        }















    }

}
