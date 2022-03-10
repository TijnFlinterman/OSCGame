using UnityEngine;
using ZigSimTools;
using Quaternion = UnityEngine.Quaternion;

public class ObjectRotator : MonoBehaviour
{
    private Quaternion targetRotation;
    private Vector3 test;
    private float dampspeed = 0.1f;

    void Start()
    {
        ZigSimDataManager.Instance.StartReceiving();
        ZigSimDataManager.Instance.GravityCallBack += (Gravity q) =>
        {
            Quaternion newRot = Quaternion.Euler(0, 0, (float)q.y * 180);
            targetRotation = newRot;
        };
    }

    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, dampspeed);
    }
}