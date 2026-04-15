using UnityEngine;

public class ExitScreenScript : MonoBehaviour
{
    [SerializeField]
    GameObject correctCamera;

    [SerializeField]
    GameObject HUD;

    void OnExitScreen()
    {
        correctCamera.SetActive(true);
        HUD.SetActive(true);
    }
}
