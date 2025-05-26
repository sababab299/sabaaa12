using UnityEngine;

public class ShootWithRaycast1 : MonoBehaviour
{
    [SerializeField]
    public GameObject ball;
    [SerializeField]
    private float raycastLength;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, raycastLength))
            {
                 Instantiate(ball, hit.point, Quaternion.identity);
            };
        }
        Debug.DrawRay(transform.position, transform.forward * raycastLength, Color.blue);
    }
}
