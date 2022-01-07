using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Belajar_Api_Net.Infrastructures.DataAccess
{
    public class BaseEntity
    {
        [Column(name: "created_at")]
        public DateTime? CreatedAt { get; set; }

        [Column(name: "created_by")]
        public int? CreatedBy { get; set; }

        [Column(name: "updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [Column(name: "updated_by")]
        public int? UpdatedBy { get; set; }
        
        [Column(name: "deleted_at")]
        public DateTime? DeletedAt { get; set; }
    }
}