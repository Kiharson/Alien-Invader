using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    private GameController gameController;

    [SerializeField]
    AudioSource bulletSound;

    [SerializeField]
    AudioSource gameOverSound;

    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.localPosition.x >= -900)
            {
                gameObject.transform.Translate(Vector2.left * gameController.speed * 2 * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.localPosition.x <= 900)
            {
                gameObject.transform.Translate(Vector2.right * gameController.speed * 2 * Time.deltaTime);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameController.canShoot)
            {
                GameObject bulletX = Instantiate(bullet);
                bulletX.transform.SetParent(GameObject.Find("Canvas").transform);
                bulletX.transform.localPosition = new Vector2(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y + 40);
                bulletX.transform.localScale = new Vector3(25, 25, 1);

                bulletX.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, gameController.speed * 20));

                gameController.canShoot = false;

                bulletSound.Play();
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Alien"))
        {
            gameController.GameOver();
        }

        if (collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(collision.gameObject);
            gameOverSound.Play();
            gameController.turretsLeft--;

            if (gameController.turretsLeft == 0)
            {
                gameController.GameOver();
            }
        }
    }
}
