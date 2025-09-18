public class Subsidio
{
    public int Id { get; set; }
    public string NombrePrograma { get; set; }
    public decimal Monto { get; set; }
    public DateTime FechaAsignacion { get; set; } = DateTime.Now;
    public string Estado { get; set; } = "pendiente";

    public int BeneficiarioId { get; set; }
    public Beneficiario Beneficiario { get; set; }
}