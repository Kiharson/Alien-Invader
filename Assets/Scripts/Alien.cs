using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    private AlienWaveSpawner alienWaveSpawner;
    void Start()
    {
        alienWaveSpawner = GameObject.Find("AlienWaveSpawner").GetComponent<AlienWaveSpawner>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            alienWaveSpawner.alienCount--;
            //gameObject.GetComponentInParent<BombRow>().childrenLength--;
            Destroy(this.gameObject);
        }
    }
}
