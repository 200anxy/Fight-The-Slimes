using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
         
   public CapsuleCollider2D CapsuleColliderforSlime; 
    public bool damaged = false;

    public float health = 10;
    public void Start(){
        CapsuleColliderforSlime = GetComponent<CapsuleCollider2D>(); 
    }
    public void Damaged(){
        if (damaged){
        animator.SetTrigger("Damaged");
        damaged = false;
        }else{
            print("NONE"); //This is just for testing purposes
        }
    }

    public void Defeated(){
        animator.SetTrigger("Defeated");
    }

    public void RemoveEnemy(){
        Destroy(gameObject);
    }
}
