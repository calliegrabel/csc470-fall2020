using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bubble;
    float makeBubbleTimer = 0.1f;
    float makeBubbleRate = 0.1f;
    GameObject CenterofGravity;

    // Start is called before the first frame update
    void Start()
    {
        CenterofGravity = GameObject.Find("CenterofGravity");
        
    }

    // Update is called once per frame
    void Update()
    {
        makeBubbleTimer -= Time.deltaTime;
        if(makeBubbleTimer < 0)
        {
            Vector3 pos = new Vector3(CenterofGravity.transform.position.x + Random.Range(-20, 20), CenterofGravity.transform.position.y + 10, CenterofGravity.transform.position.z + Random.Range(-20, 20));
            makeBubbleTimer = makeBubbleRate;
            Instantiate(bubble, pos, Quaternion.identity);
            Vector3 up = new Vector3(0, 1, 0);
            bubble.transform.Translate(up * speed * Time.deltaTime);
        }
    }
    public void StartAttack()
    {
        //Load level
        SceneManager.LoadScene("sharkAttacklevel1");

    }
}
