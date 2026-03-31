using UnityEngine;

public class FIrearm : MonoBehaviour
{

    [SerializeField]
    private GameObject bulletObj;

    public GameObject bulletRef;

    public Transform bulletOrigin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAttack()
    {

            bulletRef = Instantiate(bulletObj, bulletOrigin.position, bulletOrigin.rotation);

    }
}
