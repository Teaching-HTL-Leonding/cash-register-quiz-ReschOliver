namespace CashRegister.UICore
{
    public class ReceiptLineViewModel
    {
        public int Amount { get; internal set; }
        public int ProductID { get; internal set; }
        public string ProductName { get; internal set; }
        public decimal TotalPrice { get; internal set; }
    }
}