using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Vector3 vector3;
    // Start is called before the first frame update
    void Start()
    {
        vector3= new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            transform.Translate(vector3);
            GetComponent<Light>().intensity= 100f;
        }

    }
}
