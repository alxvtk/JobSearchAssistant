namespace JobSearchAssistantAPI.Data
{
    public class Location2Business
    {
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public int LocationId {get; set;}
        public bool Active { get; set; }
    }
}