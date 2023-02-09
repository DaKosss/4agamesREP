using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Player;
    public Transform Player2;
    public float Speed;
    public GameObject Collider;
    

    void Start()
    {
        Speed = 0f;
    }

    void Update()
    {
        transform.LookAt (Player2);
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other){
        if (Collider.gameObject.tag == "Looking") {
            Speed = 0f;
        }
    }
    void OnTriggerExit(Collider other){
        if (Collider.gameObject.tag == "Looking") {
            Speed = 2f;
        }
    }
}   
