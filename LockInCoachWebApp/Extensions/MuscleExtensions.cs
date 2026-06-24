using LockInCoachWebApp.Enums;

namespace LockInCoachWebApp.Extensions
{
    public static class MuscleExtensions
    {
        public static string GetFakeImage(this Muscle muscle)
        {
            return muscle switch
            {
                Muscle.Chest => "https://www.dravelnutrition.fr/modules/ph_simpleblog/covers/44.jpg",
                Muscle.Back => "https://www.musculaction.com/images/intro-dos.jpg",
                Muscle.Quadriceps => "https://images.unsplash.com/photo-1517963879433-6ad2b056d712",
                Muscle.Hamstrings => "https://fr.myprotein.com/images?url=https://blogscdn.thehut.net/app/uploads/sites/442/2022/01/Blog-hero-5_1641549324_1200x672_acf_cropped.jpg&auto=avif&width=1200&fit=crop",
                Muscle.Biceps => "https://images.unsplash.com/photo-1581009146145-b5ef050c2e1e",
                Muscle.Triceps => "https://squaregym.fr/app/uploads/2024/09/Triceps-dips-exercices.jpg",
                Muscle.Shoulders => "https://www.ownsport.fr/blog/wp-content/uploads/2023/05/epaules2-1.png",
                Muscle.Core => "https://julienquaglierini.com/wp-content/uploads/2022/09/travailler-bas-abdos-musculation.jpg",
                _ => "https://images.unsplash.com/photo-1571019614242-c5c5dee9f50b"
            };
        }
    }
}
