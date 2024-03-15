using System.ComponentModel.DataAnnotations;

namespace Linked_API.Helpers
{
    public class ListValidationsHelper : ValidationAttribute
    {
        private readonly string _expectedSizePopertyName;

        public ListValidationsHelper(string expectedSizePopertyName)
        {
            _expectedSizePopertyName = expectedSizePopertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var list = value as List<int>;
            if (list == null)
            {
                return new ValidationResult("The given value is not a list of integers.");
            }

            var sizeProp = validationContext.ObjectType.GetProperty(_expectedSizePopertyName);
            var sizeValue = (int)sizeProp.GetValue(validationContext.ObjectInstance);
            if (list.Count != sizeValue)
            {
                return new ValidationResult($"The list must have exactly {_expectedSizePopertyName} items.");
            }

            return ValidationResult.Success;
        }
    }
}
