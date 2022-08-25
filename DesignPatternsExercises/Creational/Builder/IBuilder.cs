namespace DesignPatternsExercises.Creational.Builder {
    internal interface IBuilder {
        bool Validate { get; }
        string Title { get; set; }
        string Name { get; set; }
        string Addons { get; set; }
        IBuildable build();
    }
}
