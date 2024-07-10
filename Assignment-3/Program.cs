using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class LinkedInAutomation
{
    static void Main(string[] args)
    {
        // Replace with your LinkedIn credentials
        string username = "prasad170499@gmail.com";
        string password = "Prasad@898";
        string targetUser = "https://www.linkedin.com/in/palminder-kaur-7206511a5/";

        // Setting up the Chrome driver
        IWebDriver driver = new ChromeDriver();
        Thread.Sleep(2000);

        // Navigating to LinkedIn login page
        driver.Navigate().GoToUrl("https://www.linkedin.com/login");
        Thread.Sleep(5000);

        // Logging into LinkedIn
        IWebElement usernameField = driver.FindElement(By.Id("username"));
        IWebElement passwordField = driver.FindElement(By.Id("password"));
        IWebElement loginButton = driver.FindElement(By.XPath("//button[@type='submit']"));

        usernameField.SendKeys(username);
        passwordField.SendKeys(password);
        loginButton.Click();

        // Waiting for the home page to load
        Thread.Sleep(5000);

        // Navigating to the target user's profile
        driver.Navigate().GoToUrl(targetUser);
        Thread.Sleep(5000);

        // Sending a connection request
        try
        {
            IWebElement connectButton = driver.FindElement(By.XPath("/html/body/div[5]/div[3]/div/div/div[2]/div/div/main/section[1]/div[2]/div[3]/div/button"));
            connectButton.Click();
            Thread.Sleep(2000);

            IWebElement sendwithoutanoteButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[3]/button[2]"));
            sendwithoutanoteButton.Click();
            Console.WriteLine("Connection request sent.");
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("No connect button found, or already connected.");
        }

        // Closing the webdriver
        driver.Quit();
    }
}
