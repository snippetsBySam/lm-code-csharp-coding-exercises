using System;
namespace Exercises
{
    public class Exercise003
    {
        string[] PipStore = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };
        // Replace the exception statement below with your code!
        public string[] IceCreamFlavours
        {
            get { return PipStore; }
        }

        // Replace the exception statement below with your code!
        public int IceCreamCode(string iceCreamFlavour)
        {
            return Array.IndexOf(PipStore, iceCreamFlavour);
        }
    }
}
