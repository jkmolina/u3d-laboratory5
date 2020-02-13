using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{

    public int theScore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * 50 * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Coin"))
    //    {
    //        //coinCounter++;
    //        //scoreText.GetComponent<Text>().text = "Score: " + coinCounter;
    //        //Destroy(other.gameObject);
    //    }
    //}
}

