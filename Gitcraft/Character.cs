using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GitCraft;

[Table("Character")]
public class Character
{
    [Key]
    public int Id { get; set; }
    [Column("character_Name")]
    public string Character_Name { get; set; }
}