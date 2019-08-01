using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trocartuto : MonoBehaviour
{

    public GameObject tutorial1;
    public GameObject tutorial2;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!tutorial1.active)
        {
            tutorial2.SetActive(true);
        }
    }
}
