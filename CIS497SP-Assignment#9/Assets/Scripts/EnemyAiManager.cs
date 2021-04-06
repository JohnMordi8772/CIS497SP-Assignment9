/* 
 * John Mordi
 * EnemyAiManager.cs 
 * Assignment 9
 * Manages when transitions are called and manages the states on the enemy object
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAiManager : MonoBehaviour
{
    public EnemyState shootingState;
    public EnemyState runState;
    public EnemyState movementState;
    public EnemyState currentState;
    // Start is called before the first frame update
    void Start()
    {
        shootingState = gameObject.AddComponent<ShootingState>();
        runState = gameObject.AddComponent<RunState>();
        movementState = gameObject.AddComponent<MovementState>();
        currentState = shootingState;
        StartCoroutine(currentState.StartShooting());
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(gameObject.transform.position.x - GameObject.FindGameObjectWithTag("Player").transform.position.x) <= 5 && gameObject.transform.position.x < 9.5f)
            RunAway();

        else if (GameObject.FindGameObjectWithTag("Player").transform.position.y != gameObject.transform.position.y)
            StartMovement();

        else if(currentState != shootingState)
            StartCoroutine(currentState.StartShooting());
    }

    public void RunAway()
    {
        currentState.RunAway();
    }

    public void StartShooting()
    {
        currentState.StartShooting();
    }

    public void StartMovement()
    {
        currentState.StartMovement();
    }
}
