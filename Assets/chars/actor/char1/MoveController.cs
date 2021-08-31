using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float SPEED = 1.0f;
    private Rigidbody2D rigidBody;
    private InputAction moveAction;
    private Vector2 inputAxis;

    void Start()
    {
        this.rigidBody = GetComponent<Rigidbody2D>();
        var pInput = GetComponent<PlayerInput>();
        var actionMap = pInput.currentActionMap;
        moveAction = actionMap["Move"];
    }

    // Update is called once per frame
    void Update()
    {
        inputAxis = moveAction.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rigidBody.velocity = inputAxis.normalized * SPEED;
    }
}
