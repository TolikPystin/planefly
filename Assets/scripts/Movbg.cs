using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movbg : MonoBehaviour
{
    
    public float speed = 1.0f;


    void Update()
    {
        transform.Translate(Vector2.left *  speed * Time.deltaTime);
    }
}
