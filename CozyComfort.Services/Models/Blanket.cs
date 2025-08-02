namespace CozyComfort.Services.Models
{
    public class Blanket
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Material { get; set; }
        public int ProductionCapacity { get; set; }  // Per batch
        public int InStock { get; set; }
    }
}
