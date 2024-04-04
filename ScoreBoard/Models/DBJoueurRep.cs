namespace ScoreBoard.Models
{
    public class DBJoueurRep : IJoueurRepository
    {
        private readonly JeuDBContext cont;
        public DBJoueurRep(JeuDBContext context) {
            cont = context;

        }
        public List<Joueur> ListeJoueurs { get { return cont.Joueurs.OrderBy(Joueur => Joueur.Nom).ToList(); } }

        public Joueur? GetJoueur(int id)
        {
            return cont.Joueurs.FirstOrDefault(x => x.Id == id);
        }

        public void Modifier(Joueur joueur)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(int id)
        {
            cont.Joueurs.Remove(GetJoueur(id)); 
            cont.SaveChanges();
        }
    }
}
