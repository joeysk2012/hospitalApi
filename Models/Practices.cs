namespace hospitalApi.Models
{
    public class Practices
    {  
        public int PracticeId { get; set; }
        public string PracticeName { get; set; }
        public string Specialty { get; set; }
        
        public int LicenseNumber {get; set; }
        public string Address {get; set; }
        public string City {get; set; }  
        public string State {get; set; }  
        public string Zip {get; set; }
        public string Cell {get; set; }
    }
}