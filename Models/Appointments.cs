namespace hospitalApi.Models
{
    public class Appointments    
    {  
        public int PatientId { get; set; }
        public int PracticeId { get; set; }
        public string AppointmentDate { get; set; }
        public int Time {get; set; }
        public string Description {get; set; }
    }
}