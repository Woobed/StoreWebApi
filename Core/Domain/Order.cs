using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Adress { get; set; }
        public string? Note { get; set; }
        public DateTime? Created { get; set; }

        public Order() {}
        public Order(Guid userId, string adress, string note,DateTime created)
        {
            Id = userId;
            Adress = adress;
            Note = note;
            Created = created;
        }

    }
}
