using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform position;
    public GameObject pelota;

    //update is called once per frame
    void Update()
    {

        if (!Movimiento.isAlive)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                //Destroy(pelota);
                Instantiate(pelota, new Vector3(-9, 1, -4), Quaternion.identity);
                Movimiento.isAlive = !Movimiento.isAlive;
            }
        }


    }




}