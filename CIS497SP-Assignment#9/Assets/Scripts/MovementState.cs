/* 
 * John Mordi
 * MovementState.cs 
 * Assignment 9
 * Manages what happens when a transition is called while in the movement state
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : EnemyState
{
    public EnemyAiManager enemyAiManager;
    public override void RunAway()
    {
        enemyAiManager.currentState = enemyAiManager.runState;
    }

    public override void StartMovement()
    {
        gameObject.transform.position = (new Vector3(gameObject.transform.position.x, GameObject.FindGameObjectWithTag("Player").transform.position.y));
    }

    public override IEnumerator StartShooting()
    {
        enemyAiManager.currentState = enemyAiManager.shootingState;
        yield break;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.enemyAiManager = gameObject.GetComponent<EnemyAiManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
