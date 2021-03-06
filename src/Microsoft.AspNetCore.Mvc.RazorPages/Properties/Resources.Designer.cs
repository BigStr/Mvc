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
        /// Path must begin with a forward slash '/'.
        /// </summary>
        internal static string RazorProject_PathMustStartWithForwardSlash
        {
            get { return GetString("RazorProject_PathMustStartWithForwardSlash"); }
        }

        /// <summary>
        /// Path must begin with a forward slash '/'.
        /// </summary>
        internal static string FormatRazorProject_PathMustStartWithForwardSlash()
        {
            return GetString("RazorProject_PathMustStartWithForwardSlash");
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
