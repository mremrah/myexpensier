namespace MyExpensier.Models
{
    public class ExpenseDetail : Base
    {
        public int Id { get; set; }
        public string Item { get; set; }        
        public decimal Price { get; set; }
        public virtual Seller Seller { get; set; }
    }
}