using EchoPlatform.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoPlatform.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime registration_date { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
