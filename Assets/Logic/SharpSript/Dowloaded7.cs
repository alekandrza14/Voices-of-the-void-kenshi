using UnityEngine;

public class Dowloaded7 : MonoBehaviour
{
    public GameObject offdata;
    void Update()
    {
        if (Telescops.signalBites <= 0) offdata.SetActive(true); else offdata.SetActive(false);
    }
}
