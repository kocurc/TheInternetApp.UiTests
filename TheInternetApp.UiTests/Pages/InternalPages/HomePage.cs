using System;
using System.Diagnostics.CodeAnalysis;
using OpenQA.Selenium;
using TheInternetApp.UiTests.Extensions;
using TheInternetApp.UiTests.Pages.HelpPages;
using TheInternetApp.UiTests.Pages.InternalPages;

namespace TheInternetApp.UiTests.Pages
{
    internal class HomePage : BasePage
    {
        public const string ExpectedUrl = "http://localhost:7080/";

        #region LinksConstants

        public const string AbTestLink = "abtest";
        public const string AddRemoveElementsLink = "add_remove_elements";
        public const string BasicAuthLink = "basic_auth";
        public const string BrokenImagesLink = "broken_images";
        public const string ChallengingDomLink = "challenging_dom";
        public const string CheckboxesLink = "checkboxes";
        public const string ContextMenuLink = "context_menu";
        public const string DigestAuthenticationLink = "digest_auth";
        public const string DisappearingElementsLink = "disappearing_elements";
        public const string DragAndDropLink = "drag_and_drop";
        public const string DropdownLink = "dropdwon";
        public const string DynamicContentLink = "dynamic_content";
        public const string DynamicControlsLink = "dynamic_controls";
        public const string DynamicLoadingLink = "dynamic_loading";
        public const string EntryAdLink = "entry_ad";
        public const string ExitIntentLink = "exit_intent";
        public const string FileDownloadLink = "download";
        public const string FileUploadLink = "upload";
        public const string FloatingMenuLink = "floating_menu";
        public const string ForgotPasswordLink = "forgot_password";
        public const string FormAuthenticationLink = "login";
        public const string FramesLink = "frames";
        public const string GeolocationLink = "geolocation";
        public const string HorizontalSliderLink = "horizontal_slider";
        public const string HoversLink = "hovers";
        public const string InfiniteScrollLink = "infinite_scroll";
        public const string InputsLink = "inputs";
        public const string JqueryUiMenusLink = "jqueryui/menu";
        public const string JavaScriptAlertsLink = "javascript_alerts";
        public const string JavaScriptOnLoadEventErrorLink = "javascript_error";
        public const string KeyPressesLink = "key_presses";
        public const string LargeDeepDomLink = "large";
        public const string MultipleWindowsLink = "windows";
        public const string NestedFramesLink = "nested_frames";
        public const string NotificationMessagesLink = "notification_messages";
        public const string RedirectLink = "redirector";
        public const string SecureFileDownloadLink = "download_secure";
        public const string ShadowDomLink = "shadowdom";
        public const string ShiftingContentLink = "shifting_content";
        public const string SlowResourcesLink = "slow";
        public const string SortableDataTablesLink = "tables";
        public const string StatusCodesLink = "status_codes";
        public const string TyposLink = "typos";
        public const string WysiwygEditorLink = "tinymce";

        #endregion

        public IWebElement WelcomeHeader => Driver.FindElement(By.ClassName("heading"));
        public IWebElement LinksHeader => Driver.FindElement(By.TagName("h2"));

        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public void OpenPage()
        {
            Driver.Navigate().GoToUrl(ExpectedUrl);
        }

        public IWebElement GetSubPageLink([NotNull] string link)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }

            return Driver.FindElement(By.LinkText(link));
        }

        public void ClickOnSubPageLink([NotNull] string link)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }

            GetSubPageLink(link).Click();
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
                    ClickOnSubPageLink(HomePage.AbTestLink);
                    break;
                case SubPageType.AddRemoveElements:
                    ClickOnSubPageLink(HomePage.AddRemoveElementsLink);
                    break;
                case SubPageType.BasicAuth:
                    ClickOnSubPageLink(HomePage.BasicAuthLink);
                    break;
                case SubPageType.BrokenImages:
                    ClickOnSubPageLink(HomePage.BrokenImagesLink);
                    break;
                case SubPageType.ChallengingDom:
                    ClickOnSubPageLink(HomePage.ChallengingDomLink);
                    break;
                case SubPageType.Checkboxes:
                    ClickOnSubPageLink(HomePage.CheckboxesLink);
                    break;
                case SubPageType.ContextMenu:
                    ClickOnSubPageLink(HomePage.ContextMenuLink);
                    break;
                case SubPageType.DigestAuthentication:
                    ClickOnSubPageLink(HomePage.DigestAuthenticationLink);
                    break;
                case SubPageType.DisappearingElements:
                    ClickOnSubPageLink(HomePage.DisappearingElementsLink);
                    break;
                case SubPageType.DragAndDrop:
                    ClickOnSubPageLink(HomePage.DragAndDropLink);
                    break;
                case SubPageType.DropDown:
                    ClickOnSubPageLink(HomePage.DropdownLink);
                    break;
                case SubPageType.DynamicContent:
                    ClickOnSubPageLink(HomePage.DynamicContentLink);
                    break;
                case SubPageType.DynamicControls:
                    ClickOnSubPageLink(HomePage.DynamicControlsLink);
                    break;
                case SubPageType.DynamicLoading:
                    ClickOnSubPageLink(HomePage.DynamicLoadingLink);
                    break;
                case SubPageType.EntryAd:
                    ClickOnSubPageLink(HomePage.EntryAdLink);
                    break;
                case SubPageType.ExitIntent:
                    ClickOnSubPageLink(HomePage.ExitIntentLink);
                    break;
                case SubPageType.FileDownload:
                    ClickOnSubPageLink(HomePage.FileDownloadLink);
                    break;
                case SubPageType.FileUpload:
                    ClickOnSubPageLink(HomePage.FileUploadLink);
                    break;
                case SubPageType.FloatingMenu:
                    ClickOnSubPageLink(HomePage.FloatingMenuLink);
                    break;
                case SubPageType.ForgotPassword:
                    ClickOnSubPageLink(HomePage.ForgotPasswordLink);
                    break;
                case SubPageType.FormAuthentication:
                    ClickOnSubPageLink(HomePage.FormAuthenticationLink);
                    break;
                case SubPageType.Frames:
                    ClickOnSubPageLink(HomePage.FramesLink);
                    break;
                case SubPageType.Geolocation:
                    ClickOnSubPageLink(HomePage.GeolocationLink);
                    break;
                case SubPageType.HorizontalSlider:
                    ClickOnSubPageLink(HomePage.HorizontalSliderLink);
                    break;
                case SubPageType.Hovers:
                    ClickOnSubPageLink(HomePage.HoversLink);
                    break;
                case SubPageType.InfiniteScroll:
                    ClickOnSubPageLink(HomePage.InfiniteScrollLink);
                    break;
                case SubPageType.Inputs:
                    ClickOnSubPageLink(HomePage.InputsLink);
                    break;
                case SubPageType.JqueryUiMenus:
                    ClickOnSubPageLink(HomePage.JqueryUiMenusLink);
                    break;
                case SubPageType.JavaScriptsAlerts:
                    ClickOnSubPageLink(HomePage.JavaScriptAlertsLink);
                    break;
                case SubPageType.JavaScriptOnLoadEventError:
                    ClickOnSubPageLink(HomePage.JavaScriptOnLoadEventErrorLink);
                    break;
                case SubPageType.KeyPresses:
                    ClickOnSubPageLink(HomePage.KeyPressesLink);
                    break;
                case SubPageType.LargeDeepDom:
                    ClickOnSubPageLink(HomePage.LargeDeepDomLink);
                    break;
                case SubPageType.MultipleWindows:
                    ClickOnSubPageLink(HomePage.MultipleWindowsLink);
                    break;
                case SubPageType.NestedFrames:
                    ClickOnSubPageLink(HomePage.NestedFramesLink);
                    break;
                case SubPageType.NotificationMessages:
                    ClickOnSubPageLink(HomePage.NotificationMessagesLink);
                    break;
                case SubPageType.RedirectLink:
                    ClickOnSubPageLink(HomePage.RedirectLink);
                    break;
                case SubPageType.SecureFileDownload:
                    ClickOnSubPageLink(HomePage.SecureFileDownloadLink);
                    break;
                case SubPageType.ShadowDom:
                    ClickOnSubPageLink(HomePage.ShadowDomLink);
                    break;
                case SubPageType.ShiftingContent:
                    ClickOnSubPageLink(HomePage.ShiftingContentLink);
                    break;
                case SubPageType.SlowResources:
                    ClickOnSubPageLink(HomePage.SlowResourcesLink);
                    break;
                case SubPageType.SortableDataTables:
                    ClickOnSubPageLink(HomePage.SortableDataTablesLink);
                    break;
                case SubPageType.StatusCodes:
                    ClickOnSubPageLink(HomePage.StatusCodesLink);
                    break;
                case SubPageType.Typos:
                    ClickOnSubPageLink(HomePage.TyposLink);
                    break;
                case SubPageType.WysiwygEditor:
                    ClickOnSubPageLink(HomePage.WysiwygEditorLink);
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
    }
}
