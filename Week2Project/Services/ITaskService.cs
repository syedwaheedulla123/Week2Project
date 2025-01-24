using Week2Project.Models;

namespace Week2Project.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskItem>> GetTasksAsync();
        Task<TaskItem> GetTaskAsync(int id);
        Task<TaskItem> AddTaskAsync(TaskItem task);
        Task UpdateTaskAsync(int id, TaskItem task);
        Task DeleteTaskAsync(int id);
        Task<IEnumerable<TaskItem>> GetTasksByAssigneeAsync(string assignee);
        Task<IEnumerable<TaskItem>> GetTasksByStatusAsync(string status);
    }
}
