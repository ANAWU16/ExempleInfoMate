using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float vel;

    private Vector2 minPantalla, maxPantalla;

    [SerializeField] private GameObject prefabProjectil;

    // Start is called before the first frame update
    void Start()
    {
        vel = 8f;
        minPantalla = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
        maxPantalla = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        
    }

    // Update is called once per frame
    void Update()
    {
        MoureNau();
        DisparaProjectil();
      
    }
    private void DisparaProjectil()
    {
        if (Input.GetKeyDown("space"))
        {
            GameObject projectil = Instantiate(prefabProjectil);
            projectil.transform.position = transform.position;
        }

    }
    private void MoureNau()
    {
        float direccioIndicadaX = Input.GetAxisRaw("Horizontal");
        float direccioIndicadaY = Input.GetAxisRaw("Vertical");
        //Debug.Log("X :" + direccioIndicadaX + "-Y:" + direccioIndicadaY);
        Vector2 direccioIndicada = new Vector2(direccioIndicadaX, direccioIndicadaY).normalized;


        Vector2 novaPos = transform.position;// transform.position:pos actual de la nau.
        novaPos = novaPos + direccioIndicada * vel * Time.deltaTime;
        //Debug.Log(Time.deltaTime);

        novaPos.x = Mathf.Clamp(novaPos.x, minPantalla.x, maxPantalla.x);
        novaPos.y = Mathf.Clamp(novaPos.y, minPantalla.y, maxPantalla.y);

        transform.position = novaPos;

    }

    private void OnTriggerEnter2D(Collider2D objecteTocat)
    {
        if (objecteTocat.tag == "Numero")
        {
            Destroy(gameObject);
        }
    }

    
}
