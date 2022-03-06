using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject player;
    public float maxH;
    public float minH;
    public float minW;
    public float maxW;
    public float speed;
    public Animator animacao;

    void Update()
    {
       
        float translationH = Input.GetAxis("Vertical") * speed;
        float translationW = Input.GetAxis("Horizontal") * speed;
        if (translationH != 0 || translationW != 0)
        {
            player.transform.Translate(0, translationH, 0);
            player.transform.Translate(translationW, 0, 0);
            animacao.SetBool("running",true);
        }else
            animacao.SetBool("running", false);

        player.transform.rotation = new Quaternion(0,0,0,0);

        if (player.transform.position.y > maxH)
            player.transform.position = new Vector2(player.transform.position.x, maxH);
        if (player.transform.position.y < minH)
            player.transform.position = new Vector2(player.transform.position.x, minH);
        if (player.transform.position.x > maxW)
            player.transform.position = new Vector2(maxW, player.transform.position.y);
        if (player.transform.position.x < minW)
            player.transform.position = new Vector2(minW, player.transform.position.y);

        if (player.transform.position.y > 4.2f && player.transform.position.x > -9)
            player.transform.position = new Vector2(player.transform.position.x, 4.2f);

        

    }
}
