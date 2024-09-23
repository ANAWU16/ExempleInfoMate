using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float vel;

    // Start is called before the first frame update
    void Start()
    {
        vel = 8f;
        
    }

    // Update is called once per frame
    void Update()
    {
        float direccioIndicadaX = Input.GetAxisRaw("Horizontal");
        float direccioIndicadaY = Input.GetAxisRaw("Vertical");
        //Debug.Log("X :" + direccioIndicadaX + "-Y:" + direccioIndicadaY);
        Vector2 direccioIndicada = new Vector2(direccioIndicadaX,direccioIndicadaY).normalized;


        Vector2 novaPos = transform.position;// transform.position:pos actual de la nau.
        novaPos = novaPos + direccioIndicada * vel * Time.deltaTime;
        //Debug.Log(Time.deltaTime);
        transform.position = novaPos;
    }
}
