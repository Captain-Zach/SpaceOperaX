using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShuttleMovement : MonoBehaviour
{
    public float speed;
    public int lives;

    [SerializeField] Vector2 inputWatcher;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector2( this.transform.position.x + speed * inputWatcher.x * Time.deltaTime, this.transform.position.y);
        
    }

    private void OnMove(InputValue moveInput)
    {
       Vector2 movementVector = moveInput.Get<Vector2>();
       inputWatcher = movementVector;
       Debug.Log(movementVector);
    }
}
