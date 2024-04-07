using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptOfEnemy : MonoBehaviour
{
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
    public void takeDamage(float damage){
        

    }

    public void Defeated(){
        Destroy(gameObject);
    }
}
