using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTemplate
{
    public class PageObject
    {
        [FindsBy(How = How.XPath, Using = "//input[@class='Select-input']")]
        public IWebElement DeparturePort;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[1]")]
        public IWebElement departureAirportfield;

        [FindsBy(How = How.XPath, Using = "//div[@title='Kaunas International Airport']")]
        public IWebElement kaunasSelection;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[2]")]
        public IWebElement arrivalAirportfield;

        [FindsBy(How = How.XPath, Using = "//div[@title='London Gatwick Airport']")]
        public IWebElement gatwickSelection;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[3]")]
        public IWebElement airlinesfield;

        [FindsBy(How = How.XPath, Using = "//div[@title='Ryanair']")]
        public IWebElement airlinesSelection;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='1234']")]
        public IWebElement flightnumberfield;

        [FindsBy(How = How.XPath, Using = "//input[@name='failedFlightNumberDigits']")]
        public IWebElement flightnumberSelection;

        [FindsBy(How = How.XPath, Using = "//input[@name='failedFlightDate']")]
        public IWebElement flightdatafield;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='1']")]
        public IWebElement dataValuefield;

        [FindsBy(How = How.XPath, Using = "//span[text()='Flight delayed']")]
        public IWebElement flightDelayaed;

        [FindsBy(How = How.XPath, Using = "//span[text()='More than 3 hours']")]
        public IWebElement MoreThan3hours;

        [FindsBy(How = How.XPath, Using = "//span[@id='react-select-6--value']")]
        public IWebElement reasonProvidedField;

        [FindsBy(How = How.XPath, Using = "//div[text()='Aircraft technical problem']")]
        public IWebElement Aircrafttechnicalproblem;

        [FindsBy(How = How.XPath, Using = "//span[@id='react-select-7--value']")]
        public IWebElement WhereDidYouHearAboutUsField;

        [FindsBy(How = How.XPath, Using = "//div[text()='Facebook']")]
        public IWebElement Facebook;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement NextStepButton;

        [FindsBy(How = How.XPath, Using = "//textarea[@name='comments']")]
        public IWebElement BrieflyDescribeSituationField;

        [FindsBy(How = How.XPath, Using = "(//input[@type='text'])[3]")]
        public IWebElement EnterFlightReservationNumberField;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement EnterTravellersDetailsButton;

        [FindsBy(How = How.XPath, Using = "(//input[@type='text'])[1]")]
        public IWebElement NameField;

        [FindsBy(How = How.XPath, Using = "(//input[@type='text'])[2]")]
        public IWebElement SurnameField;

        [FindsBy(How = How.XPath, Using = "(//input[@type='text'])[3]")]
        public IWebElement BirtgdayField;

        [FindsBy(How = How.XPath, Using = "(//td[@data-value='1980'])[1]")]
        public IWebElement DataValueField;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='4']")]
        public IWebElement DataValueMonthField;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='15']")]
        public IWebElement DataValueDayField;

        [FindsBy(How = How.XPath, Using = "(//input[@type='text'])[4]")]
        public IWebElement EmailField;

        [FindsBy(How = How.XPath, Using = "(//input[@type='text'])[5]")]
        public IWebElement Email;

        [FindsBy(How = How.XPath, Using = "//input[@name='userPhoneCode']")]
        public IWebElement phoneField;

        [FindsBy(How = How.XPath, Using = "//span[@id='react-select-9--value']//input")]
        public IWebElement phone;

        [FindsBy(How = How.XPath, Using = "//div[@title='Lithuania']")]
        public IWebElement lithuania;

        [FindsBy(How = How.XPath, Using = "//input[@type='tel']")]
        public IWebElement FillTextField;

        [FindsBy(How = How.XPath, Using = "(//input[@type='text'])[7]")]
        public IWebElement AddressField;

        [FindsBy(How = How.XPath, Using = "(//input[@type='text'])[8]")]
        public IWebElement CityField;

        [FindsBy(How = How.XPath, Using = "(//input[@type='text'])[9]")]
        public IWebElement PostcodeField;

        [FindsBy(How = How.XPath, Using = "(//div[@class='Select-placeholder'])[2]")]
        public IWebElement CountryField;

        [FindsBy(How = How.XPath, Using = "//span[@id='react-select-10--value']//input[@class='Select-input']")]
        public IWebElement Lithuania;

        [FindsBy(How = How.XPath, Using = "//div[text()='Lithuania']")]
        public IWebElement SelectLithuania;

        [FindsBy(How = How.XPath, Using = "(//div[@class='Select-placeholder'])[2]")]
        public IWebElement LanguageField;

        [FindsBy(How = How.XPath, Using = "//div[@id='react-select-11--option-5']")]
        public IWebElement Lietuvių;

        [FindsBy(How = How.XPath, Using = "//span[text()='No, I was travelling alone']")]
        public IWebElement TravellingAloneButton;

        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[4]")]
        public IWebElement AgryButton;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement FinalStepButton;

        [FindsBy(How = How.XPath, Using = "//canvas[@id='sigCanvas']")]
        public IWebElement SignatureCanvas;

        [FindsBy(How = How.XPath, Using = "//button[contains(.,'Complete claim')]")]
        public IWebElement CompleteClaimButton;

    }
}
