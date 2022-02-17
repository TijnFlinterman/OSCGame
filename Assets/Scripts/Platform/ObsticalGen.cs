using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalGen : MonoBehaviour
{
  [SerializeField]  GameObject[] Tiles;
   [SerializeField] int diffeculty;
    int deleteAmount;
    // Start is called before the first frame update
    void Start()
    {
        if (diffeculty < 4)
        {
            deleteAmount = Random.RandomRange(1, diffeculty);
        }
        else
        {
            deleteAmount = Random.RandomRange(3, diffeculty);
        }
        for (int i = 0; i < deleteAmount; i++)
        {
            deleteTile();
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void deleteTile()
    {
        Destroy(Tiles[Random.RandomRange(0, Tiles.Length)]);

    }
}
