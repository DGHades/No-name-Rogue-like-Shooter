using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreator : MonoBehaviour
{
    public GameObject mapTilePosDefiner;
    public int mapWidth = 64;
    public int mapHeight = 64;

    private int x, y, z = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < mapHeight; i++)
        {
            for (int j = 0; j < mapWidth; j++)
            {
                Instantiate(mapTilePosDefiner, new Vector3(x, y, z), Quaternion.identity);
                x += 20;
            }
            x = 0;
            y -= 20;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
