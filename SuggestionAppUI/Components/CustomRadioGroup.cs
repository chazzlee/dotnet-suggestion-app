using System;
using Microsoft.AspNetCore.Components.Forms;

namespace SuggestionAppUI.Components;

public class CustomRadioGroup<TValue> : InputRadioGroup<TValue>
{
    private string _name = String.Empty;
    private string _fieldClass = String.Empty;

    protected override void OnParametersSet()
    {
        var fieldClass = EditContext?.FieldCssClass(FieldIdentifier) ?? String.Empty;
        if (fieldClass != _fieldClass || Name != _name)
        {
            _fieldClass = fieldClass;
            _name = Name ?? String.Empty;
            base.OnParametersSet();
        }
    }
}