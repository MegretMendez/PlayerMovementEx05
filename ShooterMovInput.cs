using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShooterMovInput : MonoBehaviour
{
    public float speed;
    public float multiplier;
    public float rotationSpeed;
    public GameObject prefab;
    public GameObject shootPoint;
    private Vector2 movementValue;
    private float lookValue;



    // Start is called before the first frame update
    void Start()
    {
    }

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>()* speed;
    }
    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
    }

    public void OnFire()
    {
            GameObject clone = Instantiate(prefab);
            clone.transform.position= shootPoint.transform.position;
            clone.transform.rotation= shootPoint.transform.rotation;
    }

    public void OnFastMove(){
        movementValue = movementValue*multiplier;
    }

    // Update is called once per frame
    void Update()
    {
       // Move left, right, up, down
        transform.Translate(movementValue.x * Time.deltaTime,0,movementValue.y * Time.deltaTime);

        // rotate in x axis only
        transform.Rotate(0, lookValue * Time.deltaTime, 0); 
    }
}