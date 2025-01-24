using Week2Project.Models;

namespace Week2Project.Services
{
    public class TaskService : ITaskService
    {
        private static List<TaskItem> tasks = new List<TaskItem>();
        private static int nextId = 1;

        public Task<IEnumerable<TaskItem>> GetTasksAsync()
        {
            return Task.FromResult(tasks.AsEnumerable());
        }

        public Task<TaskItem> GetTaskAsync(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            return Task.FromResult(task);
        }

        public Task<TaskItem> AddTaskAsync(TaskItem task)
        {
            task.Id = nextId++;
            tasks.Add(task);
            return Task.FromResult(task);
        }

        public Task UpdateTaskAsync(int id, TaskItem task)
        {
            var existingTask = tasks.FirstOrDefault(t => t.Id == id);
            if (existingTask != null)
            {
                existingTask.Name = task.Name;
                existingTask.Description = task.Description;
                existingTask.Assignee = task.Assignee;
                existingTask.Deadline = task.Deadline;
                existingTask.Status = task.Status;
            }
            return Task.CompletedTask;
        }

        public Task DeleteTaskAsync(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
            }
            return Task.CompletedTask;
        }

        public Task<IEnumerable<TaskItem>> GetTasksByAssigneeAsync(string assignee)
        {
            var assignedTasks = tasks.Where(t => t.Assignee == assignee);
            return Task.FromResult(assignedTasks.AsEnumerable());
        }

        public Task<IEnumerable<TaskItem>> GetTasksByStatusAsync(string status)
        {
            var filteredTasks = tasks.Where(t => t.Status.Equals(status, StringComparison.OrdinalIgnoreCase));
            return Task.FromResult(filteredTasks.AsEnumerable());
        }
    }
}
