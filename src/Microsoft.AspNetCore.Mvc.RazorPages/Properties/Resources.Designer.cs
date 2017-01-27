// <auto-generated />
namespace Microsoft.AspNetCore.Mvc.RazorPages
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Mvc.RazorPages.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// The route for the page at '{0}' cannot start with / or ~/. Pages do not support overriding the file path of the page.
        /// </summary>
        internal static string PageActionDescriptorProvider_RouteTemplateCannotBeOverrideable
        {
            get { return GetString("PageActionDescriptorProvider_RouteTemplateCannotBeOverrideable"); }
        }

        /// <summary>
        /// The route for the page at '{0}' cannot start with / or ~/. Pages do not support overriding the file path of the page.
        /// </summary>
        internal static string FormatPageActionDescriptorProvider_RouteTemplateCannotBeOverrideable(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PageActionDescriptorProvider_RouteTemplateCannotBeOverrideable"), p0);
        }

        /// <summary>
        /// The '{0}' property of '{1}' must not be null.
        /// </summary>
        internal static string PropertyOfTypeCannotBeNull
        {
            get { return GetString("PropertyOfTypeCannotBeNull"); }
        }

        /// <summary>
        /// The '{0}' property of '{1}' must not be null.
        /// </summary>
        internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PropertyOfTypeCannotBeNull"), p0, p1);
        }

        /// <summary>
        /// Page created by '{0}' must be an instance of '{1}'.
        /// </summary>
        internal static string ActivatedInstance_MustBeAnInstanceOf
        {
            get { return GetString("ActivatedInstance_MustBeAnInstanceOf"); }
        }

        /// <summary>
        /// Page created by '{0}' must be an instance of '{1}'.
        /// </summary>
        internal static string FormatActivatedInstance_MustBeAnInstanceOf(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ActivatedInstance_MustBeAnInstanceOf"), p0, p1);
        }

        /// <summary>
        /// Argument '{0}' is not the same instance used to create '{1}'.
        /// </summary>
        internal static string PageViewResult_ContextIsInvalid
        {
            get { return GetString("PageViewResult_ContextIsInvalid"); }
        }

        /// <summary>
        /// Argument '{0}' is not the same instance used to create '{1}'.
        /// </summary>
        internal static string FormatPageViewResult_ContextIsInvalid(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("PageViewResult_ContextIsInvalid"), p0, p1);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
