using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public float damage = 3;
    public Collider2D swordCollider;

    Vector2 rightAttackOffset;

    private void Start() {
        rightAttackOffset = transform.position;
    }

    public void AttackRight() {
        swordCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }

    public void AttackLeft() {
        swordCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack() {
        swordCollider.enabled = false;
    }

    public void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "Enemy"){
            //Going to deal damage to the enemy
            Enemy enemy = other.GetComponent<Enemy>();

            if(enemy != null){
                enemy.Health -= damage;
                enemy.damaged = true;
                enemy.Damaged();
                enemy.damaged = false;
            }
            
            
        }

    }


}
