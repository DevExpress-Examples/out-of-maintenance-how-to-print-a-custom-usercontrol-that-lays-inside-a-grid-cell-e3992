using System;
namespace CustomControlInGrid
{
    public interface IEditValue
    {
        object EditValue { get; set;}
        event EventHandler EditValueChanged;
    }
}
