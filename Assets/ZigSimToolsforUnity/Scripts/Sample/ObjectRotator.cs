using UnityEngine;
using ZigSimTools;
using Quaternion = UnityEngine.Quaternion;

public class ObjectRotator : MonoBehaviour
{
    private Quaternion targetRotation;

    void Start ()
    {
        ZigSimDataManager.Instance.StartReceiving ();
        ZigSimDataManager.Instance.QuaternionCallBack += (ZigSimTools.Quaternion q) =>
        {
            Quaternion newRot = Quaternion.Euler (0, 0, (float)q.z * 180);
            targetRotation = newRot;
        };
    }

    void Update ()
    {
        transform.localRotation = targetRotation;
    }
}