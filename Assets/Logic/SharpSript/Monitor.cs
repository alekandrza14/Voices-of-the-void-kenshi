using UnityEngine;

public class Monitor : MonoBehaviour
{
    public MeshRenderer _starImg;
    public TextMesh _nameStar;
    public TextMesh _discriptionStar;
    public static MeshRenderer starImg;
    public static TextMesh nameStar;
    public static TextMesh discriptionStar;
    private void Start()
    {
        starImg = _starImg;
        nameStar = _nameStar;
        discriptionStar = _discriptionStar;
    }
}
