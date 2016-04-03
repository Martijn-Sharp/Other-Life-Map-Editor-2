namespace OtherLife.MapDefinitions.Models
{
    public class Mesh
    {
        public Vector3[] Vertrices { get; set; }

        public int[] Triangles { get; set; }

        public Vector3[] Normals { get; set; }

        public Vector2[] Uv { get; set; }
    }
}