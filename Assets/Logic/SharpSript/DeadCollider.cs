using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadCollider : MonoBehaviour
{
    public GameObject saund��������;
    void OnTriggerExit(Collider other)
    {
        if (PolitDate.IsGoodE(politiceconomic.right)) if (other.GetComponent<fristPersonControler>())
        {
            Instantiate(saund��������);
            StartCoroutine(corutineExitGame());
        }
    }
    IEnumerator corutineExitGame()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
