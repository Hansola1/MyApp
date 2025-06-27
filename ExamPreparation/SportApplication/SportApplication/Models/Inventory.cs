namespace SportApplication.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string InventoryNumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateOnly PublicationDate { get; set; }
        public StateSport State { get; set; }
        public User? Reader { get; set; }
    }

    public enum StateSport
    {
        Available = 0, //В наличии
        Issible = 1, //Выдана
        Servicing = 2, //На обслуживании
    }

}
