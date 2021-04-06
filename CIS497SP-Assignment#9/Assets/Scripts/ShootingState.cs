/* 
 * John Mordi
 * ShootingState.cs 
 * Assignment 9
 * Manages what happens when a transition is called while in the shooting state
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingState : EnemyState
{
    public EnemyAiManager enemyAiManager;

    // Start is called before the first frame update
    void Start()
    {
        this.enemyAiManager = gameObject.GetComponent<EnemyAiManager>();
    }

    public override void RunAway()
    {
        enemyAiManager.currentState = enemyAiManager.runState;
        StopAllCoroutines();
    }

    public override void StartMovement()
    {
        enemyAiManager.currentState = enemyAiManager.movementState;
        StopAllCoroutines();
    }

    public override IEnumerator StartShooting()
    {
        yield return new WaitForSeconds(0.5f);
        while (true)
        {
            Instantiate(Resources.Load("Circle"), gameObject.transform.position, gameObject.transform.rotation);
            yield return new WaitForSeconds(1);
        }

        yield break;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
