using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour
{

    private bool fireLit = false;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (fireLit == false)
            {
                gameObject.GetComponentInChildren<ParticleSystem>().Play();
                gameObject.GetComponent<AudioSource>().Play();
                fireLit = true;
            }
        }
    }


}
