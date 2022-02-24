using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager main;
    TileSpawner tilespawner;
    public int diffcultyAmount;
   public  GameObject Player;
    Vector3 beginPos;
    float nextDif = 100;
    float dis;
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
        dis = Vector3.Distance(beginPos, Player.transform.position);
     
      
    }
    private void FixedUpdate()
    {
        if (dis >= nextDif)
        {
            nextDif = nextDif + 200;
            if (diffcultyAmount < 12)
            {
                diffcultyAmount++;
            }
        }
    }
}
