namespace Week2Project.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Assignee { get; set; } // User assigned to this task
        public DateTime Deadline { get; set; }
        public string Status { get; set; } // "Not Started", "In Progress", "Completed"
    }
}
