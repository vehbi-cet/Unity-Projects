using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformkonusu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Vector3 yon;
    public Vector3 rotasyon;
    void Update()
    {
        transform.Translate(yon);
        transform.Rotate(rotasyon);
    }
}