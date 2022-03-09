using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using ZigSimTools;
using Touch = UnityEngine.Touch;

public class PlayerJumpScript : MonoBehaviour
{
    public Transform GroundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float movementSpeed = 5f;

    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public CharacterController characterController;

    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        ZigSimDataManager.Instance.StartReceiving();
        ZigSimDataManager.Instance.TouchCallBack += (ZigSimTools.Touch[] touches) =>
        {
            int count = 0;
            foreach (ZigSimTools.Touch t in touches)
            {
                OnJump();
                count++;
            }
        };
    }

    private void Update()
    {
        characterController.Move(velocity * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        Vector3 move = transform.forward * movementSpeed;
        velocity.z = move.z;

    }

    public void OnJump()
    {
        isGrounded = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);
    
        if (isGrounded == true)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }
} 
