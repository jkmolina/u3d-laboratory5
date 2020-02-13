using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coin;
    public 
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        coin.Play();
        ScoringSystem.theScore++;
        Destroy(gameObject);
    }
}
