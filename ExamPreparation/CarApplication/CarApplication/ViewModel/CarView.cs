using CarApplication.Models;

namespace CarApplication.ViewModel
{
    public class CarView
    {
        public int Id { get; set; }
        public string VIN { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public CarState State { get; set; }
        public string ReaderName { get; set; }
    }
}
