using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Model
{
    [Table("ArticleCategory")]
    public class ArticleCategory
    {
        public int ArticleCategoryID { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Avatar { get; set; }
        public byte[] Thumb { get; set; }
        public bool Status { get; set; }
        public int Position { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateBy { get; set; }
        public List<Article> Articles { get; set; }
        [ForeignKey("ArticleMainCategoryID")]
        public int ArticleMainCategoryID { get; set; }
        public ArticleMainCategory ArticleMainCategories { get; set; }
    }
}
