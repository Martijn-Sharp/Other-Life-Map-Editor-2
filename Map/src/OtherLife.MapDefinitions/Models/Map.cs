namespace OtherLife.MapDefinitions.Models
{
    public class Map
    {
        public string Name { get; set; }

        public Mesh NavigationMesh { get; set; }

        public Object3D[] Objects3D { get; set; }

        public Object2D[] Objects2D { get; set; }

        public Light[] Lights { get; set; }
    }
}
