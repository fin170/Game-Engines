﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCity : MonoBehaviour
{
    public GameObject[] buildings;
    public int mapWidth = 20;
    public int mapHeight = 20;
    public float buildingHeight = 30f;
    public int buildingPlacement = 30;
    void Start()
    {
        //for (float z = 0; z < buildingHeight; z+=3f)
         for (int h=0;h<mapHeight; h++)
        {
            for(int w=0; w<mapWidth; w++)
            {
                Vector3 pos = new Vector3(w* buildingPlacement, 0, h* buildingPlacement);
                int n = Random.Range(0, buildings.Length);
                Instantiate(buildings[n], pos, Quaternion.identity);
            }
        }
    }

   
}
