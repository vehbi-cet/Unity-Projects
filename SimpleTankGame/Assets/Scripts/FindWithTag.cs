using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*GameObject.FindGameObjectWithTag("Ozel").GetComponent<Light>().intensity = 0;
        GameObject.FindGameObjectWithTag("Ozel2").SetActive(false); */
        GameObject.Find("Kapsul2").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
