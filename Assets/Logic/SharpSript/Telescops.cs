using UnityEngine;

public class Telescops : MonoBehaviour
{
    public TextMesh downloadspeed;
    public GameObject downloading;
    public static float signalBites;
    void Update()
    {
        signalBites -= (Time.deltaTime / 300)*speedDownloading.speed_downloading.Count;
        if (speedDownloading.speed_downloading.Count != 0) downloadspeed.text = speedDownloading.speed_downloading.Count + " бит\\с";
        if (signalBites <= 0) downloading.SetActive(false);else downloading.SetActive(true);
    }
}
