using Microsoft.EntityFrameworkCore;

namespace ScoreBoard.Models
{
    public class JeuDBContext : DbContext
    {
        public JeuDBContext(DbContextOptions<JeuDBContext>option):base(option){
        
        }

        public DbSet<Jeu> Jeu { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }

    }
}
