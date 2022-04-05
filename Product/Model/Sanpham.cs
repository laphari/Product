using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product.Model
{
    public partial class Sanpham
    {
        [Key]
        [Column("ID")]
        [Required(ErrorMessage = "Không được nhập chữ")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Không được de trong")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Không được nhập chữ")]
        public double Price { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Phải là jpg hoặc png")]
        public string Image { get; set; }
        [StringLength(10)]
        public string Detail { get; set; }
    }
}
