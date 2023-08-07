using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnCollisionEnter(Collision col)
     {
         print(col.gameObject.name);
     }

   /* private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " ile temasa ge�ildi");
    }*/
}
