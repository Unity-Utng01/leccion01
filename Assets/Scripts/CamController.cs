using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    //el gameobjet puede ser un obstaculo
    public GameObject tanque;

    public Vector3 upCam = new Vector3(0,10,-9);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //                              la posicion del tanque + esta otra posicion
        transform.position = tanque.transform.position + upCam;
    }
}
