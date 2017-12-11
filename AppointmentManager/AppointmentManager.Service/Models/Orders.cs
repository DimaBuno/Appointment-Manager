namespace AppointmentManager.Service.Models
{
    public class Appointments
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public string UserIdCustumer { get; set; }
        public string UserIdEmployee { get; set; }
        public string StatusId { get; set; }
    }
}