//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerJumpScript : MonoBehaviour
//{
//    public Transform GroundCheck;
//    public float groundDistance = 0.4f;
//    public LayerMask groundMask;

//    bool isGrounded;
//    public float gravity = -9.81f;
//    public float jumpHeight = 3f;
//    Vector3 velocity;

//    void Update()
//    {
//        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);

//        if (Input.GetButtonDown("Jump") && isGrounded)
//        {
//            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
//        }
//    }
//}
