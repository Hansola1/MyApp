namespace CarApplication.Models
{
    public enum CarState
    {
        Available = 0, //В наличии
        Issued = 1,     //Выдана
        InMaintenance = 2 //На обслуживании
    }

    public class Car
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public CarState State { get; set; }
        public User? Reader { get; set; }
    }
}
