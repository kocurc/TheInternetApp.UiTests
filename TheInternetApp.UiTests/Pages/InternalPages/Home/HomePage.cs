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

        public void OpenPage()
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

        public void ClickOnSubPageLink([NotNull] string link)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }

            GetSubPageLinkFromLinkAddress(link).Click();
        }

        public T NavigateToSubPage<T>(string link) where T : ISubPage, new()
        {
            ClickOnSubPageLink(link);
            Driver.SwitchToLastWindow();

            var subPage = new T();

            subPage.Initialize(Driver);
            WaitForPageToBeLoaded();

            return subPage;
        }

        public T NavigateToSubPage<T>(SubPageType subPageType) where T : ISubPage, new()
        {
            switch (subPageType)
            {
                case SubPageType.AbTesting:
                    ClickOnSubPageLink(HomePageConstants.AbTestLink);
                    break;
                case SubPageType.AddRemoveElements:
                    ClickOnSubPageLink(HomePageConstants.AddRemoveElementsLink);
                    break;
                case SubPageType.BasicAuth:
                    ClickOnSubPageLink(HomePageConstants.BasicAuthLink);
                    break;
                case SubPageType.BrokenImages:
                    ClickOnSubPageLink(HomePageConstants.BrokenImagesLink);
                    break;
                case SubPageType.ChallengingDom:
                    ClickOnSubPageLink(HomePageConstants.ChallengingDomLink);
                    break;
                case SubPageType.Checkboxes:
                    ClickOnSubPageLink(HomePageConstants.CheckboxesLink);
                    break;
                case SubPageType.ContextMenu:
                    ClickOnSubPageLink(HomePageConstants.ContextMenuLink);
                    break;
                case SubPageType.DigestAuthentication:
                    ClickOnSubPageLink(HomePageConstants.DigestAuthenticationLink);
                    break;
                case SubPageType.DisappearingElements:
                    ClickOnSubPageLink(HomePageConstants.DisappearingElementsLink);
                    break;
                case SubPageType.DragAndDrop:
                    ClickOnSubPageLink(HomePageConstants.DragAndDropLink);
                    break;
                case SubPageType.DropDown:
                    ClickOnSubPageLink(HomePageConstants.DropdownLink);
                    break;
                case SubPageType.DynamicContent:
                    ClickOnSubPageLink(HomePageConstants.DynamicContentLink);
                    break;
                case SubPageType.DynamicControls:
                    ClickOnSubPageLink(HomePageConstants.DynamicControlsLink);
                    break;
                case SubPageType.DynamicLoading:
                    ClickOnSubPageLink(HomePageConstants.DynamicLoadingLink);
                    break;
                case SubPageType.EntryAd:
                    ClickOnSubPageLink(HomePageConstants.EntryAdLink);
                    break;
                case SubPageType.ExitIntent:
                    ClickOnSubPageLink(HomePageConstants.ExitIntentLink);
                    break;
                case SubPageType.FileDownload:
                    ClickOnSubPageLink(HomePageConstants.FileDownloadLink);
                    break;
                case SubPageType.FileUpload:
                    ClickOnSubPageLink(HomePageConstants.FileUploadLink);
                    break;
                case SubPageType.FloatingMenu:
                    ClickOnSubPageLink(HomePageConstants.FloatingMenuLink);
                    break;
                case SubPageType.ForgotPassword:
                    ClickOnSubPageLink(HomePageConstants.ForgotPasswordLink);
                    break;
                case SubPageType.FormAuthentication:
                    ClickOnSubPageLink(HomePageConstants.FormAuthenticationLink);
                    break;
                case SubPageType.Frames:
                    ClickOnSubPageLink(HomePageConstants.FramesLink);
                    break;
                case SubPageType.Geolocation:
                    ClickOnSubPageLink(HomePageConstants.GeolocationLink);
                    break;
                case SubPageType.HorizontalSlider:
                    ClickOnSubPageLink(HomePageConstants.HorizontalSliderLink);
                    break;
                case SubPageType.Hovers:
                    ClickOnSubPageLink(HomePageConstants.HoversLink);
                    break;
                case SubPageType.InfiniteScroll:
                    ClickOnSubPageLink(HomePageConstants.InfiniteScrollLink);
                    break;
                case SubPageType.Inputs:
                    ClickOnSubPageLink(HomePageConstants.InputsLink);
                    break;
                case SubPageType.JqueryUiMenus:
                    ClickOnSubPageLink(HomePageConstants.JqueryUiMenusLink);
                    break;
                case SubPageType.JavaScriptsAlerts:
                    ClickOnSubPageLink(HomePageConstants.JavaScriptAlertsLink);
                    break;
                case SubPageType.JavaScriptOnLoadEventError:
                    ClickOnSubPageLink(HomePageConstants.JavaScriptOnLoadEventErrorLink);
                    break;
                case SubPageType.KeyPresses:
                    ClickOnSubPageLink(HomePageConstants.KeyPressesLink);
                    break;
                case SubPageType.LargeDeepDom:
                    ClickOnSubPageLink(HomePageConstants.LargeDeepDomLink);
                    break;
                case SubPageType.MultipleWindows:
                    ClickOnSubPageLink(HomePageConstants.MultipleWindowsLink);
                    break;
                case SubPageType.NestedFrames:
                    ClickOnSubPageLink(HomePageConstants.NestedFramesLink);
                    break;
                case SubPageType.NotificationMessages:
                    ClickOnSubPageLink(HomePageConstants.NotificationMessagesLink);
                    break;
                case SubPageType.RedirectLink:
                    ClickOnSubPageLink(HomePageConstants.RedirectLink);
                    break;
                case SubPageType.SecureFileDownload:
                    ClickOnSubPageLink(HomePageConstants.SecureFileDownloadLink);
                    break;
                case SubPageType.ShadowDom:
                    ClickOnSubPageLink(HomePageConstants.ShadowDomLink);
                    break;
                case SubPageType.ShiftingContent:
                    ClickOnSubPageLink(HomePageConstants.ShiftingContentLink);
                    break;
                case SubPageType.SlowResources:
                    ClickOnSubPageLink(HomePageConstants.SlowResourcesLink);
                    break;
                case SubPageType.SortableDataTables:
                    ClickOnSubPageLink(HomePageConstants.SortableDataTablesLink);
                    break;
                case SubPageType.StatusCodes:
                    ClickOnSubPageLink(HomePageConstants.StatusCodesLink);
                    break;
                case SubPageType.Typos:
                    ClickOnSubPageLink(HomePageConstants.TyposLink);
                    break;
                case SubPageType.WysiwygEditor:
                    ClickOnSubPageLink(HomePageConstants.WysiwygEditorLink);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(subPageType), subPageType, null);
            }

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
