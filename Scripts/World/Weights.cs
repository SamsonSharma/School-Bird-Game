using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weights : MonoBehaviour
{

    public ParticleSystem ps;
   

  

    void OnCollisionEnter2D(Collision2D col)
    {
       if(col.gameObject.CompareTag("floor"))
        {
            ps.Play();
            
        }
    }


}
