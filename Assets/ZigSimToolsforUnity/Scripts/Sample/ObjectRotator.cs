using UnityEngine;
using ZigSimTools;
using Quaternion = UnityEngine.Quaternion;

public class ObjectRotator : MonoBehaviour
{
    private Quaternion targetRotation;

    void Start()
    {
        ZigSimDataManager.Instance.StartReceiving();
        ZigSimDataManager.Instance.QuaternionCallBack += (ZigSimTools.Quaternion q) =>
        {
            // Debug.Log (q.ToString ());
            var newQut = new Quaternion(0, (float)-q.z, 0, 0);
            var newRot = newQut * Quaternion.Euler(90f, 0, 0);
            targetRotation = newRot;
        };
    }

    void Update()
    {
        transform.localRotation = targetRotation;
    }
}