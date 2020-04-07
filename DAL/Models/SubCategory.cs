using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BudgetTool.DAL.Models
{
    public class SubCategory
    {
        [Key]
        [Column("hMy")]
        public long id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Column("sName")]
        public string sName { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [Column("sDescription")]
        public string sDescription { get; set; }

        [ForeignKey(nameof(Category))]
        public long iCategory { get; set; }
        public Category Category { get; set; }
        
    }
}
