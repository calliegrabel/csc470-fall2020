using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject treePrefab;
    public GameObject chickenPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            float x = Random.Range(-200, 200);
            float z = Random.Range(-200, 200);
            Vector3 pos = new Vector3(x, 0, z);
            GameObject tree = Instantiate(treePrefab, pos, Quaternion.identity);
            tree.transform.Rotate(0, Random.Range(0, 360), 0);
        }
        for (int i = 0; i < 100; i++)
        {
            float x = Random.Range(-200, 200);
            float z = Random.Range(-200, 200);
            Vector3 pos = new Vector3(x, 0, z);
            GameObject chicken = Instantiate(chickenPrefab, pos, Quaternion.identity);
            chicken.transform.Rotate(0, Random.Range(0, 360), 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
