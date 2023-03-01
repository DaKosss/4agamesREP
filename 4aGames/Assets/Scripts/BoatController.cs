using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatController : MonoBehaviour
{
    public Rigidbody boat;
[Header("Controls")]
    public float Accel;
    public float Break;
    public float Steering;
[Header("Vehicle Steeings")]
    public float EnginePower = 250f;
    public float BrakeForce = 15000f;
    public float SteerAngle = 35f;
[Header("Wheels")]
    public Vector3 COM;
    // Start is called before the first frame update
    void Start()
    {
        boat = GetComponent<Rigidbody>();
        boat.centerOfMass = COM;
    }

    // Update is called once per frame
    void Update()
    {
        Accel = Input.GetAxis("Accel");
        Brake = Input.GetAxis("Brake");
        Steering = Input.GetAxis("Horizontal");

    }
}
