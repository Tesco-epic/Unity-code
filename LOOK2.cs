using UnityEngine;

public class LOOK2 : MonoBehaviour
{
    public Transform miku;
    public Transform Camera;

    // Update is called once per frame
    void Update()
    {
        miku.forward = Vector3.ProjectOnPlane(Camera.forward, miku.up).normalized;
    }
}
