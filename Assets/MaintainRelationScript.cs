using UnityEngine;

public class MaintainRelationScript : MonoBehaviour
{

    private Vector3 Offset;

    [SerializeField]
    private Transform maintain;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Offset = maintain.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = maintain.position + Offset;
    }
}
