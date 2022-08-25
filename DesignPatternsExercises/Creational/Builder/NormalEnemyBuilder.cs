using System;

namespace DesignPatternsExercises.Creational.Builder {
    internal class NormalEnemyBuilder : IBuilder {
        public bool Validate {
            get {
                if (Title.Length==0) return false;
                if (Name.Length == 0) return false;
                if (Addons.Length == 0) return false;
                return true;
            }
        }
        public NormalEnemyBuilder() { Console.WriteLine("NormalEnemyBuilder Constructed"); }
        ~NormalEnemyBuilder() { Console.WriteLine("NormalEnemyBuilder Deconstructed"); }

        public string Title { get; set; }
        public string Name { get; set; }
        public string Addons { get; set; }
        
        public IBuildable build() {
            if (!Validate) throw new NotImplementedException();
            IBuildable enemy = new NormalEnemy();
            enemy.Title = "Completly Normal " + Title;
            enemy.Name = "Completly Normal " + Name;
            enemy.Addons ="x" + Addons;
            return enemy;
        }
    }
}
