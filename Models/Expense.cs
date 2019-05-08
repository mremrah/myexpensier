using System.Collections.Generic;

namespace MyExpensier.Models
{
    public class Expense : Base
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal TotalAmount { get; set; }

        public ICollection<ExpenseDetail> Expenses { get; set; }

        public virtual Seller Seller { get; set; }

    }
}