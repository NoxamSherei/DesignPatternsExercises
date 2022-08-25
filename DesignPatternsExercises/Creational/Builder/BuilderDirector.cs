using System;

namespace DesignPatternsExercises.Creational.Builder {
    class BuilderDirector{
        public BuilderDirector() { Console.WriteLine("BuilderDirector Constructed"); }
        ~BuilderDirector() { Console.WriteLine("BuilderDirector Deconstructed"); }
        public IBuilder builder;
        public void setBuilder(IBuilder builder) {
            Console.WriteLine("BuilderDirector.setBuilder()");
            this.builder = builder;
        }
        public IBuildable build( string title, string name,string addon) {
            builder.Addons = addon;
            builder.Title = title;
            builder.Name = name;
            return builder.build() ;
        }
    }
}
