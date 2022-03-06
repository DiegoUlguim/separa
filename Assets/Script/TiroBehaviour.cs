using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroBehaviour : MonoBehaviour
{
    public float speed;
    public bool atira = false;
    public float activeColider;


    void Update()
    {
        if (atira == true) { 
            gameObject.transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
            if (gameObject.transform.position.x > activeColider)
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }

            //GameObject player = GameObject.Find("MapaGeral/Game/PlayerControl/Player");
            //GameObject playerControl = GameObject.Find("MapaGeral/Game/PlayerControl");

            //player.GetComponent<Controle>().maxH = 7.1f;
            //playerControl.GetComponent<MovePlayer>().maxH = 7.1f;
        }
        else
        {
            GameObject player = GameObject.Find("MapaGeral/Game/PlayerControl/Player");
            GameObject playerControl = GameObject.Find("MapaGeral/Game/PlayerControl");

            //player.GetComponent<Controle>().maxH = 4.2f;
            //playerControl.GetComponent<MovePlayer>().maxH = 4.2f;
            if (transform.position != player.transform.position)
                gameObject.transform.position = new Vector3(player.transform.position.x+1.5f,player.transform.position.y);
        }
    }
}
