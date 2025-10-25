using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoPlanner.Core.Model.Enum;

namespace TodoPlanner.Core.Model
{
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public DateOnly? DueDate { get; set; }

        public bool IsCompleted { get; set; }

        [Required]
        public ePriorityLevel Priority { get; set; }

        [Required]
        public Person Processor { get; set; }

        public TaskItem(int id, string title, string description, DateOnly dueDate, ePriorityLevel prio, Person proc)
        {
            Id = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false;
            Priority = prio;
            Processor = proc;
        }
    }
}
