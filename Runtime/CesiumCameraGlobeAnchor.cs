using System;
using System.Collections;
using System.Collections.Generic;
using CesiumForUnity;
using Unity.Mathematics;
using UnityEngine;

public class CesiumCameraGlobeAnchor : MonoBehaviour
{
    public  CesiumGlobeAnchor cameraGlobeAnchor;
    public  CesiumGlobeAnchor ownGlobeAnchor;

    public CesiumGeoreference cesiumGeoreference;
    
    public double referenceheight = 100;
    
    private double3 ownGeoRef;

    private void LateUpdate()
    {
        ownGeoRef[0] = cameraGlobeAnchor.longitudeLatitudeHeight[0];
        ownGeoRef[1] = cameraGlobeAnchor.longitudeLatitudeHeight[1];
        //ownGeoRef[2] = cesiumGeoreference.CurrentMinHeight;
        ownGeoRef[2] = 0;
          
        cesiumGeoreference.transform.localScale = Vector3.one* (float) (referenceheight / cameraGlobeAnchor.longitudeLatitudeHeight[2]);
        ownGlobeAnchor.longitudeLatitudeHeight = ownGeoRef;
        
    }
}
