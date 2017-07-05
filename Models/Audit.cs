using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Audit
    {
        [Key]
        public int Id { get; set; }

        public int RequestorId { get; set; }

        public int ApproverId { get; set; }

        public bool AwaitingApproval { get; set; }

        public bool Approved { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
