using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float Speed;
    public float xStart;
    public float xEnd;

    Vector2 target;

    private void Start()
    {
        target.x = xEnd;
        target.y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(
            transform.position, 
            target, 
            Time.deltaTime * Speed
        );

        if(transform.position.x == xEnd)
        {
            transform.position = new Vector2(xStart, target.y);
        }
    }
}
