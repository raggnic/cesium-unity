
using Reinterop;
using System;
using Unity.Mathematics;
using UnityEngine;

namespace CesiumForUnity
{
    /// <summary>
    /// Represents a tile footprint
    /// </summary>
    [ReinteropNativeImplementation("CesiumForUnityNative::Cesium3DTileRegionImpl", "Cesium3DTileRegionImpl.h", staticOnly: true)]
    public partial class Cesium3DTileRegion : MonoBehaviour
    {
        internal Cesium3DTileRegion()
        {}

        public double _west;
        public double _south;
        public double _east;
        public double _north;
        public double _minHeight;
        public double _maxHeight;

        public void SetRegion(double west, double south, double east, double north, double minHeight, double maxHeight)
        {
            _west = west;
            _south = south;
            _east = east;
            _north = north;
            _minHeight = minHeight;
            _maxHeight = maxHeight;

        }
    }
}
