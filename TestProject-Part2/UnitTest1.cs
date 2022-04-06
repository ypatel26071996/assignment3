using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject_Part2
{
    public class Tests
    {
        IWebDriver webDriver;
        [OneTimeSetUp]
        public void StartChrome()
        {
            webDriver = new ChromeDriver(".");
        }

        [Test]
        public void Test1()
        {
            string expected = "*Required";
            webDriver.Url= "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='fname']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("fname_status"));
            firstNameTextBox.SendKeys("");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreEqual(expected, status);
        }
        [Test]
        public void Test2()
        {
            string expected = "*Required";
            webDriver.Url = "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='lname']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("lname_status"));
            firstNameTextBox.SendKeys("");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreEqual(expected, status);
        }
        [Test]
        public void Test3()
        {
            string expected = "*Required";
            webDriver.Url = "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='address']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("address_status"));
            firstNameTextBox.SendKeys("");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreEqual(expected, status);
        }
        [Test]
        public void Test4()
        {
            string expected = "";
            webDriver.Url = "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='city']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("city_status"));
            firstNameTextBox.SendKeys("Toronto");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreEqual(expected, status);
        }
        [Test]
        public void Test5()
        {
            string expected = "";
            webDriver.Url = "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='province']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("province_status"));
            firstNameTextBox.SendKeys("Winterfell");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreEqual(expected, status);
        }
        [Test]
        public void Test6()
        {
            string expected = "*Required";
            webDriver.Url = "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='postalcode']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("postal_status"));
            firstNameTextBox.SendKeys("");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreNotEqual(expected, status);
        }
        [Test]
        public void Test7()
        {
            string expected = "*Required";
            webDriver.Url = "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='phone']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("phone_status"));
            firstNameTextBox.SendKeys("");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreNotEqual(expected, status);
        }
        [Test]
        public void Test8()
        {
            string expected = "*incorrect format";
            webDriver.Url = "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='phone']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("phone_status"));
            firstNameTextBox.SendKeys("1234");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreNotEqual(expected, status);
        }
        [Test]
        public void Test9()
        {
            string expected = "*Incorrect format";
            webDriver.Url = "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='postalcode']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("postal_status"));
            firstNameTextBox.SendKeys("12w");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreEqual(expected, status);
        }
        [Test]
        public void Test10()
        {
            string expected = "*Required";
            webDriver.Url = "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='email']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("email_status"));
            firstNameTextBox.SendKeys("1234");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreNotEqual(expected, status);
        }
        [Test]
        public void Test11()
        {
            string expected = "";
            webDriver.Url = "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='make']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("make_status"));
            firstNameTextBox.SendKeys("Subaru");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreEqual(expected, status);
        }
        [Test]
        public void Test12()
        {
            string expected = "";
            webDriver.Url = "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='model']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("model_status"));
            firstNameTextBox.SendKeys("Impreza");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreEqual(expected, status);
        }
        [Test]
        public void Test13()
        {
            string expected = "*Required";
            webDriver.Url = "http://localhost/part2/add.html";
            IWebElement firstNameTextBox = webDriver.FindElement(By.XPath(".//*[@id='year']"));
            IWebElement submitButton = webDriver.FindElement(By.XPath(".//*[@id='add_btn']"));
            IWebElement spanFnameStatus = webDriver.FindElement(By.Id("year_status"));
            firstNameTextBox.SendKeys("");
            submitButton.Click();
            string status = spanFnameStatus.Text;
            Assert.AreEqual(expected, status);
        }


        [OneTimeTearDown]
        public void CloseTest()
        {
            
            webDriver.Dispose();
        }
    }
}