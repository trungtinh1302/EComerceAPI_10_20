using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEcomerce.Models.ViewModels
{
    public class ProductCategoryViewModel
    {
        public int ProductCategoryID { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Avatar { get; set; }
        public byte[] Thumb { get; set; }
        public bool Status { get; set; }
        public int Position { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateBy { get; set; }
    }
}
