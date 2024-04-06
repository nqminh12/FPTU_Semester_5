using event_exercise;

namespace eventExercise;
internal class Program
{
    private static void Main(string[] args)
    {
        Payment payment = new Payment() { Amount = 1000 };
        payment.AmountChanged += NotifyAmountChanged; // your handling function
        payment.Amount = 990;
        Console.WriteLine( "Tax:" + payment.ComputeTax());

    }

    static void NotifyAmountChanged(float oldValue, float newValue)
    {
        Console.WriteLine($"Amount changed – old value: {oldValue}, new value: {newValue}");
    }
}