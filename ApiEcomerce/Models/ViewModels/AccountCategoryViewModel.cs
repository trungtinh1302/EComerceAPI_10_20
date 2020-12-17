using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEcomerce.Models.ViewModels
{
    public class AccountCategoryViewModel
    {
        public int AccountCategoryID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte[] Avatar { get; set; }
        public byte[] Thumb { get; set; }
        public bool Status { get; set; }
        public int Position { get; set; }
    }
}
