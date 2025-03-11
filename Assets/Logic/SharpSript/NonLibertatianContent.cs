using UnityEngine;

public class NonLibertatianContent : MonoBehaviour
{
    void Start()
    {
        if (PolitDate.IsGoodF(politicfreedom.lidertatian))
        {
            gameObject.SetActive(false);
        }
    }
}
