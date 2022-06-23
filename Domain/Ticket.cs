using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public string? Status { get; set; }
        public string? Priority { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public string? Project { get; set; }
        public int EstimatedHours { get; set; }
        public string? AssignedDevs { get; set; }
        
       
       
        
    }
}