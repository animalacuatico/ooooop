using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushGenerator : MonoBehaviour
{
    public GameObject bushPrefab, combatBushPrefab;
    private char[,] bushMap = new char[50, 50];
    private Vector2 bushPos;
    private void Start()
    {
        GenerateMap(bushMap);
        RenderMap(bushMap);
    }
    private void GenerateMap(char[,] bushMap)
    {
        for (int x = 0; x < 50; x++)
        {
            for (int y = 0; y < 50; y++)
            {
                    bushMap[x, y] = 'B'; // Todos son bushes normales
                int combatBushChance = Random.Range(0, 30);
                if (combatBushChance < 1)
                {
                    bushMap[x, y] = 'C'; // C son los bushes de combate
                }
            }
        }
    }
    private void RenderMap(char[,] bushMap)
    {
        for (int x = 0; x < 50; x++)
        {
            for (int y = 0; y < 50; y++)
            {
                bushPos = new Vector2(x, y);
                if (bushMap[x, y] == 'B')
                {
                    Instantiate(bushPrefab, bushPos, Quaternion.identity);
                }
                else if (bushMap[x, y] == 'C')
                {
                    Instantiate(combatBushPrefab, bushPos, Quaternion.identity);
                }
            }
        }
    }


}
