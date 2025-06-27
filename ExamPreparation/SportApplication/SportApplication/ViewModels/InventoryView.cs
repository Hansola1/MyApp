using SportApplication.Models;

namespace SportApplication.ViewModels
{
    public class InventoryView
    {
        public int Id { get; set; }
        public string InventoryNumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateOnly PublicationDate { get; set; }
        public StateSport State { get; set; }
        public string ReaderName { get; set; }
    }
}
