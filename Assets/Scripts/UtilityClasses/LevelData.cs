using System.Collections.Generic;
using UnityEngine;

public class LevelData
{
    public static LevelData levelData;
    public int id { get; set; }
    public List<Vector3> diffPos1 { get; set; }
    public List<Vector3> diffPos2 { get; set; }

    public List<Vector3> diffScale { get; set; }
    public int numberOfDiff { get; set; }

    public static LevelData getCurrentLevelData(int level){
        if(levelData==null){
            levelData = new LevelData();
        }
  switch (level)
        {
            case 1:
                levelData.id = 0;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.71f, 4.04f, 1),
                    new Vector3(1.51f, 4.01f, 1),
                    new Vector3(-0.31f, 0.76f, 1),
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.71f, 0.02f, 1),
                    new Vector3(1.51f, 0f, 1),
                    new Vector3(-0.31f, -3.30f, 1),
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                };
                levelData.numberOfDiff = 3;
                break;

            case 2:
                levelData.id = 2;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.51f, 2.93f, 1),
                    new Vector3(2.17f, 3.92f, 1),
                    new Vector3(-1.49f, 1.88f, 1),
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.51f, -1.09f, 1),
                    new Vector3(2.17f, -0.15f, 1),
                    new Vector3(-1.49f, -2.23f, 1),
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.04f, -0.04f, 0.5f),
                    new Vector3(0.05f, 0.05f, -0.71f),
                };
                levelData.numberOfDiff = 3;
                break;

            case 3:
                levelData.id = 3;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.76f, 4.31f, 1),
                    new Vector3(-0.16f, 2.73f, 1),
                    new Vector3(1.81f, 2.99f, 1),
                    new Vector3(-1.51f, 2.84f, 1),
                    new Vector3(-0.97f, 1.12f, 1),
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.76f, 0.23f, 1),
                    new Vector3(-0.16f, -1.35f, 1),
                    new Vector3(1.81f, -1.05f, 1),
                    new Vector3(-1.51f, -1.27f, 1),
                    new Vector3(-0.97f, -2.94f, 1),
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(0.05f, 0.05f, 1),
                };
                levelData.numberOfDiff = 5;
                break;

            case 4:
                levelData.id = 4;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.67f, 3.42f, 1),
                    new Vector3(-0.68f, 2.91f, 1),
                    new Vector3(1.02f, 3.88f, 1),
                    new Vector3(1.85f, 2.47f, 1),
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.67f, -0.68f, 1),
                    new Vector3(-0.68f, -1.19f, 1),
                    new Vector3(1.02f, -0.16f, 1),
                    new Vector3(1.85f, -1.59f, 1),
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1.25f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                };
                levelData.numberOfDiff = 4;
                break;

            case 5:
                levelData.id = 5;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.67f, 3.42f, 1),
                    new Vector3(-0.68f, 2.91f, 1),
                    new Vector3(1.02f, 3.88f, 1),
                    new Vector3(1.85f, 2.47f, 1),
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.67f, -0.68f, 1),
                    new Vector3(-0.68f, -1.19f, 1),
                    new Vector3(1.02f, -0.16f, 1),
                    new Vector3(1.85f, -1.59f, 1),
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1.25f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                };
                levelData.numberOfDiff = 5;
                break;

            default:
                Debug.LogWarning($"Unrecognized level: {level}");
                levelData = null; // or set a default state
                break;
        }
        return levelData;
    }   
}