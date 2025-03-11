using UnityEngine;

public class IlegalDeath : MonoBehaviour
{
    static GameObject IlegalNadpis;
    private void Start()
    {
      if(IlegalNadpis==null)  IlegalNadpis = Resources.Load<GameObject>("IlegalText");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Bullets>())
        {
            Instantiate(IlegalNadpis);
            Destroy(gameObject);
        }
    }
}
