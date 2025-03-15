using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    [SerializeField] Material material;
    [SerializeField] politiceconomic _if_economyc;
    void Start()
    {
       if(PolitDate.IsGoodE(_if_economyc)) GetComponent<MeshRenderer>().material = material;
    }
}
