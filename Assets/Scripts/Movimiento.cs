using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimiento : MonoBehaviour
{
    public float force = 5;
    public float forceJump = 4;
    private Rigidbody rb;
    public GameObject newObj;
    public static bool isAlive = true;
    public static bool onPause=false;
    public AudioSource jump;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (onPause==false)
        {
            if (Input.GetButtonDown("Jump"))
                Saltar();
        }


            RaycastHit hitInfo;

            if (Physics.Raycast(transform.position, Vector3.down, out hitInfo, 3.0f))
            {
                //Destroy(hitInfo.collider.gameObject);
            }
        
    }
    private void FixedUpdate()
    {
        if (rb)
        {
            rb.AddForce(Input.GetAxis("Horizontal") * force, 0, Input.GetAxis("Vertical") * force);
        }
    }

    private void Saltar()
    {
        //bool pause = GameObject.Find("Game Manager").GetComponent<Spawn>().IsPaused;
        if (rb && Mathf.Abs(rb.velocity.y) < 0.05f)
        {
            rb.AddForce(0, forceJump, 0, ForceMode.Impulse);
            jump.Play();
        }

    }



    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("Chocaron");
    }

    }



