using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroCamara : MonoBehaviour
{
    public float maxRotationDegreePerSecond = 75f;
    public float gyroRotationSpeed = 70f;
    public float maxPitchUpAngle = 45f;
    public float maxPitchDownAngle = 5f;
    private Rect lookRect;
    private int lookTouchID = -1;
    private Vector2 touchOrigin;
	// Use this for initialization
	void Start ()
    {       
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.gyro.enabled)
        {
            GyroInput();
        }
        else
        {
            TouchInput();
        }
	}

    private void GyroInput()
    {
        Vector3 rotation = Input.gyro.rotationRate * gyroRotationSpeed;

        RotateView(new Vector3(-rotation.x, -rotation.y, 0));
    }

    private void TouchInput()
    {
        if(Input.touchCount > 0)
        {
            if(lookTouchID == -1)
            {
                foreach(Touch touch in Input.touches)
                {
                    if (touch.phase != TouchPhase.Began)
                        continue;
                    if (!lookRect.Contains(touch.position))
                        continue;
                    lookTouchID = touch.fingerId;
                    touchOrigin = touch.position;
                    break;
                }
            }
            foreach(Touch touch in Input.touches)
            {
                if (touch.fingerId != lookTouchID)
                    continue;
                Vector3 touchDistance = touch.position - touchOrigin;
                Vector3 clampedRotation = Vector3.ClampMagnitude(new Vector3(-touchDistance.y, touchDistance.x), maxRotationDegreePerSecond);
                RotateView(clampedRotation);
                if(touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
                {
                    lookTouchID = -1;
                }
                break;
            }
        }
    }

    private void RotateView(Vector3 rotation)
    {
        transform.Rotate(rotation * Time.deltaTime);

        if(Input.gyro.enabled)
        {
            Vector3 localEuler = transform.localEulerAngles;
            transform.localRotation = Quaternion.Euler(localEuler.x, localEuler.y, 0);
        }

        float playerPitch = LimitPitch();

        transform.rotation = Quaternion.Euler(playerPitch, transform.eulerAngles.y, 0);
    }

    private float LimitPitch()
    {
        float playerPitch = transform.eulerAngles.x;

        float maxPitchUp = 360 - maxPitchUpAngle;
        float maxPitchDown = maxPitchDownAngle;
        if(playerPitch > 180 && playerPitch < maxPitchUp)
        {
            playerPitch = maxPitchUp;
        }
        else if (playerPitch < 180 && playerPitch > maxPitchDown)
        {
            playerPitch = maxPitchDown;
        }
        return playerPitch;
    }
}
