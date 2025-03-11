using UnityEngine;

public class NonAvtoritarianContent : MonoBehaviour
{
    void Start()
    {
        if(PolitDate.IsGoodF(politicfreedom.avtoritatian))
        {
            gameObject.SetActive(false);
        }
    }
}
