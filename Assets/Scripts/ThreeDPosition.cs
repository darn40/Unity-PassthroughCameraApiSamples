using Meta.XR;
using UnityEngine;
using PassthroughCameraSamples;

public class ThreeDPosition : MonoBehaviour
{
    internal EnvironmentRaycastManager m_environmentRaycastManager; //to define
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /// <summary>
    /// Returns a 3D coordinate in the world space of the 2D screenPoint
    /// Use raycast manager to have a good estimation of the point 3d coordinate
    /// </summary>
    /// <param name="cameraEye">The passthrough camera</param>
    /// <param name="screenPoint">A 2D point on the camera texture. The point is positioned relative to the
    ///     maximum available camera resolution. This resolution can be obtained using <see cref="GetCameraIntrinsics"/>
    ///     or <see cref="GetOutputSizes"/> methods.
    /// </param>
    public Vector3 ScreenPointTo3dPoint(PassthroughCameraEye cameraEye, Vector2Int screenPoint)
    {
        var ray = PassthroughCameraUtils.ScreenPointToRayInWorld(cameraEye, screenPoint);
        bool res = m_environmentRaycastManager.Raycast(ray, out EnvironmentRaycastHit hitInfo);
        return hitInfo.point;
    }
}
