using LockIn.Application.Interfaces.Services;
using LockIn.Domain.Common.Enums;
using LockIn.Domain.Exercises;

namespace LockIn.Application.Services.Stubs
{
    public class ExerciseServiceStub : IExerciseService
    {
        private readonly List<Exercise> _exercises;

        public ExerciseServiceStub()
        {
            _exercises = new List<Exercise>
            {
                // ================= JAMBES (Quadriceps) =================
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Sissy Squat",
                    Description = "Exercice au poids du corps ciblant fortement les quadriceps en isolant l’extension du genou avec les hanches en extension, accentuant la tension sur le droit fémoral.",
                    TargetMuscle = new() { MuscleGroup.Quadriceps }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Leg extension",
                    Description = "Exercice d’isolation en machine qui consiste à étendre les genoux contre une résistance afin de cibler directement les quadriceps.",
                    TargetMuscle = new() { MuscleGroup.Quadriceps }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Belt Squat",
                    Description = "Variante de squat avec charge fixée à la ceinture permettant de travailler les quadriceps en limitant la contrainte sur le dos.",
                    TargetMuscle = new() { MuscleGroup.Quadriceps }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Fentes marchées",
                    Description = "Exercice unilatéral de déplacement sollicitant quadriceps, fessiers et stabilité des jambes lors de la marche avec charge.",
                    TargetMuscle = new() { MuscleGroup.Quadriceps }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Leg Press",
                    Description = "Presse à cuisses permettant de pousser une charge lourde en flexion-extension des jambes avec méthode rest-pause pour intensifier le travail musculaire.",
                    TargetMuscle = new() { MuscleGroup.Quadriceps }
                },

                // ================= PECTORAUX =================
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Développé couché (machine)",
                    Description = "Exercice de poussée horizontale guidée visant le développement des pectoraux avec assistance mécanique pour stabiliser le mouvement.",
                    TargetMuscle = new() { MuscleGroup.Chest }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Écarté incliné",
                    Description = "Mouvement d’isolation des pectoraux consistant à ouvrir et refermer les bras sur banc incliné pour étirer et contracter la poitrine.",
                    TargetMuscle = new() { MuscleGroup.Chest }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Développé incliné haltères",
                    Description = "Exercice de poussée inclinée avec haltères ciblant la portion supérieure des pectoraux et les épaules antérieures.",
                    TargetMuscle = new() { MuscleGroup.Chest }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Écarté poulie vis-à-vis",
                    Description = "Exercice d’isolation des pectoraux utilisant des poulies pour maintenir une tension constante durant l’adduction des bras.",
                    TargetMuscle = new() { MuscleGroup.Chest }
                },

                // ================= ÉPAULES =================
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Élévation latérale poulie unilatérale",
                    Description = "Exercice d’isolation du deltoïde moyen avec poulie permettant une tension continue lors de l’abduction du bras.",
                    TargetMuscle = new() { MuscleGroup.Shoulders }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Élévations latérales haltères",
                    Description = "Mouvement d’abduction des bras avec haltères ciblant principalement le deltoïde moyen pour élargir les épaules.",
                    TargetMuscle = new() { MuscleGroup.Shoulders }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Élévation postérieure poulie unilatérale",
                    Description = "Exercice ciblant le deltoïde postérieur via un mouvement de tirage arrière contrôlé avec poulie.",
                    TargetMuscle = new() { MuscleGroup.Shoulders }
                },

                // ================= DOS =================
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Tirage vertical pronation",
                    Description = "Exercice de tirage vertical visant le grand dorsal et les muscles du dos en amenant une barre vers la poitrine en pronation.",
                    TargetMuscle = new() { MuscleGroup.Back }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Tirage diagonal unilatéral",
                    Description = "Exercice de tirage en unilatéral suivant une trajectoire diagonale pour renforcer le dos et corriger les déséquilibres.",
                    TargetMuscle = new() { MuscleGroup.Back }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Tirage horizontal machine",
                    Description = "Mouvement de tirage horizontal guidé ciblant les muscles du milieu du dos comme les rhomboïdes et trapèzes.",
                    TargetMuscle = new() { MuscleGroup.Back }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Tirage horizontal unilatéral neutre",
                    Description = "Exercice de tirage unilatéral en prise neutre favorisant le recrutement du dos et la symétrie musculaire.",
                    TargetMuscle = new() { MuscleGroup.Back }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Extensions lombaires",
                    Description = "Exercice d’extension du bas du dos visant les érecteurs du rachis pour renforcer la chaîne postérieure.",
                    TargetMuscle = new() { MuscleGroup.Back }
                },

                // ================= ISCHIOS / JAMBES =================
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Leg Curl assis",
                    Description = "Exercice d’isolation des ischio-jambiers réalisé en flexion du genou sur machine assise.",
                    TargetMuscle = new() { MuscleGroup.Hamstrings }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "SDT roumain",
                    Description = "Soulevé de terre roumain ciblant principalement les ischio-jambiers et les fessiers via une flexion de hanche contrôlée.",
                    TargetMuscle = new() { MuscleGroup.Hamstrings }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Air Squat talons surélevés",
                    Description = "Squat au poids du corps avec talons surélevés augmentant l’implication des quadriceps.",
                    TargetMuscle = new() { MuscleGroup.Quadriceps }
                },

                // ================= BRAS / ABDOS =================
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Dips",
                    Description = "Exercice de poussée au poids du corps sollicitant principalement les triceps et les pectoraux.",
                    TargetMuscle = new() { MuscleGroup.Triceps }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Curl barre EZ",
                    Description = "Exercice de flexion des coudes avec barre EZ ciblant les biceps en limitant la contrainte sur les poignets.",
                    TargetMuscle = new() { MuscleGroup.Biceps }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Crunch poulie haute",
                    Description = "Exercice abdominal avec charge à la poulie permettant une flexion du tronc contre résistance.",
                    TargetMuscle = new() { MuscleGroup.Core }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Rotation buste poulie",
                    Description = "Exercice de gainage dynamique sollicitant les obliques via une rotation contrôlée du tronc à la poulie.",
                    TargetMuscle = new() { MuscleGroup.Core }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Skull crusher",
                    Description = "Extension des triceps en position allongée avec barre ou haltères, ciblant fortement le triceps brachial.",
                    TargetMuscle = new() { MuscleGroup.Triceps }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Extension triceps corde",
                    Description = "Extension des coudes à la poulie avec corde pour isoler les triceps en fin de mouvement.",
                    TargetMuscle = new() { MuscleGroup.Triceps }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Curl incliné",
                    Description = "Curl avec haltères sur banc incliné augmentant l’étirement du biceps en position basse.",
                    TargetMuscle = new() { MuscleGroup.Biceps }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Curl pupitre machine",
                    Description = "Curl biceps guidé sur pupitre isolant le biceps en limitant l’élan.",
                    TargetMuscle = new() { MuscleGroup.Biceps }
                },
                new Exercise
                {
                    Id = Guid.NewGuid(),
                    Name = "Curl marteau alterné",
                    Description = "Curl en prise neutre alternée ciblant le brachial et le brachio-radial en plus du biceps.",
                    TargetMuscle = new() { MuscleGroup.Biceps }
                }
            };
        }

        public Task<List<Exercise>> GetAllAsync()
            => Task.FromResult(_exercises);

        public Task<Exercise?> GetByIdAsync(Guid id)
            => Task.FromResult(_exercises.FirstOrDefault(x => x.Id == id));

        public Task CreateAsync(Exercise exercise)
        {
            exercise.Id = Guid.NewGuid();
            _exercises.Add(exercise);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Exercise exercise)
        {
            var index = _exercises.FindIndex(x => x.Id == exercise.Id);
            if (index != -1)
                _exercises[index] = exercise;

            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            var exercise = _exercises.FirstOrDefault(x => x.Id == id);
            if (exercise != null)
                _exercises.Remove(exercise);

            return Task.CompletedTask;
        }
    }
}