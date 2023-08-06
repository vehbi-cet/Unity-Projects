using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxiss : MonoBehaviour
{
    private float deger, deger2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deger = (Input.GetAxis("Horizontal"));
        deger2 = (Input.GetAxis("Vertical"));
        if(deger>0)
        {
            print("D veya sağ ok tuşuna bastiniz");
        }else if(deger < 0)
        {
            print("A veya sol ok tuşuna bastiniz");
        }else
        {
            print("Hiç tusa basmadiniz veya A- sol ok tusu");
        }

        if(deger2 > 0)
        {
            print("W veya Yukari ok tuşuna bastiniz");
        }else if(deger2 < 0)
        {
            print("S veya aşaği ok tuşuna bastiniz");
        }

        //print(Input.GetAxisRaw("Horizontal"));
    }
}
