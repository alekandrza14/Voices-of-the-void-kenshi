using UnityEngine;

public class RightBarrier : MonoBehaviour
{
    void Start()
    {
        if (PolitDate.IsVersionE() != politiceconomic.right)
        {
            gameObject.SetActive(false);
        }
    }
}
