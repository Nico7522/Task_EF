namespace Task_API.Models
{
    public class TaskWithPersonDTO
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public List<PersonDTO> People { get; set; }
    }
}
