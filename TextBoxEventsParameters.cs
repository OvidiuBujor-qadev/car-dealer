using System;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    public class TextBoxEventsParameters
    {
        public EventHandler TextChanged { get; set; }
        public CancelEventHandler Validating { get; set; }

        public TextBoxEventsParameters(EventHandler textChanged, CancelEventHandler validating)
        {
            TextChanged = textChanged;
            Validating = validating;
        }
    }
}
