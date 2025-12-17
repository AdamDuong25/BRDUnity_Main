using UnityEngine;

public class PushBall : MonoBehaviour
{
    public float force = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
        }
    }
}
