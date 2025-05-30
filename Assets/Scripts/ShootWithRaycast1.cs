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
            RaycastHit[] hits = Physics.RaycastAll(transform.position, transform.forward, raycastLength);
            Debug.Log(hits.Length);
            foreach (RaycastHit hit in hits)
            {
                Instantiate(ball, hit.point, Quaternion.identity);

                MeshRenderer meshRenderer = hit.transform.GetComponent<MeshRenderer>();
                if (meshRenderer != null)
                {
                    meshRenderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                }
            }
        }
        Debug.DrawRay(transform.position, transform.forward * raycastLength, Color.blue);
    }
}
