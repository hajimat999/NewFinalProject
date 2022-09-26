﻿using FinallyFinalProject.Models.Base;

namespace FinallyFinalProject.Models
{
    public class Comment:BaseEntity
    {
        public string Text { get; set; }
        public int Rating { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
