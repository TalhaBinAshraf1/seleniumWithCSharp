# 🚧 Selenium_With_C#
This Repository is created to automate e-com platform Daraz by using Selenium with C#. 
## Tech Stack
- C#
- .NET(net6.0)
- Selenium WebDriver
- NUnit(3.13.3)
- Extent Report

## 🔹 Project Structure

      AutomationTask
        │
        ├── Config
        │ └── BaseTest.cs
        │
        ├── Pages
        |  ├── CartPageObjects.cs
        │  ├── LandingPageObjects.cs
        │  ├── LoginPageObjects.cs
        │  ├── ProductObjects.cs
        │  └── RegisterPageObjects.cs
        │
        ├── Suite
        │ └── ValidateUserRegistrationPurchaseFlowTests.cs
        │
        ├── Tests
        │ ├── Language
        | |   |──  LanguageTests.cs
        | |   |__ LanguageActions.cs
        | |
        │ |.....
        |  
        ├── Utility
          ├── TestData.cs
          |── ExtentReporterHelper.cs
          └── UtilityActions.cs

🔹 To run this project, make sure your workstation has:
   1. Should have Visual Studio .NET 6.0 SDK installed
     <p> 1.1. To verify use the command >>  ' dotnet --list-sdks '</p>
     <p> 1.2. If see this >> ' 6.0.xxx ' than you good to go. </p>
   2. Clone the Repository.
   3. Restore Dependencies.
   4. Build the Project.
   5. Run Tests

🔹 Run Commands: 
#### 🔹 Run Full End-to-End Suite
     dotnet test --filter Category=E2E
#### 🔹 Run Specific Test Categories
    dotnet test --filter Category=LanguageChange
    dotnet test --filter Category=Login
    dotnet test --filter Category=UserRegistration
    dotnet test --filter Category=LoginProductAddToCart
    dotnet test --filter Category=LoginAddToCartBuyProduct
    
### 🔹 Generate Allure Report
   After test execution, perform following command to get the report:

         open bin/Debug/net6.0/Reports/ExtentReport.html

## 🔹 Notes
- No real OTP is used.
- No payment is completed.
- Login uses predefined test users.
- Pages contain only locators.
- Actions contain business logic and assertion.

# Attachments:

## Test Execution Vedio:
With Command:

https://github.com/user-attachments/assets/e07b37ab-c27c-44d2-97f8-fa0183967b89

With UI:

https://github.com/user-attachments/assets/ed8cc689-dc20-4d6f-ac53-7f17c6a071de



## Extent Report ScreenShoot:

<img width="1470" height="802" alt="Extent Report 2" src="https://github.com/user-attachments/assets/556f4ed4-7bd5-4ee6-a4d0-fd6a155638b4" /> 
<img width="1470" height="801" alt="Extent Report 1" src="https://github.com/user-attachments/assets/95909774-243d-4e13-ad52-b0bdda0930dd" />


  
    
      
