namespace Telemarketing.API.Models;

[Table("Coleta")]
public class Coleta
{
    [Key]
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public double ValorColetado { get; set; }
    public int IndicadorId { get; set; }
}
