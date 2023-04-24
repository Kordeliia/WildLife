using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //Eliminaremos objetos para impedir sobresaturar de objetos innecesarios
    private float topBound = 40f;
    private float lowerBound = -15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool cond1 = (this.transform.position.z > topBound);
        bool cond2 = (this.transform.position.z < lowerBound);
        if (cond1)
        { Destroy(this.gameObject); }
        if(cond2)
        {
            Debug.Log("GAME OVER!!!!");
            Destroy(this.gameObject);
            Time.timeScale = 0f;
        }
    }
}
