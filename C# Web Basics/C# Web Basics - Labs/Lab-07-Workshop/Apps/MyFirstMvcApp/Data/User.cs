using SUS.MvcFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFirstMvcApp.Data
{
    public class User : UserIdentity
    {
        public User()
        {
            Id = Guid.NewGuid().ToString();
            Cards = new HashSet<UserCard>();
        }

        
        public virtual ICollection<UserCard> Cards { get; set; }
    }
}
