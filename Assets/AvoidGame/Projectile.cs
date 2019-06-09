using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed = 40;
    Vector2 target;
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        target.x = 20;
        target.y = transform.position.y;
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            target,
            Time.deltaTime * Speed
         );

        sprite.color = new Color(
            sprite.color.r,
            sprite.color.g,
            sprite.color.b,
            (1 - Mathf.Abs(transform.position.x + 6 / 6))
        );

        if(transform.position.x >= 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
