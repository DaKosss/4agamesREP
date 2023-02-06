using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Player;
    public Transform Player2;
    public float Speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.LookAt (Player2);
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Speed * Time.deltaTime);
    }
    void onTriggerEnter(Collider Coll){
        if (Coll.gameObject.tag == "Looking") {
            Speed = 0f;
        }
    }
    void onTriggerExit(Collider Coll){
        if (Coll.gameObject.tag == "Looking") {
            Speed = 5f;
        }
    }
}   
