using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class DitheringControl : MonoBehaviour
{
    [SerializeField]

    SkinnedMeshRenderer DitherableMesh;

    Material DitherableMaterial;

    [SerializeField]
    float CameraIdealDistance;

    [SerializeField]
    float CameraDitherDistance;

    [SerializeField]
    float CameraDitherHeur;

    private void Start()
    {
        DitherableMaterial = DitherableMesh.material;
        Debug.Log(DitherableMaterial.name);

    }
    // Update is called once per frame
    void Update()
    {

        CameraDitherDistance = Vector3.Distance(DitherableMesh.gameObject.transform.position, Camera.main.transform.position);
        Debug.Log(CameraDitherDistance);


        float value =  CameraDitherDistance - CameraIdealDistance;

        value += CameraDitherHeur;

        Debug.Log("Value: "+ value);


        DitherableMaterial.SetFloat("_DitherStrength", value);
    }
}
