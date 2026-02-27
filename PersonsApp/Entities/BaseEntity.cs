using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PersonsApp.Entities
{
    public class BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        
        //Audit fields <- son para saber quien modifico, quien creo, en que momento y en que hora
        [Column("created_by_id")]
        public string CreatedById { get; set; }
        [Column("created_date")]
        public DateTime CreatedDate { get; set; }
        [Column("updated_by_id")]
        public string UpdatedById { get; set; }
        [Column("updated_date")]
        public DateTime UpdateDate { get; set; }
    }
}