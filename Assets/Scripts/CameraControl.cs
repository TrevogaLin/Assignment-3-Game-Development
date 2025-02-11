using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform CamTarget;
    public float pLerp = .02f;
    public float rLerp = .01f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, CamTarget.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, CamTarget.rotation, rLerp);
    }
}
