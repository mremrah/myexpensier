using System;

namespace MyExpensier.Models
{
    public abstract class Base
    {
        public DateTime CreateDate { get; set; }        
        public DateTime UpdateDate { get; set; }        
    }
}