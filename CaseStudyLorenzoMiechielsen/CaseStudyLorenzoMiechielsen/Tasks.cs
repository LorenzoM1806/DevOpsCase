using System;
using System.ComponentModel.DataAnnotations;

namespace CaseStudyLorenzoMiechielsen
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string Priority { get; set; }
        public bool TaskStatus { get; set; }
        public DateTime DueTo { get; set; }
    }
}