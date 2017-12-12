namespace CatsProtectionBg.Common.Validation.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    [AttributeUsage(AttributeTargets.Property)]
    public class ImageAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var path = value as string;

            string pattern = @"^(?:http|https):\/\/.+$";

            Regex rgx = new Regex(pattern);

            return path != null && rgx.IsMatch(path);
        }
    }
}
