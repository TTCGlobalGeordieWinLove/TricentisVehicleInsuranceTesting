using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;
using OpenQA.Selenium;
using TricentisVehicleInsurance.Globals;
using TricentisVehicleInsurance.PageObject;

namespace TricentisVehicleInsurance.ElementObjects
{
    /// <summary>
    /// Models a basic link on a webpage, a wrapper around a generic IWebElement.
    /// </summary>
    /// <typeparam name="LinkedPage">The class of the linked page.</typeparam>
    public class Link<LinkedPage> : IWebElement where LinkedPage : new()
    {
        protected IWebElement element;
        /// <summary>
        /// Constructs a new Link that opens a page and returns the new page object of type: <typeparamref name="LinkedPage"/>.
        /// </summary>
        /// <param name="locator">The locator to find the link element.</param>
        public Link(By locator)
        {
            element = ObjectRepo.WebDriver.FindElement(locator);
        }
        /// <summary>
        /// Constructs a new Link that opens a page and returns the new page object of type: <typeparamref name="LinkedPage"/>.
        /// </summary>
        /// <param name="element">The element corresponding to the link.</param>
        public Link(IWebElement element)
        {
            this.element = element;
        }
        /// <summary>
        /// Clicks the link and returns the given type for the page navigated to.
        /// </summary>
        /// <returns>An object representing the given <typeparamref name="LinkedPage"/></returns>
        public LinkedPage Navigate()
        {
            this.Click();
            return new LinkedPage();
        }

        public string TagName => element.TagName;

        public string Text => element.Text;

        public bool Enabled => element.Enabled;

        public bool Selected => element.Selected;

        public Point Location => element.Location;

        public Size Size => element.Size;

        public bool Displayed => element.Displayed;

        public void Clear()
        {
            element.Clear();
        }

        public void Click()
        {
            element.Click();
        }

        

        public IWebElement FindElement(By by)
        {
            return element.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return element.FindElements(by);
        }

        public string GetAttribute(string attributeName)
        {
            return element.GetAttribute(attributeName);
        }

        public string GetCssValue(string propertyName)
        {
            return element.GetCssValue(propertyName);
        }

        public string GetProperty(string propertyName)
        {
            return element.GetProperty(propertyName);
        }

        public void SendKeys(string text)
        {
            element.SendKeys(text);
        }

        public void Submit()
        {
            element.Submit();
        }
    }
}