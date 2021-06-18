using SQLite;

namespace Models
{
    [Table("Section")]
    public class Section
    {
        [PrimaryKey]
        public long Id { get; set; }

        public string Name { get; set; }

        public long? ParentId { get; set; }
    }
}
