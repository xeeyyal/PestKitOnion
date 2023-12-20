﻿namespace PestKitOnionAB104.Domain
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set;}
        public string CreatedBy { get; set; } = null!;

        public BaseEntity()
        {
            CreatedAt= DateTime.Now;
            CreatedBy = "xeeyyal068";
        }
    }
}
