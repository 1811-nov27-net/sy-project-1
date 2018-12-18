using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Context
{
    public partial class Users
    {
        public Users()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
