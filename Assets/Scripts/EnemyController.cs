using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float moveSpeed; 
   
   
    void Update()
    {
          transform.Translate(0f,moveSpeed * Time.deltaTime,0f);
          if(transform.position.y >= 5.5f){
            Destroy(gameObject);
          }
    }
}
