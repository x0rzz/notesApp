using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Text;

namespace DataAccess.Models
{
    [Table("User")]
    public class UserRto
    {
        public int Id { get; set; }
        [Required] public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? AvatarUrl { get; set; }
        [Required] public byte[] PasswordHash { get; set; }
        [Required] public byte[] PasswordSalt { get; set; }

        #region Relationship
        public List<UserRto> Users { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string PhoneNumberPrefix { get; set; }
        public string PhoneNumber { get; set; }
        public object IsBoy { get; set; }
        public object Patronymic { get; set; }
        public object Birthday { get; set; }
        public ClaimsIdentity Nickname { get; set; }
        #endregion
    }
}
