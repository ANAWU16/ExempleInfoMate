using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilJugador : MonoBehaviour
{
    private float vel;
    private Vector2 maxPantalla;

    // Start is called before the first frame update
    void Start()
    {
        vel = 10f;
        maxPantalla = Camera.main.ViewportToWorldPoint(new Vector2(1,1));

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 posInicial = transform.position;
        posInicial = posInicial + new Vector2(x:0, y:1)*vel*Time.deltaTime;
        transform.position = posInicial;

        if (transform.position.y>maxPantalla.y)
            {
            Destroy(gameObject);
        }
    }
}
