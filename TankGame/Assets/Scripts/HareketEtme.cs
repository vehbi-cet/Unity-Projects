using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketEtme : MonoBehaviour
{
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 playerInput = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 hizEklentisi = playerInput * Time.deltaTime * speed;
        transform.Translate(hizEklentisi);
    }
}

