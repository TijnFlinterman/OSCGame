using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFlying : MonoBehaviour
{
    Vector3 oldPos;
    bool move;
    float speed;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTile();
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        { 
        
         transform.position = Vector3.MoveTowards(transform.position, oldPos, speed * Time.deltaTime );

        }
    }
    void SpawnTile()
    {
        oldPos = transform.position;
        speed = Random.RandomRange(40, 50);
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 50);
        move = true;
    }
}
