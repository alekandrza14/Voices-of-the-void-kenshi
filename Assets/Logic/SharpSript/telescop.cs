using UnityEngine;
using UnityEngine.UI;

public class telescop : MonoBehaviour
{
    public Collider player;
    public Text StarHelper;
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<fristPersonControler>())
        {
            player = other;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<fristPersonControler>())
        {
            player = other;
        }
    }
    private void Start()
    {
    }
    private void Update()
    {
        if (player)
        {
            Ray r2 = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit2;
            if (Physics.Raycast(r2, out hit2))
            {
                if (hit2.collider != null)
                {
                    if (hit2.collider.GetComponent<Star>())
                    {
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            Monitor.discriptionStar.text = hit2.collider.GetComponent<Star>().Signal.descriptionStar;
                            Monitor.nameStar.text = hit2.collider.GetComponent<Star>().Signal.nameStar;
                            Monitor.starImg.material = hit2.collider.GetComponent<Star>().Signal.ImgStar;
                            Telescops.signalBites = hit2.collider.GetComponent<Star>().Signal.signalBites;
                        }
                        StarHelper.text = "Сохранить звезду У";
                    }
                    else
                    {
                        if (StarHelper.text == "Сохранить звезду У") StarHelper.text = "";
                    }

                }
                else
                {
                    if (StarHelper.text == "Сохранить звезду У") StarHelper.text = "";
                }
            }
            else
            {
                if (StarHelper.text == "Сохранить звезду У") StarHelper.text = "";
            }
        }
    }

}
