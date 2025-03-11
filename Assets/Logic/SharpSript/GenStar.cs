using UnityEngine;

public class GenStar : MonoBehaviour
{
    int count = 100;
    System.Random rand = new System.Random();
    GameObject star;
    StarObject[] AllSatars;
    void Start()
    {
        AllSatars = Resources.LoadAll<StarObject>("Stars");
        star = Resources.Load<GameObject>("star");
        for (int i=0;i<count;i++)
        {
          Star obj = Instantiate(star,transform.position+new Vector3(0+rand.Next(-1000,1000),1000 + rand.Next(-1000, 1000), 0 + rand.Next(-1000, 1000)),Quaternion.identity).GetComponent<Star>();
            obj.Signal = AllSatars[rand.Next(0, AllSatars.Length)];
        }
    }
}
