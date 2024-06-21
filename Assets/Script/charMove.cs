using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class charMove : MonoBehaviour
{

    [SerializeField] private float distanceToMove;
    [SerializeField] private float moveSpeed;
    private bool moveToPoint = false;
    private Vector3 endPosition;
    void Start()
    {
        endPosition = transform.position;
    }

    void FixedUpdate()
    {
        if (moveToPoint)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, moveSpeed * Time.deltaTime);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //Left
        {
            endPosition = new Vector3(endPosition.x - distanceToMove, endPosition.y, endPosition.z);
            transform.eulerAngles = new Vector3(0, 0, 0);
            moveToPoint = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) //Right
        {
            endPosition = new Vector3(endPosition.x + distanceToMove, endPosition.y, endPosition.z);
            transform.eulerAngles = new Vector3(0, 180, 0);
            moveToPoint = true;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) //Up
        {
            endPosition = new Vector3(endPosition.x, endPosition.y + distanceToMove, endPosition.z);
            moveToPoint = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) //Down
        {
            endPosition = new Vector3(endPosition.x, endPosition.y - distanceToMove, endPosition.z);
            moveToPoint = true;
        }
    }
}
