/* 
 * John Mordi
 * RunState.cs 
 * Assignment 9
 * Manages what happens when a transition is called while in the run state
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunState : EnemyState
{
    public EnemyAiManager enemyAiManager;
    public override void RunAway()
    {
        //if (gameObject.transform.position.x < 9.5f)
        //{
            float x = gameObject.transform.position.x;
            gameObject.transform.Translate(new Vector3(1, 0));
            Instantiate(Resources.Load("Circle"), new Vector3(x, 1.5f), Quaternion.Euler(new Vector3(0, 0, 0)));
            //Instantiate(Resources.Load("Circle"), new Vector3(x, 0.5f), Quaternion.Euler(new Vector3(0, 0, 0)));
            Instantiate(Resources.Load("Circle"), new Vector3(x, -0.5f), Quaternion.Euler(new Vector3(0, 0, 0)));
        //}
    }

    public override void StartMovement()
    {
        enemyAiManager.currentState = enemyAiManager.movementState;
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
