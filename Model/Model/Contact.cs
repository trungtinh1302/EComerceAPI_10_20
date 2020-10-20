using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Model
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactID { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Mobi { get; set; }
        public string Content { get; set; }
        public string AttachmentFile { get; set; }
        public bool Status { get; set; }
        public DateTime CreateTime { get; set; }
        public string ApproveBy { get; set; }
        [ForeignKey("ContactCategory")]
        public int ContactCategoryID { get; set; }
        public ContactCategory ContactCategories { get; set; }     
    }
}
