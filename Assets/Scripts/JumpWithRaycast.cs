using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class JumpWithRaycast : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float JumpForce;
    [SerializeField]
    private float groundDistance;
    [SerializeField]
    private LayerMask groundMask;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded()) 
        {
            rb.AddForce(Vector2.up * JumpForce);
        }  
    }
    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, groundDistance, 1<<3 | 1 << 4);
    }
}
