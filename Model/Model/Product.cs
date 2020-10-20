using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Model
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Avatar { get; set; }
        public byte[] Thumb { get; set; }
        public string Content { get; set; }
        public string Keyword { get; set; }
        public byte[] ImageList { get; set; }
        public byte[] GalleryImageList { get; set; }
        public string SourcePage { get; set; }
        public string SourceLink { get; set; }
        public int ViewTime { get; set; }
        public string AttachmentFile { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }
        public string Promotions { get; set; }
        public string WarrantyPolicy { get; set; }
        public string Specifications { get; set; }
        public string Accessories { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public int Position { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateBy { get; set; }
        [ForeignKey("ProductCategory")]
        public int ProductCategoryID { get; set; }
        public ProductCategory ProductCategories { get; set; }
    }
}
