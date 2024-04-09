namespace Telemarketing.API.Models;

[Table("Indicador")]
public class Indicador
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public TipoColeta TipoColeta { get; set; }
}
