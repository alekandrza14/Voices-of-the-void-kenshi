using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fristPersonControler : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject[] g;
    public GameObject gun_point;
    public GameObject gun_bullet;
    public Text st;
    public Text fo;
    public Text GrabHelper;
    public Text moneydrkel;
    public static float stamina = 100;
    public static float food = 100;
    private void OnTriggerStay(Collider other)
    {
        if (PolitDate.IsGoodE(politiceconomic.left)) if (other.GetComponent<PayZone>())
        {
            stamina -= Time.deltaTime / 300;
            food -= Time.deltaTime / 350;
            other.GetComponent<PayZone>().UpdatePay();
        }
        if (other.GetComponent<HealStamina>())
        {
            stamina += Time.deltaTime / 100;
            if (stamina > 100)
            {
                stamina -= Time.deltaTime / 200;
                if (stamina >= 120)
                {
                    stamina = 120;
                }
            }
        }
    }

    void Update()
    {
        if (PolitDate.IsGoodE(politiceconomic.left)) moneydrkel.text = "ꝏ t"; else { moneydrkel.text = "0 t"; }
        st.text = "выносл.:" + System.MathF.Round(stamina,1);
        fo.text = "сытось.:" + System.MathF.Round(food,1);
        food -= Time.deltaTime / 200;
        stamina -= Time.deltaTime / 240;
        Ray r2 = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit2;
        if (Physics.Raycast(r2, out hit2))
        {
            if (hit2.collider != null)
            {
                if (hit2.collider.GetComponent<Rigidbody>())
                {
                  
                    GrabHelper.text = "Взять У";
                }
                else
                {
                    if (GrabHelper.text == "Взять У") GrabHelper.text = "";
                }

            }
            else
            {
                if (GrabHelper.text == "Взять У") GrabHelper.text = "";
            }
        }
        else
        {
            if (GrabHelper.text == "Взять У") GrabHelper.text = "";
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (GrabPoint.grabedObj == null)
            {


                if (Physics.Raycast(r2, out hit2))
                {
                    if (hit2.collider != null)
                    {
                        if (hit2.collider.GetComponent<Rigidbody>())
                        {
                            GrabPoint.grabedObj = hit2.collider.gameObject;

                        }


                    }

                }
            }
            else
            {
                GrabPoint.grabedObj = null;
            }
        }
            Ray r = new Ray(transform.position,Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(r,out hit))
        {
            if (hit.distance <= 1.5f && Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector3.up*(50 * Time.deltaTime), ForceMode.Impulse);
            }
        }
        if(PolitDate.IsGoodE(politiceconomic.right))  if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bulletobj = Instantiate(gun_bullet, gun_point.transform.position, gun_point.transform.rotation);
            Rigidbody bulletphysic = bulletobj.GetComponent<Rigidbody>();
            bulletphysic.AddForce(bulletobj.transform.forward * 80f, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            g[0].transform.Rotate(0, Input.GetAxisRaw("Mouse X") * (150f * Time.fixedDeltaTime), 0);
            g[1].transform.Rotate(-Input.GetAxisRaw("Mouse Y") * (150f * Time.fixedDeltaTime), 0, 0);
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            Cursor.lockState = CursorLockMode.None;
        }
       if((rb.linearVelocity.x+ rb.linearVelocity.z) <= 1) rb.MovePosition( ((transform.right * Input.GetAxisRaw("Horizontal")+ transform.forward * Input.GetAxisRaw("Vertical"))/6) * (Time.deltaTime*60) + transform.position);
      
    }
}
