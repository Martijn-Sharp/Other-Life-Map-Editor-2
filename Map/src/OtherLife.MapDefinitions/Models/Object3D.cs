namespace OtherLife.MapDefinitions.Models
{
    public class Object3D
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ModelFile { get; set; }

        public Vector3 Position { get; set; }

        public Vector3 Rotation { get; set; }

        public bool Selflit { get; set; }

        public bool Blended { get; set; }
    }
}
