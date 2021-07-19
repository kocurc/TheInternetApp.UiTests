using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using OpenQA.Selenium;
using TheInternetApp.UiTests.Extensions;
using TheInternetApp.UiTests.Pages.HelpPages;
using HPC = TheInternetApp.UiTests.Pages.InternalPages.Home.HomePageConstants;

namespace TheInternetApp.UiTests.Pages.InternalPages.Home
{
    internal class HomePage : BasePage
    {
        public const string ExpectedLocalUrl = "http://localhost:7080/";
        public const string ExpectedRemoteUrl = "http://the-internet.herokuapp.com/";

        #region IWebElementsLinksToSubpages

        public IWebElement AbTestSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.AbTestLink);
        public IWebElement AddRemoveElementsSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.AddRemoveElementsLink);
        public IWebElement BasicAuthSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.BasicAuthLink);
        public IWebElement BrokenImagesSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.BrokenImagesLink);
        public IWebElement ChallengingDomSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.ChallengingDomLink);
        public IWebElement CheckboxesSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.CheckboxesLink);
        public IWebElement ContextMenuSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.ContextMenuLink);
        public IWebElement DigestAuthenticationSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.DigestAuthenticationLink);
        public IWebElement DisappearingElementsSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.DisappearingElementsLink);
        public IWebElement DragAndDropSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.DragAndDropLink);
        public IWebElement DropdownSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.DropdownLink);
        public IWebElement DynamicContentSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.DynamicContentLink);
        public IWebElement DynamicControlsSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.DynamicControlsLink);
        public IWebElement DynamicLoadingSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.DynamicLoadingLink);
        public IWebElement EntryAdSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.EntryAdLink);
        public IWebElement ExitIntentSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.ExitIntentLink);
        public IWebElement FileDownloadSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.FileDownloadLink);
        public IWebElement FileUploadSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.FileUploadLink);
        public IWebElement FloatingMenuSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.FloatingMenuLink);
        public IWebElement ForgotPasswordSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.ForgotPasswordLink);
        public IWebElement FormAuthenticationSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.FormAuthenticationLink);
        public IWebElement FramesSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.FramesLink);
        public IWebElement GeolocationSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.GeolocationLink);
        public IWebElement HorizontalSliderSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.HorizontalSliderLink);
        public IWebElement HoversSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.HoversLink);
        public IWebElement InfiniteScrollSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.InfiniteScrollLink);
        public IWebElement InputsSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.InputsLink);
        public IWebElement JqueryUiMenusSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.JqueryUiMenusLink);
        public IWebElement JavaScriptAlertsSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.JavaScriptAlertsLink);
        public IWebElement JavaScriptOnLoadEventErrorSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.JavaScriptOnLoadEventErrorLink);
        public IWebElement KeyPressesSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.KeyPressesLink);
        public IWebElement LargeDeepDomSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.LargeDeepDomLink);
        public IWebElement MultipleWindowsSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.MultipleWindowsLink);
        public IWebElement NestedFramesSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.NestedFramesLink);
        public IWebElement NotificationMessagesSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.NotificationMessagesLink);
        public IWebElement RedirectSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.RedirectLink);
        public IWebElement SecureFileDownloadSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.SecureFileDownloadLink);
        public IWebElement ShadowDomSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.ShadowDomLink);
        public IWebElement ShiftingContentSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.ShiftingContentLink);
        public IWebElement SlowResourcesSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.SlowResourcesLink);
        public IWebElement SortableDataTablesSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.SortableDataTablesLink);
        public IWebElement StatusCodesSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.StatusCodesLink);
        public IWebElement TyposSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.TyposLink);
        public IWebElement WysiwygEditorSubpageLink => GetSubPageLinkFromLinkAddress(HomePageConstants.WysiwygEditorLink);

        #endregion

        public IWebElement WelcomeHeader => Driver.FindElement(By.ClassName("heading"));
        public IWebElement LinksHeader => Driver.FindElement(By.TagName("h2"));

        public ReadOnlyCollection<IWebElement> SubpagesLinks => Driver.FindElements(By.XPath("//li/a"));

        public Dictionary<IWebElement, string> SubpageLinkWebElementToHref => new()
        {
            { AbTestSubpageLink, HPC.AbTestLink }, { AddRemoveElementsSubpageLink, HPC.AddRemoveElementsLink }, { BasicAuthSubpageLink, HPC.BasicAuthLink }, { BrokenImagesSubpageLink, HPC.BrokenImagesLink },
            { ChallengingDomSubpageLink, HPC.ChallengingDomLink }, { CheckboxesSubpageLink, HPC.CheckboxesLink }, { ContextMenuSubpageLink, HPC.ContextMenuLink }, { DigestAuthenticationSubpageLink, HPC.DigestAuthenticationLink },
            { DisappearingElementsSubpageLink, HPC.DisappearingElementsLink }, { DragAndDropSubpageLink, HPC.DragAndDropLink }, { DropdownSubpageLink, HPC.DropdownLink }, { DynamicContentSubpageLink, HPC.DynamicContentLink },
            { DynamicControlsSubpageLink, HPC.DynamicControlsLink }, { DynamicLoadingSubpageLink, HPC.DynamicLoadingLink }, { EntryAdSubpageLink, HPC.EntryAdLink }, { ExitIntentSubpageLink, HPC.ExitIntentLink },
            { FileDownloadSubpageLink, HPC.FileDownloadLink}, { FileUploadSubpageLink, HPC.FileUploadLink}, { FloatingMenuSubpageLink, HPC.FloatingMenuLink }, { ForgotPasswordSubpageLink, HPC.ForgotPasswordLink },
            { FormAuthenticationSubpageLink, HPC.FormAuthenticationLink }, { FramesSubpageLink, HPC.FramesLink }, { GeolocationSubpageLink, HPC.GeolocationLink}, { HorizontalSliderSubpageLink, HPC.HorizontalSliderLink },
            { HoversSubpageLink, HPC.HoversLink }, { InfiniteScrollSubpageLink, HPC.InfiniteScrollLink }, { InputsSubpageLink, HPC.InputsLink }, { JqueryUiMenusSubpageLink, HPC.JqueryUiMenusLink },
            { JavaScriptAlertsSubpageLink, HPC.JavaScriptAlertsLink }, { JavaScriptOnLoadEventErrorSubpageLink, HPC.JavaScriptOnLoadEventErrorLink}, { KeyPressesSubpageLink, HPC.KeyPressesLink }, { LargeDeepDomSubpageLink, HPC.LargeDeepDomLink },
            { MultipleWindowsSubpageLink, HPC.MultipleWindowsLink }, { NestedFramesSubpageLink, HPC.NestedFramesLink }, { NotificationMessagesSubpageLink, HPC.NotificationMessagesLink }, { RedirectSubpageLink, HPC.RedirectLink },
            { SecureFileDownloadSubpageLink, HPC.SecureFileDownloadLink }, { ShadowDomSubpageLink, HPC.ShadowDomLink}, { ShiftingContentSubpageLink, HPC.ShiftingContentLink }, { SlowResourcesSubpageLink, HPC.SlowResourcesLink },
            { SortableDataTablesSubpageLink, HPC.SortableDataTablesLink}, { StatusCodesSubpageLink, HPC.StatusCodesLink }, { TyposSubpageLink, HPC.TyposLink }, { WysiwygEditorSubpageLink, HPC.WysiwygEditorLink }
        };

        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public override void OpenPage()
        {
            Driver.Navigate().GoToUrl(ExpectedRemoteUrl);
        }

        public IWebElement GetSubPageLinkFromLinkText([NotNull] string linkName)
        {
            if (linkName == null)
            {
                throw new ArgumentNullException(nameof(linkName));
            }

            return Driver.FindElement(By.LinkText(linkName));
        }

        public IWebElement GetSubPageLinkFromLinkAddress([NotNull] string linkAddress)
        {
            if (linkAddress == null)
            {
                throw new ArgumentNullException(nameof(linkAddress));
            }

            return Driver.FindElement(By.XPath($"//a[contains(@href, '/{linkAddress}')]"));
        }

        public void ClickOnSubPageLink([NotNull] string linkText)
        {
            if (linkText == null)
            {
                throw new ArgumentNullException(nameof(linkText));
            }

            GetSubPageLinkFromLinkText(linkText).Click();
        }

        public T NavigateToSubPage<T>(string link) where T : Page, ISubPage, new()
        {
            ClickOnSubPageLink(link);
            Driver.SwitchToLastWindow();

            var subPage = new T();

            subPage.Initialize(Driver);
            WaitForPageToBeLoaded();

            return subPage;
        }

        // TODO Fix constants.
        public T NavigateToSubPage<T>(SubPageType subPageType) where T : Page, ISubPage, new()
        {
            /*subPageType switch
            {
                SubPageType.AbTesting => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.AddRemoveElements => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.BasicAuth => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.BrokenImages => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.ChallengingDom => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.Checkboxes => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.ContextMenu => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.DigestAuthentication => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.DisappearingElements => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.DragAndDrop => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.DropDown => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.DynamicContent => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.DynamicControls => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.DynamicLoading => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.EntryAd => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.ExitIntent => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.FileDownload => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.FileUpload => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.FloatingMenu => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.ForgotPassword => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.FormAuthentication => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.Frames => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.Geolocation => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.HorizontalSlider => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.Hovers => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.InfiniteScroll => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.Inputs => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.JqueryUiMenus => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.JavaScriptsAlerts => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.JavaScriptOnLoadEventError => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.KeyPresses => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.LargeDeepDom => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.MultipleWindows => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.NestedFrames => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.NotificationMessages => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.RedirectLink => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.SecureFileDownload => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.ShadowDom => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.ShiftingContent => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.SlowResources => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.SortableDataTables => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.StatusCodes => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.Typos => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                SubPageType.WysiwygEditor => ClickOnSubPageLink(HomePageConstants.AbTestLink),
                _ => throw new ArgumentOutOfRangeException(nameof(subPageType), subPageType, null)
            };*/

            Driver.SwitchToLastWindow();

            var subPage = new T();

            subPage.Initialize(Driver);
            WaitForPageToBeLoaded();

            return subPage;
        }

        public int GetSubpagesNumber()
        {
            return SubpagesLinks.Count;
        }
    }
}
