using System.Runtime.InteropServices;

namespace OtherLife.MapDefinitions.Legacy.File
{
    /// <summary>2D Object class</summary>
	[StructLayout(LayoutKind.Sequential)]
    public class Object2DStructure
    {
        /// <summary>Relative path to the file</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string FileName;
        
        /// <summary>Position of the object</summary>
        public float PositionX, PositionY, PositionZ;
        
        /// <summary>Rotation of the object</summary>
        public float RotationX, RotationY, RotationZ;
        
        /// <summary>Reserved bytes</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public sbyte[] Reserved;
    }
}
