namespace Testowy.Models
{
    public class Opinia
    {
        public int Id { get; set; }
        public string NazwaUżytkownika { get; set; }
        public string Email { get; set; }
        public string Wiadomosc { get; set; }
        public bool OczekujeOdpowiedzi { get; set; }
    }
}
