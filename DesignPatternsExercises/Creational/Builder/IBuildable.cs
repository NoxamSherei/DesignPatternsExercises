namespace DesignPatternsExercises.Creational.Builder {
    internal interface IBuildable {
        string Name { get; set; }
        string Addons { get; set; }
        string Title { get; set; }
    }
}
