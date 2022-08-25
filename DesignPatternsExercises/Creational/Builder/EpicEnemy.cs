using System;

namespace DesignPatternsExercises.Creational.Builder {
    public class EpicEnemy : Enemy {
        private string name;
        private string addons;
        private string title;
        public string Name { get => name; set => name=value; }
        public string Addons { get => addons; set => addons=value; }
        public string Title { get => title; set => title=value; }

        public EpicEnemy() { Console.WriteLine("EpicEnemy Constructed"); }
        ~EpicEnemy() { Console.WriteLine("EpicEnemy Deconstructed"); }
    }
}
