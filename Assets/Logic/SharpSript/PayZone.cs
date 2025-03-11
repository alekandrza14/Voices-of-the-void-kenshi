using UnityEngine;

public class PayZone : MonoBehaviour
{
    private float views;
    public GameObject unlockProduct;
    public void UpdatePay()
    {
        views += Time.deltaTime / 300;
        if (views > 10)
        {
            unlockProduct.SetActive(true);
            views = 0;
        }
    }
}
