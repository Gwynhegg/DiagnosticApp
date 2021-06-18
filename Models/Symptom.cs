using SQLite;

namespace Models
{
    [Table("Symptom")]
    public class Symptom
    {
        [PrimaryKey]
        public long Id { get; set; }

        public string Name { get; set; }

        [Indexed]
        public long SectionId { get; set; }
    }
}
