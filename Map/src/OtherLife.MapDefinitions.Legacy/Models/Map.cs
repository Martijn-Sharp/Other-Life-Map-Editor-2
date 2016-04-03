namespace OtherLife.MapDefinitions.Legacy.Models
{
    public class Map
    {
        public string FileName { get; set; }

        public byte[] TileMap { get; set; }

        public byte[] HeightMap { get; set; }

        public byte[] Clusters { get; set; }

        /// <summary>Holds the header</summary>
        public Header Header { get; set; }

        /// <summary>Holds the 3d objects</summary>
        public Object3D[] Objects3D { get; set; }

        /// <summary>Holds the 2d objects</summary>
        public Object2D[] Objects2D { get; set; }

        /// <summary>Holds the lights</summary>
        public Light[] Lights { get; set; }

        /// <summary>Holds the particles</summary>
        public Particle[] Particles { get; set; }
    }
}
