namespace WebApplication1.Views.Home
{
    public class Cour
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public ICollection<Eleve> Eleves { get; set; }

        //Gerer les packages nuget sur outils- gestionnaire de package nuget et le 2ieme
    }
}
