using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField ]private  GameManager gm;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float[] posX;
    [SerializeField] private bool isHit;
    [SerializeField] private bool isRight;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
                Input.mousePosition.x,
                transform.position.y,
                transform.position.z
        ));

        if((Input.GetMouseButtonDown(0) || Input.touchCount > 0) && isHit && mousePos.x >=posX[0] && mousePos.x <= posX[1]){
            rb.velocity = new Vector2(
                moveSpeed,
                rb.velocity.y
            );

            Flip();

            isHit = false;
            if(!isHit){
                moveSpeed *= -1;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Wall")){
            isHit = true;
        }
    }
    private void Flip(){
        isRight = !isRight;
        transform.Rotate(0f,180f,0f);
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Score")){
            gm.score++;
        }
        if(other.gameObject.CompareTag("Enemy")){
            gm.GameOver();
        }
    }
}
