using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vektörler : MonoBehaviour
{
    Vector2 vec, vec2, son; 
    // Start is called before the first frame update
    void Start()
    {
        /*
        vec.x = 1;
        vec.y = 1;
        print(vec); */
        vec = new Vector2(5, 3);
        vec2= new Vector2(5,7);
        son = 2*vec + vec2;
        print(son);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
