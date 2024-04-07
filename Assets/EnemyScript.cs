using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyScript : MonoBehaviour

{
    public float Health{
        set{
            health = value;
            if(health<=0){
                Defeated();
            }
        }
        get{
            return health;
        }
    }
    public float health = 1;



    private void Defeated(){
        Destroy(gameObject);
    }
}
