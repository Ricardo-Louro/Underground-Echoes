using UnityEngine;

public class GhostGirlCrawlSpeed : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private Transform maxDistance;
    
    private Vector3 direction;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        direction = new Vector3(0, 0, 1);
    }

    private void Update()
    {
        if(transform.position.z >= maxDistance.position.z)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = direction * (speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerMovement>() != null)
        {
            Destroy(gameObject);
        }
    }
}
