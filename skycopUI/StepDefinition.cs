using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;


namespace SeleniumTemplate
{
    [Binding]
    public class StepDefinition
    {
        private PageObject _pageObject;
        public PageObject PageObject => _pageObject ?? (_pageObject = new PageObject());
        public static IWebDriver Driver;
        public class Browser

        {
            public IWebDriver Chrome;

            public Browser()
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                Chrome = new ChromeDriver(options);
            }
        }

        public StepDefinition(Browser browser)
        {
            Driver = browser.Chrome;
            PageFactory.InitElements(Driver, PageObject);
        }
        [Given(@"I Open Google homepage")]
        public void GivenIOpenSkycopClaimPage()
        {
            Driver.Url = "https://www.google.com/";
        }
        [Given(@"I navigate to claim")]
        public void GivenINavigateToClaims()
        {
            Driver.Url = "https://claim.skycop.com/";
        }
        [Then(@"I set Kaunas as Departure airport")]
        public void ThenISetKaunasAsDepartureAirport()
        {
            Hooks.WaitIsDisplayed(PageObject.departureAirportfield);
            PageObject.departureAirportfield.SendKeys(Constants.City);
            Hooks.WaitIsDisplayed(PageObject.kaunasSelection);
            PageObject.kaunasSelection.Click();
        }

        [Then(@"I set London Gatwick as arrival airport")]
        public void ThenISetLondonGatwickAsArrivalAirport()
        {
            Hooks.WaitIsDisplayed(PageObject.arrivalAirportfield);
            PageObject.arrivalAirportfield.SendKeys(Constants.City2);
            Hooks.WaitIsDisplayed(PageObject.gatwickSelection);
            PageObject.gatwickSelection.Click();
        }

        [Then(@"I choose airlines")]
        public void ThenIChooseAirlines()
        {
            Hooks.WaitIsDisplayed(PageObject.airlinesfield);
            PageObject.airlinesfield.SendKeys(Constants.Airlines);
            Hooks.WaitIsDisplayed(PageObject.airlinesSelection);
            PageObject.airlinesSelection.Click();
        }

        [Then(@"I set (.*) as Flight number")]
        public void ThenISetAsFlightNumber(int p0)
        {
            var rnd = new Random();
            Hooks.WaitIsDisplayed(PageObject.flightnumberfield);
            PageObject.flightnumberfield.SendKeys(rnd.Next(1000, 9999).ToString());
            Hooks.WaitIsDisplayed(PageObject.flightnumberSelection);
            PageObject.flightnumberSelection.Click();
        }

        [Then(@"I set flight data")]
        public void ThenISetFlightData()
        {
            Hooks.WaitIsDisplayed(PageObject.flightdatafield);
            PageObject.flightdatafield.Click();
            Hooks.WaitIsDisplayed(PageObject.dataValuefield);
            PageObject.dataValuefield.Click();
        }

        [Then(@"I choose Flight delayed as the problem of the flight you encountered")]
        public void ThenIChooseFlightDelayedAsTheProblemOfTheFlightYouEncountered()
        {
            Hooks.WaitIsDisplayed(PageObject.flightDelayaed);
            PageObject.flightDelayaed.Click();
        }

        [Then(@"I choose More than (.*) hours as How long were you delayed to reach the final airport\?")]
        public void ThenIChooseMoreThanHoursAsHowLongWereYouDelayedToReachTheFinalAirport(int p0)
        {
            Hooks.WaitIsDisplayed(PageObject.MoreThan3hours);
            PageObject.MoreThan3hours.Click();
        }

        [Then(@"I choose what was the reason provided by airlines")]
        public void ThenIChooseWhatWasTheReasonProvidedByAirlines()
        {
            Hooks.WaitIsDisplayed(PageObject.reasonProvidedField);
            PageObject.reasonProvidedField.Click();
            Hooks.WaitIsDisplayed(PageObject.Aircrafttechnicalproblem);
            PageObject.Aircrafttechnicalproblem.Click();
        }

        [Then(@"I choose Where did you hear about us\?")]
        public void ThenIChooseWhereDidYouHearAboutUs()
        {
            Hooks.WaitIsDisplayed(PageObject.WhereDidYouHearAboutUsField);
            PageObject.WhereDidYouHearAboutUsField.Click();
            Hooks.WaitIsDisplayed(PageObject.Facebook);
            PageObject.Facebook.Click();
        }

        [Then(@"I push the button Next step")]
        public void ThenIPushTheButtonNextStep()
        {
            Hooks.WaitIsDisplayed(PageObject.NextStepButton);
            PageObject.NextStepButton.Click();
        }

        [Then(@"I Briefly describe situation")]
        public void ThenIBrieflyDescribeSituation()
        {
            Hooks.WaitIsDisplayed(PageObject.BrieflyDescribeSituationField);
            PageObject.BrieflyDescribeSituationField.SendKeys(Constants.BrieflyDescribeSituation);
        }

        [Then(@"I Enter flight reservation number")]
        public void ThenIEnterFlightReservationNumber()
        {
            Hooks.WaitIsDisplayed(PageObject.EnterFlightReservationNumberField);
            PageObject.EnterFlightReservationNumberField.SendKeys(Constants.FlightReservationNumber);
        }

        [Then(@"I push the button Enter travellers details")]
        public void ThenIPushTheButtonEnterTravellersDetails()
        {
            Hooks.WaitIsDisplayed(PageObject.EnterTravellersDetailsButton);
            PageObject.EnterTravellersDetailsButton.Click();
        }

        [Then(@"I write my Name")]
        public void ThenIWriteMyName()
        {
            Hooks.WaitIsDisplayed(PageObject.NameField);
            PageObject.NameField.SendKeys(Constants.Name);
        }

        [Then(@"I write my Surname")]
        public void ThenIWriteMySurname()
        {
            Hooks.WaitIsDisplayed(PageObject.SurnameField);
            PageObject.SurnameField.SendKeys(Constants.Surname);
        }

        [Then(@"I set my Birthdate")]
        public void ThenISetMyBirthdate()
        {
            Hooks.WaitIsDisplayed(PageObject.BirtgdayField);
            PageObject.BirtgdayField.Click();
            Hooks.WaitIsDisplayed(PageObject.DataValueField);
            PageObject.DataValueField.Click();
            Hooks.WaitIsDisplayed(PageObject.DataValueMonthField);
            PageObject.DataValueMonthField.Click();
            Hooks.WaitIsDisplayed(PageObject.DataValueDayField);
            PageObject.DataValueDayField.Click();
        }

        [Then(@"I write my Email")]
        public void ThenIWriteMyEmail()
        {
            
            Hooks.WaitIsDisplayed(PageObject.EmailField);
            PageObject.EmailField.SendKeys(Constants.Email);
        }

        [Then(@"I repeat my Email")]
        public void ThenIRepeatMyEmail()
        {
            Thread.Sleep(2000);
            PageObject.Email.SendKeys(Constants.Email);
        }

        [Then(@"I set user phone")]
        public void ThenISetUserPhone()
        {
            Hooks.WaitIsDisplayed(PageObject.phoneField);
            PageObject.phoneField.Click();
            Hooks.WaitIsDisplayed(PageObject.phone);
            PageObject.phone.SendKeys(Constants.Country);
            Hooks.WaitIsDisplayed(PageObject.lithuania);
            PageObject.lithuania.Click();
            Hooks.WaitIsDisplayed(PageObject.FillTextField);
            PageObject.FillTextField.SendKeys(Constants.PhoneNumber);           
        }

        [Then(@"I set Address")]
        public void ThenISetAddress()
        {
            Hooks.WaitIsDisplayed(PageObject.AddressField);
            PageObject.AddressField.SendKeys(Constants.Adress);            
        }

        [Then(@"I set City")]
        public void ThenISetCity()
        {
            Hooks.WaitIsDisplayed(PageObject.CityField);
            PageObject.CityField.SendKeys(Constants.City3);
        }

        [Then(@"I set Postcode")]
        public void ThenISetPostcode()
        {
            Thread.Sleep(2000);
            PageObject.PostcodeField.SendKeys(Constants.PostCode);           
        }

        [Then(@"I choose Country")]
        public void ThenIChooseCountry()
        {
            Hooks.WaitIsDisplayed(PageObject.CountryField);
            PageObject.CountryField.Click();
            Hooks.WaitIsDisplayed(PageObject.Lithuania);
            PageObject.Lithuania.SendKeys(Constants.Country2);
            Hooks.WaitIsDisplayed(PageObject.SelectLithuania);
            PageObject.SelectLithuania.Click();            
        }

        [Then(@"I choose Language")]
        public void ThenIChooseLanguage()
        {
            Hooks.WaitIsDisplayed(PageObject.LanguageField);
            PageObject.LanguageField.Click();
            Hooks.WaitIsDisplayed(PageObject.Lietuvių);
            PageObject.Lietuvių.Click();           
        }

        [Then(@"I push the button No, I was travelling alone")]
        public void ThenIPushTheButtonNoIWasTravellingAlone()
        {
            Hooks.WaitIsDisplayed(PageObject.TravellingAloneButton);
            PageObject.TravellingAloneButton.Click();           
        }

        [Then(@"I click the button I have read and agree to the Terms of sevice and Privacy policy")]
        public void ThenIClickTheButtonIHaveReadAndAgreeToTheTermsOfSeviceAndPrivacyPolicy()
        {
            Hooks.WaitIsDisplayed(PageObject.AgryButton);
            PageObject.AgryButton.Click();           
        }

        [Then(@"I puch the button Final Step")]
        public void ThenIPuchTheButtonFinalStep()
        {
            Hooks.WaitIsDisplayed(PageObject.FinalStepButton);
            PageObject.FinalStepButton.Click();
        }

        [Then(@"I sign The assignment form")]
        public void ThenISignTheAssignmentForm()
        {
            //Actions builder = new Actions(Driver);
            //IAction drawAction = builder.MoveToElement(PageObject.SignatureCanvas, 10, 10)
            //.ClickAndHold()
            //.MoveByOffset(50, 50)
            //.Release()
            //.Build();
            //drawAction.Perform();
            Thread.Sleep(3000);
            Actions builder = new Actions(Driver);
            IAction drawAction = builder.MoveToElement(PageObject.SignatureCanvas, 10, 10)
                .ClickAndHold()
                .MoveByOffset(50, 50)
                .Release()
                .Build();
            drawAction.Perform();
            Thread.Sleep(500);
            IAction drawAction1 = builder.MoveToElement(PageObject.SignatureCanvas, 30, 15)
                .ClickAndHold()
                .MoveByOffset(50, 60)
                .Release()
                .Build();
            drawAction1.Perform();
            Thread.Sleep(500);
            IAction drawAction2 = builder.MoveToElement(PageObject.SignatureCanvas, 80, 20)
                .ClickAndHold()
                .MoveByOffset(50, 70)
                .Release()
                .Build();
            drawAction2.Perform();
            //Hooks.WaitIsDisplayed(PageObject.CompleteClaimButton, click: true);

        }
        [Then(@"I push the button Complete claim")]
        public void ThenIPushTheButtonCompleteClaim()
        {
            Hooks.WaitIsDisplayed(PageObject.CompleteClaimButton);
            PageObject.CompleteClaimButton.Click();
        }

    }
}



  