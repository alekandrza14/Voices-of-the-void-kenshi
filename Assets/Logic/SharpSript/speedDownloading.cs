
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class speedDownloading : MonoBehaviour
{
    public GameObject[] objs;
    public int activechastey;
    public Material correctmaterial;
    public static List<speedDownloading> speed_downloading = new List<speedDownloading>();
    void Update()
    {
        int activechasteynow = 0;
        foreach (GameObject item in objs)
        {
            if(item.GetComponent<Collider>().isTrigger == false)
            {
                activechasteynow++;
            }
        }
        activechastey = activechasteynow;
        if (activechastey == objs.Length-1)
        {
            if (!speed_downloading.Contains(this))
            {
                speed_downloading.Add(this);
            }
        }
    }
}
