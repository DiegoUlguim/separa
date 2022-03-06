using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
    public float speed;
    public float maxH;
    public float minH;
    public float minW;
    public float maxW;
    public Animator animacao;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            

            transform.position = new Vector3(transform.position.x, transform.position.y);

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                animacao.SetBool("running", true);
                Vector2 touchPosition = Input.GetTouch(0).deltaPosition;
                transform.Translate(touchPosition.x * speed * Time.deltaTime, touchPosition.y * speed * Time.deltaTime,0);
            }
            else
                animacao.SetBool("running", false);

            if (transform.position.y > maxH)
                transform.position = new Vector2(transform.position.x, maxH);
            if (transform.position.y < minH)
                transform.position = new Vector2(transform.position.x, minH);
            if (transform.position.x > maxW)
                transform.position = new Vector2(maxW, transform.position.y);
            if (transform.position.x < minW)
                transform.position = new Vector2(minW, transform.position.y);

            if (transform.position.y > 4.2f && transform.position.x > -9)
                transform.position = new Vector2(transform.position.x, 4.2f);

        }

       
    }
}
