﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CDub_Blazor_Crud.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }
        [Required (ErrorMessage = "The Display Order field is required.")]
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100.")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
