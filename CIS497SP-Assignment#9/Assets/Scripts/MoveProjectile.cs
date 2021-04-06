/* 
 * John Mordi
 * MoveProjectile.cs 
 * Assignment 9
 * Manages the movement and destruction of projectiles
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(new Vector3(-1, 0) * 5 * Time.deltaTime);

        if(gameObject.transform.position.x <= -9.5)
        {
            Destroy(gameObject);
        }
    }
}
