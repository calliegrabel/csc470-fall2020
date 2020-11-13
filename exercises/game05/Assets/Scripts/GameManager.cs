using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject treePrefab;
    public GameObject chickenPrefab;
    public GameObject pigPrefab;
    public GameObject cowPrefab;
    public GameObject namePanel;
    public Text nameText;
    public Text soundText;
    public Text edibleText;
    public bool canGrow = false;
    public bool canCut = false;
 
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
        for (int i = 0; i < 100; i++)
        {
            float x = Random.Range(-200, 200);
            float z = Random.Range(-200, 200);
            Vector3 pos = new Vector3(x, 0, z);
            GameObject pig = Instantiate(pigPrefab, pos, Quaternion.identity);
            pig.transform.Rotate(0, Random.Range(0, 360), 0);
        }
        for (int i = 0; i < 100; i++)
        {
            float x = Random.Range(-200, 200);
            float z = Random.Range(-200, 200);
            Vector3 pos = new Vector3(x, 0, z);
            GameObject cow = Instantiate(cowPrefab, pos, Quaternion.identity);
            cow.transform.Rotate(0, Random.Range(0, 360), 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnMouseDown()
    {
        if(canCut = true)
        {
            Debug.Log("Can Cut");
        }
        if(canGrow = true)
        {
            Debug.Log("Can Grow");
            Instantiate(treePrefab);
        }
    }
    public void cutTrees()
    {
        canCut = true;
        OnMouseDown();
    }
    public void growTrees()
    {
        canGrow = true;
        OnMouseDown();
    }
    public void positionAboveNamePanel(AnimalScript animal)
    {
        nameText.text = animal.animalName;
        soundText.text = "Sound: " + animal.soundName;
        edibleText.text = "Edible: " + animal.edibleName;
        Vector3 pos = animal.gameObject.transform.position + Vector3.up * 2;
        namePanel.SetActive(true);
        namePanel.transform.position = Camera.main.WorldToScreenPoint(pos);


    }
    public void TurnOffPanel()
    {
        namePanel.SetActive(false);
    }
}
