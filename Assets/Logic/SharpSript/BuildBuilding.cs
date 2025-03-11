using UnityEngine;

public class BuildBuilding : MonoBehaviour
{
    public Material postBuild;
    public LayerMask offData;
    bool Builded;
    private void OnTriggerEnter(Collider other)
    {
        if (other!= null&& !Builded)
        {
            Destroy(other.gameObject);
            GetComponent<Renderer>().sharedMaterials = new Material[] { postBuild };
            GetComponent<Collider>().isTrigger = false;
            GetComponent<Collider>().excludeLayers = offData;
            GetComponent<Collider>().includeLayers = offData;
            Destroy(GetComponent<Rigidbody>());
            Builded = true;
        }
    }
}
