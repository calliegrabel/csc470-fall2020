using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject sharkPrefab;
    public GameObject seaweedPrefab;
    public GameObject coralReef;
    public GameObject fishPod;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 1000; i++)
        {
            // Choose a random position over the terrain
            float x = Random.Range(Terrain.activeTerrain.transform.position.x, Terrain.activeTerrain.transform.position.x + Terrain.activeTerrain.terrainData.size.x);
            float z = Random.Range(Terrain.activeTerrain.transform.position.z, Terrain.activeTerrain.transform.position.z + Terrain.activeTerrain.terrainData.size.z);
            Vector3 pos = new Vector3(x, 0, z);
            // Use sample height at that position to find out what y should be.
            float y = Terrain.activeTerrain.SampleHeight(pos);
            pos.y = y;
            // Instantiate the tree at that position.
            GameObject seaweed = Instantiate(seaweedPrefab, pos, Quaternion.identity);
            // Randomly rotate the tree on the y axis for variation
            seaweed.transform.Rotate(0, Random.Range(0, 360), 0);
        }
        for (int i = 0; i < 100; i++)
        {
            // Choose a random position over the terrain
            float x = Random.Range(Terrain.activeTerrain.transform.position.x, Terrain.activeTerrain.transform.position.x + Terrain.activeTerrain.terrainData.size.x);
            float z = Random.Range(Terrain.activeTerrain.transform.position.z, Terrain.activeTerrain.transform.position.z + Terrain.activeTerrain.terrainData.size.z);
            Vector3 pos = new Vector3(x, 0, z);
            // Use sample height at that position to find out what y should be.
            float y = Terrain.activeTerrain.SampleHeight(pos);
            pos.y = y;
            // Instantiate the tree at that position.
            GameObject coralreef = Instantiate(coralReef, pos, Quaternion.identity);
            // Randomly rotate the tree on the y axis for variation
            coralreef.transform.Rotate(0, Random.Range(0, 360), 0);
        }

        for (int i = 0; i < 30; i++)
        {
            float x = Random.Range(Terrain.activeTerrain.transform.position.x, Terrain.activeTerrain.transform.position.x + Terrain.activeTerrain.terrainData.size.x);
            float z = Random.Range(Terrain.activeTerrain.transform.position.z, Terrain.activeTerrain.transform.position.z + Terrain.activeTerrain.terrainData.size.z);
            Vector3 pos = new Vector3(x, 0, z);
            float y = Terrain.activeTerrain.SampleHeight(pos) + Random.Range(10, 150);
            pos.y = y;
            GameObject shark = Instantiate(sharkPrefab, pos, Quaternion.identity);
            shark.transform.Rotate(0, Random.Range(0, 360), 0);
        }
        for (int i = 0; i < 100; i++)
        {
            float x = Random.Range(Terrain.activeTerrain.transform.position.x, Terrain.activeTerrain.transform.position.x + Terrain.activeTerrain.terrainData.size.x);
            float z = Random.Range(Terrain.activeTerrain.transform.position.z, Terrain.activeTerrain.transform.position.z + Terrain.activeTerrain.terrainData.size.z);
            Vector3 pos = new Vector3(x, 0, z);
            float y = Terrain.activeTerrain.SampleHeight(pos) + Random.Range(10, 150);
            pos.y = y;
            GameObject fish = Instantiate(fishPod, pos, Quaternion.identity);
            fish.transform.Rotate(0, Random.Range(0, 360), 0);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TreasureHunt()
    {
        SceneManager.LoadScene("submarineScene");
    }
}