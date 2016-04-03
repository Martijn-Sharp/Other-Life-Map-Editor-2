using System.Runtime.InteropServices;

namespace OtherLife.MapDefinitions.Legacy.File
{
    /// <summary>Mapheader class, contains file information</summary>
	[StructLayout(LayoutKind.Sequential)]
    public class MapHeaderStructure
    {
        /// <summary>A 4 char-lenght string used to verify</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[] FileSig;
        
        /// <summary>The length of tiles in X and Y direction</summary>
        public int TileMapXLength, TileMapYLength;
        
        /// <summary>The position where the tilemap and heightmap information is stored starts</summary>
        public int TileMapOffset, HeightMapOffset;
        
        /// <summary>Length of the struct</summary>
        public int Obj3DStructLength;
        
        /// <summary>Amount of 3D objects</summary>
        public int Obj3DNo;
        
        /// <summary>The position where the 3d objects information is stored starts</summary>
        public int Obj3DOffset;
        
        /// <summary>Length of the struct</summary>
        public int Obj2DStructLength;
        
        /// <summary>Amount of 2D objects</summary>
        public int Obj2DNo;
        
        /// <summary>The position where the 2d objects information is stored starts</summary>
        public int Obj2DOffset;
        
        /// <summary>Length of the struct</summary>
        public int LightsStructLength;
        
        /// <summary>Amount of lights</summary>
        public int LightsNo;
        
        /// <summary>The position where the lights information is stored starts</summary>
        public int LightsOffset;

        /// <summary>Dungeon map</summary>
        /// <remarks>no sun</remarks>
        public sbyte Dungeon;
        
        /// <summary>Reserved bytes</summary>
        public sbyte Res2, Res3, Res4;
        
        /// <summary>Ambient color</summary>
        public float AmbientR, AmbientG, AmbientB;
        
        /// <summary>Length of the struct</summary>
        public int ParticlesStructLength;
        
        /// <summary>Amount of particles</summary>
        public int ParticlesNo;
        
        /// <summary>The position where the particles information is stored starts</summary>
        public int ParticlesOffset;
        
        /// <summary>The position where the clusters information is stored starts </summary>
        public int ClustersOffset;
        
        /// <summary>Version number of the map file</summary>
        public int VersionNumber;
        
        /// <summary>Offset to the terrain map data</summary>
        public int TerrainOffset;
        
        /// <summary>Reserved bytes</summary>
        public int Reserved11,
                   Reserved12,
                   Reserved13,
                   Reserved14,
                   Reserved15,
                   Reserved16,
                   Reserved17;
    }
}
