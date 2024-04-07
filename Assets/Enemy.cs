using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public float Health{

        set{
            health = value;
            if(health <= 0){
                Defeated();
                
            }
        }
        get{
            return health;
        }
    }
    public bool damaged = false;

    public float health = 10;
    
    public void Damaged(){
        if(damaged){
            animator.SetTrigger("Damaged");
            damaged = false;
        }
    }

    public void Defeated(){
        animator.SetTrigger("Defeated");
    }

    public void RemoveEnemy(){
        Destroy(gameObject);
    }
}
