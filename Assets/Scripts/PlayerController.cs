using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    PlayerController sharedInstance;
    public float horizontalInput;
    public float xRange = 23f;
    public GameObject prefabProyectile;

    private void Awake()
    {
        sharedInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        //Para no dejar que el granjero salga de -xRange
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Para no dejar que el granjero salga de xRange
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //Proyectil
        if (Input.GetKey(KeyCode.Space))
        {
            //Si hemos pulsado la tecla de espacio, tiene que generarse un proyectil
            //Primero tenemos que instanciar un proyectil que está guardado en prefabProyectile
            Instantiate(prefabProyectile, transform.position, prefabProyectile.transform.rotation);
        }
    }
}
