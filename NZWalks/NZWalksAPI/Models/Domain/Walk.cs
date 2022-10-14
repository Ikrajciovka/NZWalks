using System.ComponentModel.DataAnnotations;

namespace NZWalksAPI.Models.Domain
{
    public class Walk
    {
        [Key]
        public Guid guid { get; set; }
        public string Name { get; set; }

        public double Length { get; set; }

        public Guid RegionID { get; set; }

        public Guid WalkDifficultyID { get; set; }

        //Navigation Property
        public Region Region { get; set; }
        public WalkDifficulty Walkdifficulty { get; set; }
    }
}
