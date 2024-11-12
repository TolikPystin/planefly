using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovning : MonoBehaviour
{
    public float force = 50f;
    private Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void Jump()
    {


        Debug.Log("прыжок");
        rb.AddForce(new Vector2(0, force), ForceMode2D.Impulse);


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();

        }
    }
}
