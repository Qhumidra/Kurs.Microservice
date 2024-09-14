namespace Kurs.Shared.Messages
{
    public class CourseNameChangedEvent
    {
        public  string UserId { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public decimal Price { get; set; }
    }
}
