using UnityEngine;
using UnityOSC;

public class OSCtest : MonoBehaviour
{
    [SerializeField] private OSC osc;

    private void Start()
    {
        osc.SetAddressHandler("/ZIGSIM/569a2fa1-6ee5-4b50-ac32-9173ec009254/gyro", Receive);
    }

    void Receive(OscMessage msg)
    {
        Debug.Log(msg);
        //float x = msg.GetFloat(0);
        //Debug.Log($"[{msg.ip}]: " + x);
    }
}