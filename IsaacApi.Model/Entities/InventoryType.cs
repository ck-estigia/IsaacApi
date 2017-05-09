using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsaacApi.Model.Entities
{
    public class InventoryType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventoryTypeId { get; set; }

        public string InventoryTypeLabel { get; set; }

        public List<InventoryAttribute> InventoryAttribute { get; set; }
    }
}