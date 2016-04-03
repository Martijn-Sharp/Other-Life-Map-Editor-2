using System.Runtime.InteropServices;

namespace OtherLife.MapDefinitions.Legacy.Models
{
    /// <summary>3D Object class</summary>
	[StructLayout(LayoutKind.Sequential)]
    public class Object3D
    {
        // Relative path to the file
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string FileName;

        // Position of the object
        public float PositionX, PositionY, PositionZ;

        // Rotation of the object
        public float RotationX, RotationY, RotationZ;

        // Indicator if this object3d is selft lit or not
        public sbyte SelfLit;

        // Indicates wether this object3d is blended with some other objects or not
        public sbyte Blended;

        // Padding bytes are inserted here by gcc and so ended up in the map format, make the explicit
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public sbyte[] Pad;

        // Red, green and blue color values of the object
        public float R, G, B;

        // Scaling of the object3d
        public float Scale;

        // Reserved for future expansions
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public sbyte[] Reserved;
    }
}
