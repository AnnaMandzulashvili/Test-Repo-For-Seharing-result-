﻿using Aquality.Appium.Mobile.Elements.Interfaces;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Tests.Samples.Android.NativeApp.ApiDemos.Screens
{
    public class InvokeSearchScreen : ApplicationActivityScreen
    {
        private readonly ITextBox searchTextBox;
        private readonly IButton startSearchButton;
        private readonly ILabel searchResultLabel;

        public InvokeSearchScreen() : base(By.XPath("//android.widget.TextView[@text='App/Search/Invoke Search']"), "Invoke Search")
        {
            searchTextBox = ElementFactory.GetTextBox(By.Id("txt_query_prefill"), "Search");
            startSearchButton = ElementFactory.GetButton(By.Id("btn_start_search"), "Start search");
            searchResultLabel = ElementFactory.GetLabel(By.Id("android:id/search_src_text"), "Search results");
        }

        protected override string Activity => ".app.SearchInvoke";

        public string SearchResult => searchResultLabel.Text;

        public void TypeQuery(string query) => searchTextBox.ClearAndType(query);

        public void SubmitSearch(string query)
        {
            TypeQuery(query);
            startSearchButton.Click();
        }
    }
}
