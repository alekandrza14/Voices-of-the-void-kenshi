using UnityEngine;

[CreateAssetMenu(fileName = "StarObject", menuName = "Votvk/StarSignal")]
public class StarObject : ScriptableObject
{
    public string nameStar;
    public string descriptionStar;
    public int signalBites = 10;
    public Material ImgStar;
}
