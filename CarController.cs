using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float HorizontalInput;
    private float VerticalInput;
    private float steerAngle;
    private float currentsteerAngle;
    private float currentbreakforce;
    private bool isBreaking;
    public static float Speed;
    public static float Revs;

    [SerializeField] private float motorForce;
    [SerializeField] private float maxSteerAngle;
    [SerializeField] private float breakForce;

    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;
    [SerializeField] private WheelCollider frontRightWheelCollider;

    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;
    [SerializeField] private Transform frontRightWheelTransform;


    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
        RPM();
        Speedometer();
    }

    private void GetInput()
    {
        HorizontalInput = Input.GetAxis(HORIZONTAL);
        VerticalInput = Input.GetAxis(VERTICAL);
        isBreaking = Input.GetKeyDown(KeyCode.Space);
    }
    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque = VerticalInput * motorForce;
        frontRightWheelCollider.motorTorque = VerticalInput * motorForce;
        currentbreakforce = isBreaking ? breakForce : 0f;
        if (isBreaking)
        {
            ApplyBreaking();
        }
    }

    private void ApplyBreaking()
    {
        frontRightWheelCollider.brakeTorque = currentbreakforce;
        frontLeftWheelCollider.brakeTorque = currentbreakforce;
        rearRightWheelCollider.brakeTorque = currentbreakforce;
        rearLeftWheelCollider.brakeTorque = currentbreakforce;
    }

    private void HandleSteering()
    {
        currentsteerAngle = maxSteerAngle * HorizontalInput;
        frontLeftWheelCollider.steerAngle = currentsteerAngle;
        frontRightWheelCollider.steerAngle = currentsteerAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }

    private void RPM()
    {
        Revs = VerticalInput * motorForce;
        //print(Revs);
    }

    private void Speedometer()
    {
        Speed = transform.GetComponent<Rigidbody>().velocity.magnitude;
        if ( Speed < 0 )
        {
            Speed = 0;
        }

        Speed = Mathf.Round( Speed );

        //print(Speed);
    }
}
