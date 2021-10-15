using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float spawnPosition;
    public float endLimit;
    void Update()
    {
        transform.Translate(Vector2.left * .1f * Time.deltaTime);

        if (transform.position.x <= endLimit)
        {
            transform.position = new Vector2(spawnPosition, transform.position.y);
        }
    }
}
