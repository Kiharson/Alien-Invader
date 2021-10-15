using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombRow : MonoBehaviour
{
    public GameObject parent;
    public bool isLowest;

    public GameObject bombPrefab;
    public int timeToSpawn;
    public int time;

    public GameController gameController;

    public void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();

        timeToSpawn = (5 - (int)gameController.speed) * 100;
        time = timeToSpawn;
    }

    public void Update()
    {
        if (isLowest)
        {
            if (time == 0)
            {
                int index = Random.Range(0, transform.childCount);
                GameObject bomb = Instantiate(bombPrefab);
                bomb.transform.SetParent(GameObject.Find("Canvas").GetComponent<Transform>());
                bomb.transform.localScale = new Vector3(25, 25, 1);
                bomb.transform.localPosition = new Vector2(parent.transform.localPosition.x + transform.GetChild(index).transform.localPosition.x, parent.transform.localPosition.y + gameObject.transform.localPosition.y - 50);

                time = timeToSpawn;
            }
            else time--;

            if (transform.childCount == 0)
            {
                Destroy(this.gameObject);
            }
        }
        
        
    }
}
