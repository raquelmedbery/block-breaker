using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //configuration pararmeters
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minMouseXPos = 1.0f;
    [SerializeField] float maxMouseXPos = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minMouseXPos, maxMouseXPos);
        transform.position = paddlePos;
    }
}
