### Selenium to Playwright C# Conversion Guide

This guide provides a comprehensive cheatsheet for converting Selenium-based C# code to Playwright-based C# code, focusing on element methods and their corresponding commands.

---

## Introduction

**Selenium and Playwright** are popular automation frameworks for web application testing. This guide is designed to help you transition from Selenium to Playwright by providing equivalent methods and examples in C#.

### Basic Setup

#### Selenium Setup

```csharp
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://example.com");
```

#### Playwright Setup

```csharp
using Microsoft.Playwright;

var playwright = await Playwright.CreateAsync();
var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
var page = await browser.NewPageAsync();
await page.GotoAsync("https://example.com");
```

---

## Browser and Page Setup

| **Task**                     | **Selenium**                                         | **Playwright**                                                      |
|------------------------------|------------------------------------------------------|---------------------------------------------------------------------|
| Launch Browser               | `new ChromeDriver()`                                 | `await playwright.Chromium.LaunchAsync()`                           |
| Open New Page                | `driver.Navigate().GoToUrl(url)`                     | `await page.GotoAsync(url)`                                         |
| Close Browser                | `driver.Quit()`                                      | `await browser.CloseAsync()`                                        |

---

## Finding Elements

| **Task**                     | **Selenium**                                         | **Playwright**                                                      |
|------------------------------|------------------------------------------------------|---------------------------------------------------------------------|
| Find by ID                   | `driver.FindElement(By.Id("id"))`                    | `page.Locator("#id")`                                               |
| Find by Class Name           | `driver.FindElement(By.ClassName("className"))`      | `page.Locator(".className")`                                        |
| Find by Tag Name             | `driver.FindElement(By.TagName("tag"))`              | `page.Locator("tag")`                                               |
| Find by Name                 | `driver.FindElement(By.Name("name"))`                | `page.Locator("[name='name']")`                                     |
| Find by CSS Selector         | `driver.FindElement(By.CssSelector("css"))`          | `page.Locator("css")`                                               |
| Find by XPath                | `driver.FindElement(By.XPath("xpath"))`              | `page.Locator("xpath")`                                             |

---

## Element Interaction

| **Task**                     | **Selenium**                                         | **Playwright**                                                      |
|------------------------------|------------------------------------------------------|---------------------------------------------------------------------|
| Click                        | `element.Click()`                                    | `await element.ClickAsync()`                                        |
| Type Text                    | `element.SendKeys("text")`                           | `await element.FillAsync("text")`                                   |
| Clear Text                   | `element.Clear()`                                    | `await element.FillAsync("")`                                       |
| Submit Form                  | `element.Submit()`                                   | `await element.PressAsync("Enter")`                                 |

---

## Element Properties and Actions

| **Task**                     | **Selenium**                                         | **Playwright**                                                      |
|------------------------------|------------------------------------------------------|---------------------------------------------------------------------|
| Get Text                     | `element.Text`                                       | `await element.TextContentAsync()`                                  |
| Get Attribute                | `element.GetAttribute("attr")`                       | `await element.GetAttributeAsync("attr")`                           |
| Get CSS Value                | `element.GetCssValue("property")`                    | `await element.EvaluateAsync<string>("e => window.getComputedStyle(e).getPropertyValue('property')")` |
| Is Displayed                 | `element.Displayed`                                  | `await element.IsVisibleAsync()`                                    |
| Is Enabled                   | `element.Enabled`                                    | `await element.IsEnabledAsync()`                                    |
| Is Selected                  | `element.Selected`                                   | `await element.IsCheckedAsync()`                                    |

---

## Waiting for Elements

| **Task**                     | **Selenium**                                         | **Playwright**                                                      |
|------------------------------|------------------------------------------------------|---------------------------------------------------------------------|
| Implicit Wait                | `driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);` | `await page.WaitForTimeoutAsync(10000);`                            |
| Explicit Wait                | `WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));` | `await page.WaitForSelectorAsync("selector", new PageWaitForSelectorOptions { Timeout = 10000 });` |

---

## Handling Alerts

| **Task**                     | **Selenium**                                         | **Playwright**                                                      |
|------------------------------|------------------------------------------------------|---------------------------------------------------------------------|
| Accept Alert                 | `driver.SwitchTo().Alert().Accept()`                 | `await page.Dialog.OnDialog += (_, dialog) => dialog.AcceptAsync();`|
| Dismiss Alert                | `driver.SwitchTo().Alert().Dismiss()`                | `await page.Dialog.OnDialog += (_, dialog) => dialog.DismissAsync();`|
| Get Alert Text               | `driver.SwitchTo().Alert().Text`                     | `page.Dialog.OnDialog += (_, dialog) => Console.WriteLine(dialog.Message);`|

---

## Frames

| **Task**                     | **Selenium**                                         | **Playwright**                                                      |
|------------------------------|------------------------------------------------------|---------------------------------------------------------------------|
| Switch to Frame              | `driver.SwitchTo().Frame(frameElement)`              | `var frame = page.Frame("frameName");`                              |
| Switch to Default Content    | `driver.SwitchTo().DefaultContent()`                 | `await page.MainFrameAsync()`                                       |

---

## Handling Windows and Tabs

| **Task**                     | **Selenium**                                         | **Playwright**                                                      |
|------------------------------|------------------------------------------------------|---------------------------------------------------------------------|
| Switch to Window             | `driver.SwitchTo().Window(windowHandle)`             | `var page = await context.NewPageAsync();`                          |
| Close Window                 | `driver.Close()`                                     | `await page.CloseAsync()`                                           |

---

## Keyboard and Mouse Actions

| **Task**                     | **Selenium**                                         | **Playwright**                                                      |
|------------------------------|------------------------------------------------------|---------------------------------------------------------------------|
| Send Keys                    | `element.SendKeys("text")`                           | `await page.Keyboard.TypeAsync("text")`                             |
| Press Key                    | `element.SendKeys(Keys.Enter)`                       | `await page.Keyboard.PressAsync("Enter")`                           |
| Mouse Click                  | `Actions actions = new Actions(driver); actions.Click(element).Perform();` | `await page.Mouse.ClickAsync(x, y)`                                  |
| Mouse Hover                  | `Actions actions = new Actions(driver); actions.MoveToElement(element).Perform();` | `await element.HoverAsync()`                                        |

---

## Screenshots

| **Task**                     | **Selenium**                                         | **Playwright**                                                      |
|------------------------------|------------------------------------------------------|---------------------------------------------------------------------|
| Take Screenshot              | `((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("screenshot.png");` | `await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });`|

---

## Assertions

| **Task**                     | **Selenium**                                         | **Playwright**                                                      |
|------------------------------|------------------------------------------------------|---------------------------------------------------------------------|
| Assert Element Text          | `Assert.AreEqual("expected", element.Text);`         | `Assert.AreEqual("expected", await element.TextContentAsync());`    |
| Assert Element Visible       | `Assert.IsTrue(element.Displayed);`                  | `Assert.IsTrue(await element.IsVisibleAsync());`                    |

---

## Conclusion

This cheatsheet provides a quick reference to convert Selenium C# code to Playwright C# code, focusing on the most common tasks and methods used in web automation. Playwright offers more advanced features and better reliability for modern web applications, making it a powerful alternative to Selenium.

----

## Comprehensive Guide to Converting a Selenium Project to Playwright in C#

This guide aims to walk you through the step-by-step process of converting an existing Selenium project to use Playwright, including practical examples, detailed documentation, and regex patterns for search and replace operations to ensure a smooth transition.

---

### Prerequisites

1. **Install Playwright**: Ensure you have Playwright installed in your project. If not, install it using NuGet Package Manager or CLI.

   ```bash
   dotnet add package Microsoft.Playwright
   ```

2. **Remove Selenium Dependencies**: Uninstall Selenium from your project if you no longer need it.

---

### Basic Setup

#### Selenium Setup

**Before:**
```csharp
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://example.com");
```

#### Playwright Setup

**After:**
```csharp
using Microsoft.Playwright;

var playwright = await Playwright.CreateAsync();
var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
var page = await browser.NewPageAsync();
await page.GotoAsync("https://example.com");
```

---

### Element Identification and Actions

#### Finding Elements

**Selenium:**
```csharp
IWebElement element = driver.FindElement(By.Id("elementId"));
```

**Playwright:**
```csharp
var element = page.Locator("#elementId");
```

#### Element Actions

| **Action**           | **Selenium**                                    | **Playwright**                                |
|----------------------|-------------------------------------------------|-----------------------------------------------|
| Click                | `element.Click();`                              | `await element.ClickAsync();`                 |
| Send Keys            | `element.SendKeys("text");`                     | `await element.FillAsync("text");`            |
| Clear                | `element.Clear();`                              | `await element.FillAsync("");`                |
| Get Text             | `string text = element.Text;`                   | `string text = await element.TextContentAsync();` |
| Get Attribute        | `string attr = element.GetAttribute("name");`   | `string attr = await element.GetAttributeAsync("name");` |
| Is Displayed         | `bool displayed = element.Displayed;`           | `bool visible = await element.IsVisibleAsync();` |
| Is Enabled           | `bool enabled = element.Enabled;`               | `bool enabled = await element.IsEnabledAsync();` |

#### Example Conversion

**Before:**
```csharp
IWebElement button = driver.FindElement(By.Id("submit"));
button.Click();
string buttonText = button.Text;
```

**After:**
```csharp
var button = page.Locator("#submit");
await button.ClickAsync();
string buttonText = await button.TextContentAsync();
```

---

### Waits

#### Implicit Wait

**Selenium:**
```csharp
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
```

**Playwright:**
```csharp
// Playwright does not support implicit waits; use explicit waits instead.
```

#### Explicit Wait

**Selenium:**
```csharp
WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
IWebElement element = wait.Until(d => d.FindElement(By.Id("elementId")));
```

**Playwright:**
```csharp
await page.WaitForSelectorAsync("#elementId");
var element = page.Locator("#elementId");
```

---

### Frames

**Selenium:**
```csharp
driver.SwitchTo().Frame("frameName");
IWebElement element = driver.FindElement(By.Id("elementId"));
driver.SwitchTo().DefaultContent();
```

**Playwright:**
```csharp
var frame = page.Frame("frameName");
var element = frame.Locator("#elementId");
```

---

### Handling Alerts

**Selenium:**
```csharp
IAlert alert = driver.SwitchTo().Alert();
alert.Accept();
```

**Playwright:**
```csharp
page.Dialog += async (_, dialog) =>
{
    await dialog.AcceptAsync();
};
```

---

### Regex for Search and Replace

To convert your existing Selenium methods to Playwright, you can use regex patterns to search and replace the relevant parts of your code. Below are some regex examples to assist in this process.

#### Element Identification

- **Find by ID**
  - **Selenium:** `driver\.FindElement\(By\.Id\("([^"]+)"\)\)`
  - **Playwright:** `page.Locator("#$1")`

#### Element Actions

- **Click**
  - **Selenium:** `(\w+)\.Click\(\);`
  - **Playwright:** `await $1.ClickAsync();`

- **Send Keys**
  - **Selenium:** `(\w+)\.SendKeys\("([^"]+)"\);`
  - **Playwright:** `await $1.FillAsync("$2");`

- **Get Text**
  - **Selenium:** `string (\w+) = (\w+)\.Text;`
  - **Playwright:** `string $1 = await $2.TextContentAsync();`

- **Get Attribute**
  - **Selenium:** `string (\w+) = (\w+)\.GetAttribute\("([^"]+)"\);`
  - **Playwright:** `string $1 = await $2.GetAttributeAsync("$3");`

#### Example Script for Search and Replace

You can use a script or a tool like a code editor with regex search and replace functionality to perform these conversions. Here is an example script using a hypothetical tool or script:

```bash
# Find and replace driver.FindElement(By.Id("elementId"))
sed -i 's/driver\.FindElement(By\.Id\("([^"]+)"\))/page.Locator("#\1")/g' *.cs

# Find and replace Click
sed -i 's/\(\w+\)\.Click();/await \1.ClickAsync();/g' *.cs

# Find and replace SendKeys
sed -i 's/\(\w+\)\.SendKeys("([^"]+)");/await \1.FillAsync("\2");/g' *.cs

# Find and replace Get Text
sed -i 's/string \(\w+\) = \(\w+\)\.Text;/string \1 = await \2.TextContentAsync();/g' *.cs

# Find and replace Get Attribute
sed -i 's/string \(\w+\) = \(\w+\)\.GetAttribute("([^"]+)");/string \1 = await \2.GetAttributeAsync("\3");/g' *.cs
```

### Conclusion

By following this guide, you should be able to convert your Selenium-based C# project to use Playwright, leveraging its advanced features and improved reliability for modern web applications. This conversion will not only modernize your test automation suite but also enhance its efficiency and maintainability.
