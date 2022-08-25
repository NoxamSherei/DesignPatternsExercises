using System;
using DesignPatternsExercises.Creational.Singleton;
using DesignPatternsExercises.Creational.Builder;
using System.Collections.Generic;

namespace DesignPatternsExercises {
    internal class Program {
        static void Main(string[] args) {
            BuilderRun();
            Console.WriteLine("Hello World, this is Design patterns");
        }
        static void BuilderRun() {
            var builder = new BuilderDirector();
            builder.setBuilder(new EpicEnemyBuilder());
            List<Enemy> test = new();
            Enemy enemy = builder.build("Grand", "Zombie", "Fire") as Enemy;
            test.Add(enemy);
            test.Add(builder.build("Grand", "Dragon", "Fire") as Enemy);
            test.Add(builder.build("Grand", "Dragon", "Stone") as Enemy);
            test.Add(builder.build("Small", "Dragon", "Stone") as Enemy);
            builder.setBuilder(new NormalEnemyBuilder());
            test.Add(builder.build("Grand", "Dragon", "Fire") as Enemy);
            test.Add(builder.build("Grand", "Dragon", "Stone") as Enemy);
            test.Add(builder.build("Small", "Dragon", "Stone") as Enemy);
            int size = test.Count;
            foreach (var elem in test) {
                Console.WriteLine($"{elem.ToString()} [{elem.Title},{elem.Name},{elem.Addons}]");
            }
            test.Clear();
        }
    }
}