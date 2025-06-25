namespace CarApplication.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public CarState State { get; set; }
        public User Reader { get; set; }

        public enum CarState 
        { 
            Aavailable, //В наличии
            Issued,     //Выдана
            InMaintenance //На обслуживании
        }
    }
}
