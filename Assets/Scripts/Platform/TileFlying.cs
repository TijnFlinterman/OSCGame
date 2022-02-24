using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFlying : MonoBehaviour
{
    float timeLeft = 5f;
    GameObject TileMap;
    Vector3 currentScale;
    Vector3 oldPos;
    Renderer render;
   [SerializeField] GameObject loc;
    bool move;
    float speed;
    private Vector3 velocity = Vector3.zero;
    Color white;
    Color StartC;
    Color End;
    // Start is called before the first frame update
    void Start()
    {
        render = gameObject.GetComponent<Renderer>();
      
        TileMap = GameObject.FindGameObjectWithTag("TileMap");
        currentScale = new Vector3(1f, 1f, 1f);
        SpawnTile();
        transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(this.gameObject, currentScale, 0.5f);
        if (Gamemanager.main.diffcultyAmount >= 0)
        {
            StartC = Color.cyan;
        
        }
        if (Gamemanager.main.diffcultyAmount >= 2)
        {
            StartC = Color.blue;

        }
        if (Gamemanager.main.diffcultyAmount >= 5)
        {
            StartC = Color.green;

        }
        if (Gamemanager.main.diffcultyAmount >= 9)
        {
            StartC = Color.red;

        }
    }

    // Update is called once per frame
    void Update()
    {
        white = Color.Lerp(StartC, Color.white, Mathf.PingPong(Time.time, 0.7f));
       
        render.material.SetColor("_BaseColor", white);
        //timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0.4f;
        }
        if (move)
        { 
        
         transform.position = Vector3.MoveTowards(transform.position, loc.transform.position, speed * Time.deltaTime );
           
            
            float a;
            a = Vector3.Distance(transform.position, loc.transform.position);
           if (a <= 0)
           {
               move = false;
            
            }
        }
    }
    void SpawnTile()
    {
       // oldPos = transform.position;
        speed = Random.RandomRange(40, 50);
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 50 );
        move = true;
    }
    void ranColor()
    {
    
        int ran = Random.RandomRange(1, 100);
        if (ran < 50)
        {
            render.material.SetColor("_BaseColor", white);

        }
        if (ran > 50)
        {
            render.material.SetColor("_BaseColor", Color.white);

        }

    }
}
