using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]
    Rigidbody body;

    [SerializeField]
    private GameObject HitFlashObj;

    public float speed;
    private void Start()
    {
        body.AddForce(transform.forward * speed,ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(HitFlashObj, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
