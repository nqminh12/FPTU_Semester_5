using event_exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace eventExercise
{
    internal class Payment : ITax
    {
        int amount;
        int oldAmount;

        public Payment()
        {
        }

        public int Amount
        {
            get => amount;
            set
            {
                oldAmount = amount;
                amount = value;
                AmountChanged?.Invoke(oldAmount, value);
            }
        }
        public int OldAmount { get => oldAmount; set => oldAmount = value; }

        public float ComputeTax()
        {
            return (float)(0.1 * Amount);
        }


        public delegate void handle(float oldValue, float newValue);
        public event handle AmountChanged;

    }
}