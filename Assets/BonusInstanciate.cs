using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusInstanciate : StateMachineBehaviour
{
    public Var wep;
    public GameObject projectile;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (wep.value >= 2)
        {
            GameObject proj2 = Instantiate(projectile, GameObject.Find("Player").transform.position, Quaternion.Euler(0, 0, 90));
            proj2.transform.SetParent(GameObject.Find("Bullet Group").transform);
            projectile.GetComponent<ProjectileBonusMove>().id = 2;
        }
        if (wep.value >= 3)
        {
            GameObject proj3 = Instantiate(projectile, GameObject.Find("Player").transform.position, Quaternion.Euler(0, 0, -90));
            proj3.transform.SetParent(GameObject.Find("Bullet Group").transform);
            projectile.GetComponent<ProjectileBonusMove>().id = 3;
        }
        if (wep.value >= 4)
        {
            GameObject proj4 = Instantiate(projectile, GameObject.Find("Player").transform.position, Quaternion.Euler(0, 0, 180));
            proj4.transform.SetParent(GameObject.Find("Bullet Group").transform);
            projectile.GetComponent<ProjectileBonusMove>().id = 4;
        }
    }
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
