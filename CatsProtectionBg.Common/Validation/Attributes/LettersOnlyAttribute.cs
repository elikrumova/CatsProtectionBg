namespace CatsProtectionBg.Common.Validation.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    [AttributeUsage(AttributeTargets.Property)]
    public class LettersOnlyAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string text = value as string;

            return text.All(c => char.IsLetter(c));
        }
    }
}
