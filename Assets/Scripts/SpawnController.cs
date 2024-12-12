using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float[] posX;
    [SerializeField] private float duration;
    [SerializeField] private float currentTime;

    // Update is called once per frame
    void Update()
    {
        if(currentTime <= 0){
            currentTime = duration;
            Spawn();
        }else{
            currentTime -= Time.deltaTime;
        }
    }
    private void Spawn(){
        GameObject newEnemy = Instantiate(enemyPrefab);
        newEnemy.transform.position = new UnityEngine.Vector2(
            posX[Random.Range(0,posX.Length)],
            transform.position.y
        );
        newEnemy.transform.SetParent(transform);
        if(newEnemy.transform.position.x == posX[1]){
            newEnemy.transform.localScale = new UnityEngine.Vector3(newEnemy.transform.localScale.x * -1,0.4f,0);
        }
    }
}
