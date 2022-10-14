namespace NZWalksAPI.Models.Domain
{
    public class Region
    {
        public Guid id { get; set; }
        public string Code { get; set; }

        public string Name { get; set; }

        public double Area { get; set; }

        public double longitude { get; set; }

        public double latitude { get; set; }

        public long Population { get; set; }

        //navigation property
        public IEnumerable<Walk> Walks { get; set; }
    }
}
