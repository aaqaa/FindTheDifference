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
                    new Vector3(0.49f, 3.92f, 1),
                    new Vector3(-1.49f, 1.88f, 1),
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.51f, -1.09f, 1),
                    new Vector3(0.49f, 3.92f-4.1f, 1),
                    new Vector3(-1.49f, -2.23f, 1),
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.05f, -0.05f, 0.5f),
                    new Vector3(0.05f, 0.05f, -0.71f),
                };
                levelData.numberOfDiff = 3;
                break;
        case 3:
                levelData.id = 3;   
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.03f, 2.93f, 1),
                    new Vector3(0.67f, 2.06f, 1),
                    new Vector3(0.09f, 1.43f, 1),
                    new Vector3(0.74f, 3.67f, 1)
                };
             
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.03f, 2.93f-4.1f, 1),
                    new Vector3(0.67f, 2.06f-4.1f, 1),
                    new Vector3(0.09f, 1.43f-4.1f, 1),
                    new Vector3(0.74f, 3.67f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 0.5f),
                    new Vector3(0.05f, 0.05f, -0.71f),
                    new Vector3(0.08f, 0.08f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
        case 4:
                levelData.id = 4;   
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.11f, 2.26f, 1),
                    new Vector3(-0.71f, 2.79f, 1),
                    new Vector3(-1.36f, 1.24f, 1),
                    new Vector3(0.15f, 4.23f, 1)
                };
             
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.11f, 2.26f-4.1f, 1),
                    new Vector3(-0.71f, 2.79f-4.1f, 1),
                    new Vector3(-1.36f, 1.24f-4.1f, 1),
                    new Vector3(0.15f, 4.23f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.09f, -0.09f, 0.5f),
                    new Vector3(0.15f, 0.15f, -0.71f),
                    new Vector3(0.06f, 0.06f, 1)
                };
                levelData.numberOfDiff = 4;
                break;

            case 5:
                levelData.id = 5;   
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.13f, 3.35f, 1),
                    new Vector3(0.18f, 1.1f, 1),
                    new Vector3(1.22f, 1.24f, 1),
                    new Vector3(-2f, 3.99f, 1),
                    new Vector3(-0.61f, 1.25f, 1)
                };
             
                levelData.diffPos2 = new List<Vector3>
                {
                     new Vector3(0.13f, 3.35f-4.1f, 1),
                    new Vector3(0.18f, 1.1f-4.1f, 1),
                    new Vector3(1.22f, 1.24f-4.1f, 1),
                    new Vector3(-2f, 3.99f-4.1f, 1),
                    new Vector3(-0.61f, 1.25f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.05f, -0.05f, 0.5f),
                    new Vector3(0.09f, 0.09f, -0.71f),
                    new Vector3(0.06f, 0.06f, 1),
                    new Vector3(0.04f, 0.04f, 1)

                };
                levelData.numberOfDiff = 5;
                break;
            case 6:
                levelData.id = 6;   
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.16f, 3.63f, 1),
                    new Vector3(1.64f, 2.03f, 1),
                    new Vector3(1.07f, 1.54f, 1),
                    new Vector3(-1f, 2.58f, 1),
                    new Vector3(-0.45f, 3.31f, 1)
                };
             
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.16f, 3.63f-4.1f, 1),
                    new Vector3(1.64f, 2.03f-4.1f, 1),
                    new Vector3(1.07f, 1.54f-4.1f, 1),
                    new Vector3(-1f, 2.58f-4.1f, 1),
                    new Vector3(-0.45f, 3.31f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.05f, -0.05f, 0.5f),
                    new Vector3(0.04f, 0.04f, -0.71f),
                    new Vector3(0.04f, 0.04f, 1),
                    new Vector3(0.04f, 0.04f, 1)

                };
                levelData.numberOfDiff = 5;
                break;
            
            case 23:
                levelData.id = 23;
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
                    new Vector3(0.05f, 0.05f, 1)
                };
                levelData.numberOfDiff = 5;
                break;

            case 49:
                levelData.id = 49;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.67f, 3.42f, 1),
                    new Vector3(-0.68f, 2.91f, 1),
                    new Vector3(1.02f, 3.88f, 1),
                    new Vector3(1.85f, 2.47f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.67f, -0.68f, 1),
                    new Vector3(-0.68f, -1.19f, 1),
                    new Vector3(1.02f, -0.16f, 1),
                    new Vector3(1.85f, -1.59f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1.25f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.07f, -0.07f, 1)
                };
                levelData.numberOfDiff = 4;
                break;

            case 29:
                levelData.id = 29;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-0.46f,1.55f,1),new Vector3(-1.45f, 0.69f, 1),new Vector3(-0.77f, 3.29f, 1),new Vector3(1.45f, 1.3f, 1),new Vector3(0.45f, 3.22f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.46f,1.55f-4.1f,1),new Vector3(-1.45f, 0.69f-4.1f, 1),new Vector3(-0.77f, 3.29f-4.1f, 1),new Vector3(1.45f, 1.3f-4.1f, 1),new Vector3(0.45f, 3.22f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 30:
                levelData.id = 30;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(2.04f,4.23f,1),new Vector3(-1.76f, 3.71f, 1),new Vector3(0.94f, 4.28f, 1),new Vector3(-0.28f, 1.71f, 1),new Vector3(-0.09f, 0.7f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(2.04f,4.23f-4.1f,1),new Vector3(-1.76f, 3.71f-4.1f, 1),new Vector3(0.94f, 4.28f-4.1f, 1),new Vector3(-0.28f, 1.71f-4.1f, 1),new Vector3(-0.09f, 0.7f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 31:
                levelData.id = 31;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(2.04f,4.23f,1),new Vector3(-1.76f, 3.71f, 1),new Vector3(0.94f, 4.28f, 1),new Vector3(-0.28f, 1.71f, 1),new Vector3(-0.09f, 0.7f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(2.04f,4.23f-4.1f,1),new Vector3(-1.76f, 3.71f-4.1f, 1),new Vector3(0.94f, 4.28f-4.1f, 1),new Vector3(-0.28f, 1.71f-4.1f, 1),new Vector3(-0.09f, 0.7f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 46:
                levelData.id = 46;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.47f, 3.42f, 1),new Vector3(-0.91f, 3.37f, 1),new Vector3(1.52f, 2.41f, 1),new Vector3(0.7f, 2.53f, 1),new Vector3(-0.94f, 2.35f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.47f, 3.42f-4.1f, 1),new Vector3(-0.91f, 3.37f-4.1f, 1),new Vector3(1.52f, 2.41f-4.1f, 1),new Vector3(0.7f, 2.53f-4.1f, 1),new Vector3(-0.94f, 2.35f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.03f, -0.03f, 1f),
                    new Vector3(-0.03f, -0.03f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.08f, -0.08f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 7:
            //easy level
                levelData.id = 7;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.44f, 2.9f, 1),new Vector3(-0.73f, 3.58f, 1),new Vector3(0.46f, 2.84f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.44f, 2.9f-4.1f, 1),new Vector3(-0.73f, 3.58f-4.1f, 1),new Vector3(0.46f, 2.84f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 3;
                break;
               case 8:
                //difficult
                levelData.id = 8;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.09f, 1.95f, 1),new Vector3(-0.28f, 4.34f, 1),new Vector3(1.4f, 2.84f, 1),new Vector3(0.11f, 0.73f, 1),new Vector3(-0.79f, 3.29f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.09f, 1.95f-4.1f, 1),new Vector3(-0.28f, 4.34f-4.1f, 1),new Vector3(1.4f, 2.84f-4.1f, 1),new Vector3(0.11f, 0.73f-4.1f, 1),new Vector3(-0.79f, 3.29f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
                 case 9:
                //mideum
                levelData.id = 9;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.65f, 2.88f, 1),new Vector3(-1.47f, 4.11f, 1),new Vector3(-2.06f, 1.96f, 1),new Vector3(0.9f, 0.96f, 1),new Vector3(1.98f, 1.88f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.65f, 2.88f-4.1f, 1),new Vector3(-1.47f, 4.11f-4.1f, 1),new Vector3(-2.06f, 1.96f-4.1f, 1),new Vector3(0.9f, 0.96f-4.1f, 1),new Vector3(1.98f, 1.88f-4.1f, 1)                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.09f, -0.09f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
                 case 10:
                //easy
                levelData.id = 10;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.46f, 1.99f, 1),new Vector3(1.87f, 4.13f, 1),new Vector3(-1.91f, 2.96f, 1),new Vector3(-1.31f, 3.91f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.46f, 1.99f-4.1f, 1),new Vector3(1.87f, 4.13f-4.1f, 1),new Vector3(-1.91f, 2.96f-4.1f, 1),new Vector3(-1.31f, 3.91f-4.1f, 1)                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.03f, -0.03f, 1f),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 11:
                //easy
                levelData.id = 11;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.73f, 3.53f, 1),new Vector3(0.26f, 2.77f, 1),new Vector3(1.27f, 1.37f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.73f, 3.53f-4.1f, 1),new Vector3(0.26f, 2.77f-4.1f, 1),new Vector3(1.27f, 1.37f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 3;
                break;
            case 12:
                //easy
                levelData.id = 12;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.02f, 2.37f, 1),new Vector3(-1.55f, 1.84f, 1),new Vector3(-0.32f, 3.1f, 1),new Vector3(-1.23f, 2.93f, 1),new Vector3(1.27f, 3.66f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                     new Vector3(1.02f, 2.37f-4.1f, 1),new Vector3(-1.55f, 1.84f-4.1f, 1),new Vector3(-0.32f, 3.1f-4.1f, 1),new Vector3(-1.23f, 2.93f-4.1f, 1),new Vector3(1.27f, 3.66f-4.1f, 1)                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.08f, -0.08f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 13:
                //easy
                levelData.id = 13;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.62f, 3.38f, 1),new Vector3(-0.03f, 3.48f, 1),new Vector3(1.52f, 1.9f, 1),new Vector3(-1.31f, 2.52f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                     new Vector3(0.62f, 3.38f-4.1f, 1),new Vector3(-0.03f, 3.48f-4.1f, 1),new Vector3(1.52f, 1.9f-4.1f, 1),new Vector3(-1.31f, 2.52f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.03f, -0.03f, 1f),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.03f, -0.03f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 14:
                //easy
                levelData.id = 14;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.66f, 3.64f, 1),new Vector3(1.95f, 3.51f, 1),new Vector3(0.72f, 1.71f, 1),new Vector3(-1.49f, 0.75f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                     new Vector3(-0.66f, 3.64f-4.1f, 1),new Vector3(1.95f, 3.51f-4.1f, 1),new Vector3(0.72f, 1.71f-4.1f, 1),new Vector3(-1.49f, 0.75f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 15:
                //medium
                levelData.id = 15;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.66f, 3.72f, 1),new Vector3(1.72f, 1.35f, 1),new Vector3(-0.4f, 1.56f, 1),new Vector3(0.75f, 2.63f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                     new Vector3(-1.66f, 3.72f-4.1f, 1),new Vector3(1.72f, 1.35f-4.1f, 1),new Vector3(-0.4f, 1.56f-4.1f, 1),new Vector3(0.75f, 2.63f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1f),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.02f, -0.02f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 16:
                //hard
                levelData.id = 16;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.1f, 3.5f, 1),new Vector3(0.09f, 2.25f, 1),new Vector3(1.51f, 3.87f, 1),new Vector3(1.43f, 1.92f, 1),new Vector3(0.38f, 1.03f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.1f, 3.5f-4.1f, 1),new Vector3(0.09f, 2.25f-4.1f, 1),new Vector3(1.51f, 3.87f-4.1f, 1),new Vector3(1.43f, 1.92f-4.1f, 1),new Vector3(0.38f, 1.03f-4.1f, 1)

                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.03f, -0.03f, 1f),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.02f, -0.02f, 1),
                    new Vector3(-0.03f, -0.03f, 1),
                    new Vector3(-0.03f, -0.03f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 17:
                //hard
                levelData.id = 17;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.43f, 3.5f, 1),new Vector3(0.21f, 2.88f, 1),new Vector3(-1.99f, 3.23f, 1),new Vector3(0.17f, 0.86f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.43f, 3.5f-4.1f, 1),new Vector3(0.21f, 2.88f-4.1f, 1),new Vector3(-1.99f, 3.23f-4.1f, 1),new Vector3(0.17f, 0.86f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.03f, -0.03f, 1f),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.02f, -0.02f, 1),
                    new Vector3(-0.03f, -0.03f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 18:
                //hard
                levelData.id = 18;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.24f, 3.39f, 1),new Vector3(-1.34f, 3.43f, 1),new Vector3(-1.52f, 2.45f, 1),new Vector3(1.56f, 1.81f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.24f, 3.39f-4.1f, 1),new Vector3(-1.34f, 3.43f-4.1f, 1),new Vector3(-1.52f, 2.45f-4.1f, 1),new Vector3(1.56f, 1.81f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.03f, -0.03f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
             case 19:
                //hard
                levelData.id = 19;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.37f, 3.72f, 1),new Vector3(0.92f, 2.8f, 1),new Vector3(-1.99f, 2.26f, 1),new Vector3(1.82f, 3.94f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.37f, 3.72f-4.1f, 1),new Vector3(0.92f, 2.8f-4.1f, 1),new Vector3(-1.99f, 2.26f-4.1f, 1),new Vector3(1.82f, 3.94f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.03f, -0.03f, 1),
                    new Vector3(-0.01f, -0.05f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 20:
                //hard
                levelData.id = 20;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.06f, 3.72f, 1),new Vector3(0.16f, 2.35f, 1),new Vector3(-1.12f, 1.26f, 1),new Vector3(1.35f, 2.32f, 1),new Vector3(1.62f, 3.12f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.06f, 3.72f-4.1f, 1),new Vector3(0.16f, 2.35f-4.1f, 1),new Vector3(-1.12f, 1.26f-4.1f, 1),new Vector3(1.35f, 2.32f-4.1f, 1),new Vector3(1.62f, 3.12f-4.1f, 1)

                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.03f, -0.03f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.03f, -0.03f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 21:
                //hard
                levelData.id = 21;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.58f, 4.15f, 1),new Vector3(1.12f, 2.79f, 1),new Vector3(-1.64f, 1.05f, 1),new Vector3(1.54f, 0.95f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.37f, 3.72f-4.1f, 1),new Vector3(0.92f, 2.8f-4.1f, 1),new Vector3(-1.99f, 2.26f-4.1f, 1),new Vector3(1.82f, 3.94f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(0.07f, -0.03f, 1),
                    new Vector3(-0.04f, -0.04f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 22:
                //hard
                levelData.id = 22;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.35f, 2.73f, 1),new Vector3(0.1f, 1.96f, 1),new Vector3(-1.74f, 1.44f, 1),new Vector3(1.03f, 2.06f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.35f, 2.73f-4.1f, 1),new Vector3(0.1f, 1.96f-4.1f, 1),new Vector3(-1.74f, 1.44f-4.1f, 1),new Vector3(1.03f, 2.06f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.03f, -0.03f, 1f),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(0.05f, 0.05f, 1),
                    new Vector3(-0.03f, -0.03f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
        case 24:
                //hard
                levelData.id = 24;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.5f, 3.85f, 1),new Vector3(-0.24f, 3.36f, 1),new Vector3(0.51f, 1.63f, 1),new Vector3(-1.26f, 2.06f, 1),new Vector3(2.11f, 2.39f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.5f, 3.85f-4.1f, 1),new Vector3(-0.24f, 3.36f-4.1f, 1),new Vector3(0.51f, 1.63f-4.1f, 1),new Vector3(-1.26f, 2.06f-4.1f, 1),new Vector3(2.11f, 2.39f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.03f, -0.03f, 1f),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(0.04f, 0.04f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(0.04f, 0.04f, 1),
                };
                levelData.numberOfDiff = 5;
                break;
            case 25:
                //hard
                levelData.id = 25;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.31f, 3.04f, 1),new Vector3(-0.87f, 3.61f, 1),new Vector3(0.42f, 4.06f, 1),new Vector3(-1.63f, 1.5f, 1),new Vector3(0.12f, 1.73f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.5f, 3.85f-4.1f, 1),new Vector3(-0.24f, 3.36f-4.1f, 1),new Vector3(0.51f, 1.63f-4.1f, 1),new Vector3(-1.26f, 2.06f-4.1f, 1),new Vector3(2.11f, 2.39f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(0.04f, 0.04f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 26:
                //hard
                levelData.id = 26;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.09f, 1.86f, 1),new Vector3(-0.75f, 4.15f, 1),new Vector3(-1.68f, 4.3f, 1),new Vector3(1.75f, 0.83f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.09f, 1.86f-4.1f, 1),new Vector3(-0.75f, 4.15f-4.1f, 1),new Vector3(-1.68f, 4.3f-4.1f, 1),new Vector3(1.75f, 0.83f-4.1f, 1)                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(0.05f, 0.05f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 27:
                //hard
                levelData.id = 27;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.73f, 2.99f, 1),new Vector3(-1.23f, 2.16f, 1),new Vector3(-1.09f, 0.66f, 1),new Vector3(1.91f, 0.8f, 1),new Vector3(2.22f, 3.37f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.73f, 2.99f-4.1f, 1),new Vector3(-1.23f, 2.16f-4.1f, 1),new Vector3(-1.09f, 0.66f-4.1f, 1),new Vector3(1.91f, 0.8f-4.1f, 1),new Vector3(2.22f, 3.37f-4.1f, 1)
};
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(0.05f, 0.05f, 1),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
                case 28:
                //hard
                levelData.id = 28;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.54f, 4.36f, 1),new Vector3(-1.89f, 1.83f, 1),new Vector3(0.08f, 0.7f, 1),new Vector3(1.6f, 3.39f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.54f, 4.36f-4.1f, 1),new Vector3(-1.89f, 1.83f-4.1f, 1),new Vector3(0.08f, 0.7f-4.1f, 1),new Vector3(1.6f, 3.39f-4.1f, 1)
};
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(0.05f, 0.05f, 1),
                    new Vector3(-0.07f, -0.07f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            default:
                Debug.LogWarning($"Unrecognized level: {level}");
                levelData = null; // or set a default state
                break;
        }
        return levelData;
    }   
}