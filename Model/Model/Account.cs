﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Model
{
    [Table("Account")]
    public class Account
    {
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte[] Avatar { get; set; }
        public byte[] Thumb { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobi { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public bool Status { get; set; }
        public DateTime CreateTime { get; set; }
        [ForeignKey("AccountCategoryID")]
        public int AccountCategoryID { get; set; }
        public AccountCategory AccountCategories { get; set; }
    }
}