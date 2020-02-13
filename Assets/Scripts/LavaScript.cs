using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LavaScript : MonoBehaviour
{
    public GameObject newObj;
    public Text scoreText;
    public static int coinCounter;
    public AudioSource death;



    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
          
 
        if (ScoringSystem.theScore != 3 && other.gameObject.CompareTag("Lava"))
        {
            //gameObject.transform.position = new Vector3(-9, -2, -4);
            Movimiento.isAlive = false;
            Destroy(gameObject);
        }

    }

}
