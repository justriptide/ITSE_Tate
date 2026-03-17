using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class MazeBall : MonoBehaviour
{
    public float MaxBallSpeed = 10f;
    public float BallPushRate = .15f;
    Vector3 StartingLocation;
    Quaternion StartingRotation;

    public TextMeshProUGUI rawDataField;
    Vector3 acceleData = Vector3.zero;

    Rigidbody rb;
    protected void OnEnable()
    {
        InputSystem.EnableDevice(Accelerometer.current);
    }

    protected void OnDisable()
    {
        InputSystem.DisableDevice(Accelerometer.current);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartingLocation = gameObject.transform.position;
        StartingRotation = gameObject.transform.rotation;
        rb = gameObject.GetComponentInParent<Rigidbody>();
     
    }

    // Update is called once per frame
    void Update()
    {
        Accelerometer accel = Accelerometer.current;
        if (accel != null)
        {
            acceleData = accel.acceleration.ReadValue();
            rawDataField.text = acceleData.ToString();

        }

        Vector3 direction = Vector3.zero;
        direction.x = acceleData.x;
        direction.y = 0;
        direction.z = acceleData.y;

        rb.linearVelocity += direction * BallPushRate;

        if (rb.linearVelocity.magnitude > MaxBallSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * MaxBallSpeed;
        }
    }

    public void ResetBall()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        gameObject.transform.position = StartingLocation;
        gameObject.transform.rotation = StartingRotation;
    }
}