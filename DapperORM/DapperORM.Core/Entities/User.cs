using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DapperORM.Core.Entities
{
    [Table("User", Schema = "dbo")]
    public class User
    {
        [Key]
        public Int32 UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string UserFullName { get; set; }

        [NotMapped]
        public string Type { get; set; }
    }
}
