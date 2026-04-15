using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]
    Rigidbody body;

    [SerializeField]
    private GameObject HitFlashObj;

    private GameObject HitFlashRef;

    public float speed;
    private void Start()
    {
        body.AddForce(transform.forward * speed,ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        HitFlashRef = Instantiate(HitFlashObj, transform.position, Quaternion.identity);
        HitFlashRef.transform.rotation = collision.transform.rotation;
        Destroy(this.gameObject);
    }
}
