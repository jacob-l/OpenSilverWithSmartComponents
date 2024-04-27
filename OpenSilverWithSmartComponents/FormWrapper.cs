using System.Windows.Controls;

namespace OpenSilverWithSmartComponents
{
    class FormWrapper : StackPanel
    {
        public override object CreateDomElement(object parentRef, out object domElementWhereToPlaceChildren)
        {
            var res = base.CreateDomElement(parentRef, out domElementWhereToPlaceChildren);

            OpenSilver.Interop.ExecuteJavaScriptVoid(@"
                // Assume you have a reference to your div element, for example:
                var divElement = $0;

                // Create a new form element
                var formElement = document.createElement('form');

                // Insert the form in the DOM before the div
                divElement.parentNode.insertBefore(formElement, divElement);

                // Append the div element to the form, effectively wrapping it
                formElement.appendChild(divElement);
            ", parentRef);
            return res;
        }
    }
}
