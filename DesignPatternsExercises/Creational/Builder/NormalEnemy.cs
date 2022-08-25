using System;

namespace DesignPatternsExercises.Creational.Builder {
    internal class NormalEnemy : Enemy {
        private string name;
        private string addons;
        private string title;
        public string Name { get => name; set => name = value; }
        public string Addons { get => addons; set => addons = value; }
        public string Title { get => title; set => title = value; }

        public NormalEnemy() { Console.WriteLine("NormalEnemy Constructed"); }
        ~NormalEnemy() { Console.WriteLine("NormalEnemy Deconstructed"); }
    }
}
