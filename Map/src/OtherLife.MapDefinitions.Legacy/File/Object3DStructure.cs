namespace OtherLife.MapDefinitions.Legacy.File
{
    using System.Runtime.InteropServices;

    /// <summary>3D Object class</summary>
    [StructLayout(LayoutKind.Sequential)]
    public class Object3DStructure
    {
        /// <summary>Relative path to the file</summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string FileName;
        
        /// <summary>Position of the object</summary>
        public float PositionX, PositionY, PositionZ;
        
        /// <summary>Rotation of the object</summary>
        public float RotationX, RotationY, RotationZ;
        
        /// <summary>Indicator if this object3d is selft lit or not</summary>
        public sbyte SelfLit;
        
        /// <summary>Indicates wether this object3d is blended with some other objects or not</summary>
        public sbyte Blended;
        
        /// <summary>Padding bytes are inserted here by gcc and so ended up in the map format, make the explicit</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public sbyte[] Pad;
        
        /// <summary>Red, green and blue color values of the object</summary>
        public float R, G, B;
        
        /// <summary>Scaling of the object3d</summary>
        public float Scale;
        
        /// <summary>Reserved for future expansions</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public sbyte[] Reserved;
    }
}
