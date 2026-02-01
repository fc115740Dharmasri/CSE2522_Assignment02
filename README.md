🧪 CSE2522 – Assignment 02

Test Automation Using Selenium & NUnit

Student
K.A.M.N. Sewwandi Dharmasri
Software Engineering Undergraduate

📌 Project Overview

This project is a test automation framework developed for CSE2522 – Software Quality Assurance using Selenium WebDriver and NUnit.
The system automates functional UI test cases for selected pages in the UI Testing Playground website.

The framework follows the Page Object Model (POM) design pattern to ensure:

Better code organization

High reusability

Easy maintenance


🌐 Application Under Test

UI Testing Playground
🔗 https://uitestingplayground.com/

The following features are automated:

Text Input

Click

Dynamic ID

Sample App

Alerts


🗂️ Project Structure

CSE2522_Assignment02

│

├── Base

│   └── TestBase.cs

│

├── Pages

│   ├── HomePage.cs

│   ├── TextInputPage.cs

│   ├── ClickPage.cs

│   ├── DynamicIdPage.cs

│   ├── SampleAppPage.cs

│   └── AlertsPage.cs

│

├── Tests

│   ├── TextInputTests.cs

│   ├── ClickTests.cs

│   ├── DynamicIdTests.cs

│   ├── SampleAppTests.cs

│   └── AlertsTests.cs


🧱 Framework Design (POM)

Base Layer
  TestBase.cs handles WebDriver initialization and teardown.

Pages Layer
 Contains page classes with element locators and actions.

Tests Layer
 Contains NUnit test classes that validate application behavior using page objects.

🛠️ Technologies Used

Language: C#

Automation Tool: Selenium WebDriver

Test Framework: NUnit

Design Pattern: Page Object Model (POM)

Browser: Google Chrome

IDE: Visual Studio


📦 Required NuGet Packages
  Ensure the following packages are installed in the test project:

Selenium.WebDriver

Selenium.Support

Selenium.WebDriver.ChromeDriver

DotNetSeleniumExtras.WaitHelpers

NUnit

NUnit3TestAdapter

Microsoft.NET.Test.Sdk


▶️ How to Run the Tests
  
  Open the solution in Visual Studio
  
  Restore NuGet packages
  
  Build the solution
  
  Open Test Explorer
  
  Click Run All Tests


All tests will automatically:
  
  Launch Chrome
  
  Navigate to UI Testing Playground
  
  Execute test cases
  
  Close the browser after execution


✅ Key Features

Uses explicit waits to avoid flaky tests

Clean separation of test logic and UI actions

Reusable and maintainable test code

Compatible with NUnit Test Explorer


📌 Conclusion

This automation framework demonstrates effective use of Selenium WebDriver with NUnit following best practices in test automation.
The implementation ensures reliability, scalability, and maintainability, making it suitable for academic evaluation and future enhancements.
