public class Entidad
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Contacto { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }

    public ICollection<Beneficiario> Beneficiarios { get; set; }
}