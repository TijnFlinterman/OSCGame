using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollower : MonoBehaviour
{
    public Transform objectToFollow;
    public float offset;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, objectToFollow.position.z + 200);
    }
}
