using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Model
{
    [Table("Article")]
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArticleID { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Avatar { get; set; }
        public byte[] Thumb { get; set; }
        public string Content { get; set; }
        public string Keyword { get; set; }
        public byte[] ImageList { get; set; }
        public string SourcePage { get; set; }
        public string AttachmentFile { get; set; }
        public int ViewTime { get; set; }
        public bool Status { get; set; }
        public int Position { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateBy { get; set; }
        [ForeignKey("ArticleCategoryID")]
        public int ArticleCategoryID { get; set; }
        public ArticleCategory ArticleCategories { get; set; }
    }
}
