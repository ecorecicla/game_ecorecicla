using System.Collections;
using UnityEngine;

public class Meta : MonoBehaviour {
    public Manager estado;
    public GameObject UIGamePlay;
    public GameObject UIGameWin;
    // Use this for initialization
    private void OnTriggernEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("Ganaste");
            estado.m_estado = "GANASTE";
            UIGamePlay.SetActive(false);
            UIGameWin.SetActive(true);

            estado.m_estado = "";
        }
        
    }
}
