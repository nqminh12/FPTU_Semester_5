using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_exercise
{
    public class AmountChangedEventArgs : EventArgs
    {
        public float OldValue { get; }
        public float NewValue { get; }

        public AmountChangedEventArgs(float oldValue, float newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
