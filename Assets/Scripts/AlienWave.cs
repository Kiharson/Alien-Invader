using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienWave : MonoBehaviour
{
    private GameController gameController;

    private Vector2 direction = Vector2.right;

    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }
    void Update()
    {
        if (transform.childCount == 0)
        {
            gameController.wavesKilled++;
            Destroy(this.gameObject);
        }

        transform.GetChild(0).GetComponent<BombRow>().isLowest = true;

        if (direction == Vector2.right)
        {
            transform.Translate(Vector2.right * gameController.speed * Time.deltaTime);
            if (transform.localPosition.x > 450)
            {
                transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - 50);
                direction = Vector2.left;
            }
        }
        else if (direction == Vector2.left)
        {
            transform.Translate(Vector2.left * gameController.speed * Time.deltaTime);
            if (transform.localPosition.x < -450)
            {
                transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - 50);
                direction = Vector2.right;
            }
        }
        
    }
}
