using System;
using System.Diagnostics.CodeAnalysis;
using TechTalk.SpecFlow;
using TheInternetApp.UiTests.Pages.InternalPages;

namespace TheInternetApp.UiTests.Helpers
{
    [Binding]
    public class Transforms
    {
        [StepArgumentTransformation]
        public SubPageType StringToSubPageType([NotNull] string subPage)
        {
            if (subPage == null)
            {
                throw new ArgumentNullException(nameof(subPage));
            }

            subPage = subPage.Replace("/", "").Replace("&", "").Replace(" ", "");

            var subPageType = Enum.Parse<SubPageType>(subPage, true);

            return subPageType;
        }
    }
}
