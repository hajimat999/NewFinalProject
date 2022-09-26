using FinallyFinalProject.Models.Base;
using System.Collections.Generic;

namespace FinallyFinalProject.Models
{
    public class Color:BaseEntity
    {
        public string ColorName { get; set; }
        public List<ProductColor> ProductColors { get; set; }
    }
}
