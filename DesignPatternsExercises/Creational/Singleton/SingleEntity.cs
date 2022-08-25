namespace DesignPatternsExercises.Creational.Singleton {
    public class SingleEntity {
        private static SingleEntity entity;
        private SingleEntity() {
            entity = this;
        }
        public static SingleEntity getEntity() {
            if (entity == null) { return new SingleEntity(); }
            else return entity;
        }
    }
}
