using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFlying : MonoBehaviour
{
    GameObject TileMap;
    Vector3 currentScale;
    Vector3 oldPos;
   [SerializeField] GameObject loc;
    bool move;
    float speed;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        TileMap = GameObject.FindGameObjectWithTag("TileMap");
        currentScale = new Vector3(1f, 1f, 1f);
        SpawnTile();
        transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(this.gameObject, currentScale, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
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
}
