/* 
 * John Mordi
 * PlayerController.cs 
 * Assignment 9
 * Gives the player control of a character's movement
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            if(gameObject.transform.position.y < 1.5)
                gameObject.transform.Translate(new Vector3(0, 1));
        if(Input.GetKeyDown(KeyCode.A))
            if (gameObject.transform.position.x > -9.5)
                gameObject.transform.Translate(new Vector3(-1, 0));
        if (Input.GetKeyDown(KeyCode.S))
            if (gameObject.transform.position.y > -0.5)
                gameObject.transform.Translate(new Vector3(0, -1));
        if (Input.GetKeyDown(KeyCode.D))
            if (gameObject.transform.position.x < 9.5)
                gameObject.transform.Translate(new Vector3(1, 0));
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
