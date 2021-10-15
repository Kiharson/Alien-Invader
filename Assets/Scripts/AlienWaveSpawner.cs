using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienWaveSpawner : MonoBehaviour
{
    public GameObject alienWave;
    public int alienCount = 0;

    public GameController gameController;

    public void Update()
    {
        if (alienCount == 0)
        {
            alienCount = 50;
            GameObject wave = Instantiate(alienWave, GameObject.Find("Canvas").transform);
            wave.transform.localPosition = gameObject.transform.localPosition;
            wave.transform.localScale = Vector3.one;

            if (gameController.speed < 5)
            {
                gameController.speed += 0.5f;
            }
            //gameController.wavesKilled++;
        }
    }
}
