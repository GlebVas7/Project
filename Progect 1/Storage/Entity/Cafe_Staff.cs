﻿using System.ComponentModel.DataAnnotations;

namespace Progect_1.Storage.Entity
{
    public class Cafe_Staff
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? Profession { get; set; }
    }
}
