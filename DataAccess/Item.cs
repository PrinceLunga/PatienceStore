using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatienceShoppingPlatform.DataAccess
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }

        public string Status { get; set; }

        public byte[] Image { get; set; }

        public string RemovedBy { get; set; }
        public DateTime DateRemoved { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime DateModified { get; set; }

    }
}
