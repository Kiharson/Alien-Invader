using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameController gameController;

    private void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("UpperBound"))
        {
            Destroy(this.gameObject);
            gameController.canShoot = true;
        }

        if (collision.gameObject.CompareTag("Alien"))
        {
            gameController.score += 10;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            gameController.canShoot = true;
        }

        if (collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            gameController.canShoot = true;
        }
    }
}
