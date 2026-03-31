using UnityEngine;

public class CastAbilty1 : MonoBehaviour
{

    [SerializeField]
    GameObject ability1;

    bool flip;
    public void OnAbility1()
    {
        flip = !flip;
        ability1.SetActive(flip);
    }
}
