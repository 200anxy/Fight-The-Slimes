using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//importing unityengine's UI
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    private float distance;
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
    public float maxHealth;
    public Slider healthBar;
    public void Start(){
        CapsuleColliderforSlime = GetComponent<CapsuleCollider2D>(); 
        maxHealth = health;
        Player = GameObject.Find("Player");
    }
    public void Update(){
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);


    }
    private void Awake()
    {
        healthBar.maxValue = health;
        healthBar.value = health;

    }
    public void Damaged(){
        if (damaged){
        animator.SetTrigger("Damaged");
        healthBar.value = health;
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