using UnityEngine;
using ZigSimTools;
using Quaternion = UnityEngine.Quaternion;

public class ObjectRotator : MonoBehaviour
{
    private Quaternion targetRotation;
    private Vector3 test;

    void Start ()
    {
        ZigSimDataManager.Instance.StartReceiving ();
        ZigSimDataManager.Instance.GravityCallBack += (Gravity q) =>
        {
            Quaternion newRot = Quaternion.Euler (0, 0, (float)q.z * 360);
            targetRotation = newRot;
        };
    }

    void Update ()
    {
        transform.localRotation = targetRotation;
    }
    public static Quaternion SmoothDampQuaternion(Quaternion current, Quaternion target, ref Vector3 currentVelocity, float smoothTime)
    {
        Vector3 c = current.eulerAngles;
        Vector3 t = target.eulerAngles;
        return Quaternion.Euler(
          Mathf.SmoothDampAngle(c.x, t.x, ref currentVelocity.x, smoothTime),
          Mathf.SmoothDampAngle(c.y, t.y, ref currentVelocity.y, smoothTime),
          Mathf.SmoothDampAngle(c.z, t.z, ref currentVelocity.z, smoothTime)
        );
    }
}