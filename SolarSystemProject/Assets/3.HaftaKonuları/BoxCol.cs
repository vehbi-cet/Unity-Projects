using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       print(GetComponent<BoxCollider>().bounds.min.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
