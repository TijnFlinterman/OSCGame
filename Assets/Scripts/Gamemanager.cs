using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager main;
    TileSpawner tilespawner;
    public int diffcultyAmount;
    GameObject Player;
    Vector3 beginPos;
    float nextDif = 100;
    private void Awake()
    {

        //singleton pattern
        if (main == null)
        {
            main = this;
            //DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        beginPos = Player.transform.position;
        diffcultyAmount = 1;
        tilespawner = GameObject.FindGameObjectWithTag("tilespawner").GetComponent<TileSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(beginPos, Player.transform.position);
        if (dis >= nextDif)
        {
            nextDif = nextDif + 100;
            diffcultyAmount++;
        }
    }
}
