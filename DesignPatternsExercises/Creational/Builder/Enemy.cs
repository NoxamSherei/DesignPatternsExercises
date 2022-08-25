using System;

namespace DesignPatternsExercises.Creational.Builder {
    abstract public class Enemy : IBuildable {
        public string Name { get; set; }
        public string Addons { get; set; }
        public string Title { get; set; }
        public Enemy() { Console.WriteLine("Enemy Constructed"); }
        ~Enemy() { Console.WriteLine("Enemy Deconstructed"); }
    }
}
