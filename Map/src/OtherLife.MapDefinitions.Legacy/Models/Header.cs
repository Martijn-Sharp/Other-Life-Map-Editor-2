using System.Runtime.InteropServices;

namespace OtherLife.MapDefinitions.Legacy.Models
{
    /// <summary>Mapheader class, contains file information</summary>
	[StructLayout(LayoutKind.Sequential)]
    public class Header
    {
        // A 4 char-lenght string used to verify
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[] FileSig;

        // The length of tiles in X and Y direction
        public int TileMapXLength, TileMapYLength;

        // The position where the tilemap and heightmap information is stored starts
        public int TileMapOffset, HeightMapOffset;

        // Length of the struct
        public int Obj3DStructLength;

        // Amount of 3D objects
        public int Obj3DNo;

        // The position where the 3d objects information is stored starts
        public int Obj3DOffset;

        // Length of the struct
        public int Obj2DStructLength;

        // Amount of 2D objects
        public int Obj2DNo;

        // The position where the 2d objects information is stored starts
        public int Obj2DOffset;

        // Length of the struct
        public int LightsStructLength;

        // Amount of lights
        public int LightsNo;

        // The position where the lights information is stored starts
        public int LightsOffset;

        // Dungeon map
        public sbyte Dungeon; //no sun

        // Reserved bytes
        public sbyte Res2, Res3, Res4;

        // Ambient color
        public float AmbientR, AmbientG, AmbientB;

        // Length of the struct
        public int ParticlesStructLength;

        // Amount of particles
        public int ParticlesNo;

        // The position where the particles information is stored starts
        public int ParticlesOffset;

        // The position where the clusters information is stored starts 
        public int ClustersOffset;

        // Version number of the map file
        public int VersionNumber;

        // Offset to the terrain map data
        public int TerrainOffset;

        // Reserved bytes
        public int Reserved11,
                   Reserved12,
                   Reserved13,
                   Reserved14,
                   Reserved15,
                   Reserved16,
                   Reserved17;
    }
}
