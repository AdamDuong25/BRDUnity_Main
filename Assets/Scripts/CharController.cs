using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
  // Motion
  public float speed = 5f;
  public float rotationSpeed = 10f;

  // Jump & Gravity
  public float jumpHeight = 2f;
  public float gravity = -9.81f;

  // Ground Check
  public Transform groundCheck;
  public float groundDistance = 0.4f;
  public LayerMask groundLayer;

  private Vector3 velocity;
  private bool isGrounded;
  public CharacterController controller;
  private Transform cam;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  private void Start()
  {
    controller = GetComponent<CharacterController>();
    Cursor.lockState = CursorLockMode.Locked;

    // Main camera MUST have the tag "MainCamera"
    cam = Camera.main.transform;
  }

  // Update is called once per frame
  void Update()
  {
    float x = Input.GetAxisRaw("Horizontal");
    float z = Input.GetAxisRaw("Vertical");

    // Camera-bound oreintations (no y-components)
    Vector3 camForward = cam.forward; camForward.y = 0f;
    camForward.Normalize();
    Vector3 camRight = cam.right; camRight.y = 0f;
    camRight.Normalize();
    Vector3 moveDir = (camForward * z + camRight * x).normalized;
    controller.Move(moveDir * speed * Time.deltaTime);

    // Grounded?
    isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayer);
    if (isGrounded && velocity.y < 0f)
      velocity.y = -2f;

    // Jump
    if (isGrounded && Input.GetButtonDown("Jump"))
      velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

    // Gravity
    velocity.y += gravity * Time.deltaTime;

    // Vertical Motion
    controller.Move(velocity * Time.deltaTime);

    // Pivot character in direction of movement
    if (moveDir.magnitude > 0.1f)
    {
      Quaternion targetRotation = Quaternion.LookRotation(moveDir);
      transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
  }

  //void Update()
  //{
  //float xInput = Input.GetAxisRaw("Horizontal");
  //float zInput = Input.GetAxisRaw("Vertical");
  //Vector3 movement = new Vector3(xInput, 0, zInput) * speed * Time.deltaTime;
  //controller.Move(movement);
  //}
}
