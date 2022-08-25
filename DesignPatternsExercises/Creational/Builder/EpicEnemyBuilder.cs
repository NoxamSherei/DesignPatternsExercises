using System;

namespace DesignPatternsExercises.Creational.Builder {
    internal class EpicEnemyBuilder : IBuilder {
        public bool Validate {
            get {
                if (Title.Length == 0) return false;
                if (Name.Length == 0) return false;
                if (Addons.Length == 0) return false;
                return true;
            }
        }
        public EpicEnemyBuilder() { Console.WriteLine("EpicEnemyBuilder Constructed"); }
        ~EpicEnemyBuilder() { Console.WriteLine("EpicEnemyBuilder Deconstructed"); }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Addons { get; set; }

        public IBuildable build() {
            if (!Validate) throw new NotImplementedException();
            IBuildable enemy = new EpicEnemy();
            enemy.Title = "Epic " + Title;
            enemy.Name = "Epic " + Name;
            enemy.Addons = "x" + Addons;
            return enemy;
        }
    }
}
