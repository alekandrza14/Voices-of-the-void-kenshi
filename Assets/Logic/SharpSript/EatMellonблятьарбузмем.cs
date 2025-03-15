using UnityEngine;
using UnityEngine.UI;

public class EatMellonблятьарбузмем : MonoBehaviour
{
    public 
    void Update()
    {
            Ray r2 = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit2;
        if (Physics.Raycast(r2, out hit2))
        {
            if (hit2.collider != null)
            {
                if (hit2.collider.gameObject == gameObject)
                {
                    if (hit2.collider.GetComponent<EatMellonблятьарбузмем>())
                    {
                        if (Input.GetKeyDown(KeyCode.Q))
                        {
                            if (PolitDate.IsVersionE() == politiceconomic.left) fristPersonControler.food += 60;
                            if (PolitDate.IsVersionE() == politiceconomic.right) fristPersonControler.food += 10;
                            if (PolitDate.IsVersionE() == politiceconomic.mind) fristPersonControler.food += 20; 
                            if (PolitDate.IsVersionE() == politiceconomic.bipoly) fristPersonControler.food += 60;
                            if (fristPersonControler.food > 100) fristPersonControler.food = 100;
                            EatHelper.text.text = "";
                            Destroy(gameObject);
                        }
                        EatHelper.text.text = "Слопать Й";
                    }
                    else
                    {
                        if (EatHelper.text.text == "Слопать Й") EatHelper.text.text = "";
                    }
                }
                else
                {
                    if (EatHelper.text.text == "Слопать Й") EatHelper.text.text = "";
                }

            }
            else
            {
                if (EatHelper.text.text == "Слопать Й") EatHelper.text.text = "";
            }
        }
        else
        {
            if (EatHelper.text.text == "Слопать Й") EatHelper.text.text = "";
        }
       
    }
    private void OnDestroy()
    {
        EatHelper.text.text = "";
    }
}
