using Aquality.Appium.Mobile.Elements.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium;

namespace Aquality.Appium.Mobile.Tests.Samples.Android.NativeApp.ApiDemos.Screens
{
    public class SearchViewFilterScreen : ApplicationActivityScreen
    {
        private readonly IButton actionBar;
        private readonly IButton alwaysExpanded;
        private readonly IButton filter;
        public SearchViewFilterScreen() : base(By.XPath("//android.widget.TextView[@text='API Demos']"), null)
        {
            actionBar = ElementFactory.GetButton(MobileBy.Id("android:id/text1"), "Action Bar");
            alwaysExpanded = ElementFactory.GetButton(MobileBy.Id("android:id/text1"), "Always Expanded");
            filter = ElementFactory.GetButton(MobileBy.Id("android:id/text1"), "Filter");
        }

        protected override string Activity => ".ApiDemos";
      
        public void pressFilterAndTypeText()
        {
            filter.Click();
            ITextBox searchTextBox = ElementFactory.GetTextBox(MobileBy.XPath("//android.widget.EditText[@resource-id='android:id/search_src_text']"), "Cheese hunt");
            searchTextBox.ClearAndType("Acorn");
            searchTextBox.Click();  


        }
    }

 }