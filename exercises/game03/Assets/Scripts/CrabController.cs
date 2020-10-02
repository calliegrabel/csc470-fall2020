using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrabController : MonoBehaviour
{
    float speed = 8f;
    float rotateSpeed = 120f;
    int score = 0;

    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0, Space.World);
        transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);
        if (speed > 0)
        {
            speed -= 4 * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed += 5;
        }
        speed = Mathf.Clamp(speed, 0, 15);
    }
}