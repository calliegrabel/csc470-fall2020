using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    float speed = 8f;
    float rotateSpeed = 120f;
    int score = 0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
        void Update()
        {
            float hAxis = Input.GetAxis("Horizonal");
            transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0);
            transform.Translate(transform.forward * Time.deltaTime * speed);
        }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("goldfishes"))
        {
            Destroy(other.gameObject);
            score++;
            scoreText.text = score.ToString();
        }
    }
   
}

