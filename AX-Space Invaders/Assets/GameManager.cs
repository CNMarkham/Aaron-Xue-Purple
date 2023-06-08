using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    // Update is called once per frame
  
   public GameObject EnemyPrefab;


    public float xSpace;
    public float xOffset;
    
    void Start()
    {
        for (int x = 0; x < 10; x++)
        {
            Instantiate(EnemyPrefab, new Vector2(x * xSpace + xOffset, 3), Quaternion.identity);
            Instantiate(EnemyPrefab, new Vector2(x * xSpace + xOffset, 3.75f), Quaternion.identity);
            Instantiate(EnemyPrefab, new Vector2(x * xSpace + xOffset, 4.5f), Quaternion.identity);
        }
    }
}
    

