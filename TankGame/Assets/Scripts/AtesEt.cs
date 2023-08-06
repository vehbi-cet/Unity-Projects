using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEt : MonoBehaviour
{
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(Camera.main.transform.position,transform.forward,out hit, Mathf.Infinity))
            {
                if(hit.collider.gameObject.tag=="dusman")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
