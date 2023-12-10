namespace Task_API.Models
{
    public class TaskModel
    {
        private int _taskId;
        private string _title;
        private string _description;
        private bool _isCompleted;

        public int TaskId { get => _taskId; set => _taskId = value; }
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public bool IsCompleted { get => _isCompleted; set => _isCompleted = value; }
    }
}
