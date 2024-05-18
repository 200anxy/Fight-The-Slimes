using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private GameObject enemyPrefab;

    [SerializeField] private bool canspawn = true;
    private void Start(){
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy(){
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while(canspawn){
            yield return wait;
            Instantiate(enemyPrefab, transform.position, Quaternion.identity );
        }
            

    }

}
