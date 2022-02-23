using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public GameObject tileMap;
    public float zSpawn = 0;
    public float tileLength = 30;
    public int numberOfTiles = 5;
    public Transform playerTransform;
    public List<GameObject> TilesList = new List<GameObject>();
    GameObject go;
    void Start()
    {
        for (int i = 0; i < numberOfTiles; i++)
        {
            if (i == 0)
            {
                SpawnTile(0);
                SpawnTile(0);
                SpawnTile(0);
                SpawnTile(0);
                SpawnTile(0);
                SpawnTile(0);
                SpawnTile(0);
            }
            else
                SpawnTile(Random.Range(1, tilePrefabs.Length));
        }

    }
    void Update()
    {
     
        if (playerTransform.position.z > zSpawn - (numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(1, tilePrefabs.Length));

        }
        if (TilesList.Count > 15)
        {

            Destroy(TilesList[0]);
            TilesList.RemoveAt(0);
        }
    }

    public void SpawnTile(int tileIndex)
    {
        go = Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, tileMap.transform.rotation);
        go.transform.position = new Vector3(0, 0, zSpawn);
        go.transform.parent = tileMap.transform;
      
        zSpawn += tileLength;
        TilesList.Add(go);
    }
}
  
