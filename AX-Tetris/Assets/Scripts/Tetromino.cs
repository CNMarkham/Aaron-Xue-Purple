using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{
    public Vector3 rotationPoint;
    public float fallTime = 0.8f;
    private float previousTime;
    public float speed;
    public static int width = 10;
    public static int height = 20;
    public static Transform[,] grid = new Transform[width, height];
    // Update is called once per frame
    public void AddToGrid()
    {
        foreach (Transform child in transform)
        {
            int x = Mathf.RoundToInt(child.transform.position.x);
            int y = Mathf.RoundToInt(child.transform.position.y);
            grid[x, y] = child;
        }

    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up);

            Vector3 convertedPoint = transform.TransformPoint(rotationPoint);
            transform.RotateAround(convertedPoint, Vector3.forward, 90);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right);

            if (!ValidMove())
            {
                
                transform.Translate(Vector2.left);

            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left);
         
            if (!ValidMove())
            {
                transform.Translate(Vector2.right);
                
            }

        }
        float tempTime = fallTime;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            tempTime = tempTime / 10;
           

        }


        if (Time.time - previousTime > tempTime)
        {
            transform.Translate(Vector3.down);
            previousTime = Time.time;
            if (!ValidMove())
            {
                transform.position += Vector3.up;
                this.enabled = false;
                AddToGrid();
                FindObjectOfType<Spawner>().SpawnTetromino();
               

            }
        }
                  
    }
    public bool ValidMove()
    {
        foreach (Transform child in transform)
        {
            int x = Mathf.RoundToInt(child.transform.position.x);
            int y = Mathf.RoundToInt(child.transform.position.y);
                     
            if (x < 0 || y < 0 || x >= width || y >= height)
            {
                return false;
            }
            Debug.Log(x + " " + y);
            if (grid[x, y] != null)
            {
                return false;
            }
        }
        return true;
        
    }
}