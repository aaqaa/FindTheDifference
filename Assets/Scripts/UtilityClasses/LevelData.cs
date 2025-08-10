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
                    
                    new Vector3(-0.68f,2.52f,1),new Vector3(1.95f, 1.13f, 1),new Vector3(1.88f, 3.11f, 1),new Vector3(-1.96f, 2.35f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.68f,2.52f-4.1f,1),new Vector3(1.95f, 1.13f-4.1f, 1),new Vector3(1.88f, 3.11f-4.1f, 1),new Vector3(-1.96f, 2.35f-4.1f, 1)                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.1f, -0.1f, 1),
                    new Vector3(-0.1f, -0.1f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 5:
                levelData.id = 5;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-1.79f,1.85f,1),new Vector3(1.6f, 3.08f, 1),new Vector3(1.96f, 1.73f, 1),new Vector3(0.15f, 3.18f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.79f,1.85f-4.1f,1),new Vector3(1.6f, 3.08f-4.1f, 1),new Vector3(1.96f, 1.73f-4.1f, 1),new Vector3(0.15f, 3.18f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
         case 6:
                levelData.id = 6;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-1.61f,2.3f,1),new Vector3(-0.21f, 0.98f, 1),new Vector3(-0.6f, 3.82f, 1),new Vector3(1.77f, 1.26f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.61f,2.3f-4.1f,1),new Vector3(-0.21f, 0.98f-4.1f, 1),new Vector3(-0.6f, 3.82f-4.1f, 1),new Vector3(1.77f, 1.26f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.07f, -0.07f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
         case 7:
                levelData.id = 7;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(0.43f,1.97f,1),new Vector3(-1.63f, 3.83f, 1),new Vector3(-0.25f, 2.42f, 1),new Vector3(-1.17f, 1.5f, 1),new Vector3(1.24f, 3.91f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.43f,1.97f-4.1f,1),new Vector3(-1.63f, 3.83f-4.1f, 1),new Vector3(-0.25f, 2.42f-4.1f, 1),new Vector3(-1.17f, 1.5f-4.1f, 1),new Vector3(1.24f, 3.91f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
         case 8:
                levelData.id = 8;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-1.27f,1.76f,1),new Vector3(1.15f, 2.12f, 1),new Vector3(0.03f, 3.91f, 1),new Vector3(0.17f, 1.53f, 1),new Vector3(-1.43f, 3.17f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.27f,1.76f-4.1f,1),new Vector3(1.15f, 2.12f-4.1f, 1),new Vector3(0.03f, 3.91f-4.1f, 1),new Vector3(0.17f, 1.53f-4.1f, 1),new Vector3(-1.43f, 3.17f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.08f, -0.08f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
        case 61:
                levelData.id = 61;   
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

            case 62:
                levelData.id = 62;   
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
            case 63:
                levelData.id = 63;   
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
                    new Vector3(-0.63f, 1.12f, 1),
                    new Vector3(1.07f, 3.04f, 1),
                    new Vector3(1.84f, 1.47f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.67f, 3.42f-4.1f, 1),
                    new Vector3(-0.63f, 1.12f-4.1f, 1),
                    new Vector3(1.07f, 3.04f-4.1f, 1),
                    new Vector3(1.84f, 1.47f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1.25f),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.09f, -0.09f, 1)
                };
                levelData.numberOfDiff = 4;
                break;

            case 29:
                levelData.id = 29;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-0.46f,1.55f,1),new Vector3(-1.45f, 0.69f, 1),new Vector3(-0.77f, 3.29f, 1),new Vector3(1.45f, 1.3f, 1),new Vector3(0.39f, 3.21f, 1)
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
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 30:
                levelData.id = 30;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(1.79f,  4.23f,1),new Vector3(-1.84f, 3.75f, 1),new Vector3(0.94f, 4.28f, 1),new Vector3(-0.16f, 1.71f, 1),new Vector3(-0.09f, 0.7f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.79f,  4.23f-4.1f,1),new Vector3(-1.84f, 3.75f-4.1f, 1),new Vector3(0.94f, 4.28f-4.1f, 1),new Vector3(-0.16f, 1.71f-4.1f, 1),new Vector3(-0.09f, 0.7f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.07f, -0.07f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 31:
                levelData.id = 31;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(1.01f,3.8f,1),new Vector3(-0.71f, 2.6f, 1),new Vector3(0.57f, 1.93f, 1),new Vector3(-1f, 0.88f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.01f,3.8f-4.1f,1),new Vector3(-0.71f, 2.6f-4.1f, 1),new Vector3(0.57f, 1.93f-4.1f, 1),new Vector3(-1f, 0.88f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 32:
                levelData.id = 32;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(1.29f,3.66f,1),new Vector3(2.02f, 2.65f, 1),new Vector3(-0.39f, 4.39f, 1),new Vector3(0.6f, 1.04f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.29f,3.66f-4.1f,1),new Vector3(2.02f, 2.65f-4.1f, 1),new Vector3(-0.39f, 4.39f-4.1f, 1),new Vector3(0.6f, 1.04f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 33:
                levelData.id = 33;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(1.27f,2.14f,1),new Vector3(-0.21f, 4f, 1),new Vector3(1.74f, 4.09f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.27f,2.14f-4.1f,1),new Vector3(-0.21f, 4f-4.1f, 1),new Vector3(1.74f, 4.09f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.08f, -0.08f, 1)
                };
                levelData.numberOfDiff = 3;
                break;
            case 34:
                levelData.id = 34;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-0.34f,2.3f,1),new Vector3(0.75f, 4.01f, 1),new Vector3(1.5f, 3.29f, 1),new Vector3(-1.2f, 0.98f, 1),new Vector3(1.76f, 0.93f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.34f,2.3f-4.1f,1),new Vector3(0.75f, 4.01f-4.1f, 1),new Vector3(1.5f, 3.29f-4.1f, 1),new Vector3(-1.2f, 0.98f-4.1f, 1),new Vector3(1.76f, 0.93f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.1f, -0.1f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(0.1f, 0.1f, 1),
                    new Vector3(0.1f, 0.1f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
             case 35:
                levelData.id = 35;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-1.65f,1.84f,1),new Vector3(-1.71f, 3.75f, 1),new Vector3(1.55f, 1.81f, 1),new Vector3(0.57f, 3.01f, 1),new Vector3(-0.14f, 1.23f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.65f,1.84f-4.1f,1),new Vector3(-1.71f, 3.75f-4.1f, 1),new Vector3(1.55f, 1.81f-4.1f, 1),new Vector3(0.57f, 3.01f-4.1f, 1),new Vector3(-0.14f, 1.23f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(0.06f, 0.06f, 1),
                    new Vector3(0.08f, 0.08f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
              case 36:
                levelData.id = 36;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-1.81f,3.24f,1),new Vector3(2.04f, 4.25f, 1),new Vector3(2.09f, 1.14f, 1),new Vector3(-1.73f, 1.23f, 1),new Vector3(0.44f, 1.77f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.81f,3.24f-4.1f,1),new Vector3(2.04f, 4.25f-4.1f, 1),new Vector3(2.09f, 1.14f-4.1f, 1),new Vector3(-1.73f, 1.23f-4.1f, 1),new Vector3(0.44f, 1.77f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(0.1f, 0.1f, 1),
                    new Vector3(0.1f, 0.1f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
                //need to do 37
             case 37:
                levelData.id = 37;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-1.07f,2.41f,1),new Vector3(0.42f, 4.09f, 1),new Vector3(1.99f, 1.28f, 1),new Vector3(-1.89f, 1.45f, 1),new Vector3(-1.48f, 3.92f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.07f,2.41f-4.1f,1),new Vector3(0.42f, 4.09f-4.1f, 1),new Vector3(1.99f, 1.28f-4.1f, 1),new Vector3(-1.89f, 1.45f-4.1f, 1),new Vector3(-1.48f, 3.92f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.1f, -0.1f, 1),
                    new Vector3(0.1f, 0.1f, 1),
                    new Vector3(0.1f, 0.1f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
             case 38:
                levelData.id = 38;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(0.88f,3.6f,1),new Vector3(-1.05f, 3.51f, 1),new Vector3(-0.18f, 2.16f, 1),new Vector3(-0.99f, 1.45f, 1),new Vector3(1.27f, 1.07f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.88f,3.6f-4.1f,1),new Vector3(-1.05f, 3.51f-4.1f, 1),new Vector3(-0.18f, 2.16f-4.1f, 1),new Vector3(-0.99f, 1.45f-4.1f, 1),new Vector3(1.27f, 1.07f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(0.06f, 0.06f, 1),
                    new Vector3(0.06f, 0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
             case 39:
                levelData.id = 39;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(1.65f,2.87f,1),new Vector3(-0.04f, 2.5f, 1),new Vector3(-1.04f, 1.77f, 1),new Vector3(1.39f, 1.35f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.65f,2.87f-4.1f,1),new Vector3(-0.04f, 2.5f-4.1f, 1),new Vector3(-1.04f, 1.77f-4.1f, 1),new Vector3(1.39f, 1.35f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(0.06f, 0.06f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
              case 40:
                levelData.id = 40;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-0.18f,4.39f,1),new Vector3(0.37f, 3.47f, 1),new Vector3(1.86f, 2.5f, 1),new Vector3(-1.28f, 1.97f, 1),new Vector3(1.04f, 0.84f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.18f,4.39f -4.1f,1),new Vector3(0.37f, 3.47f-4.1f, 1),new Vector3(1.86f, 2.5f-4.1f, 1),new Vector3(-1.28f, 1.97f-4.1f, 1),new Vector3(1.04f, 0.84f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(0.06f, 0.06f, 1),
                    new Vector3(0.06f, 0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
             case 41:
                levelData.id = 41;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(0.07f,3.89f,1),new Vector3(-1.61f, 3.69f, 1),new Vector3(1.49f, 2.42f, 1),new Vector3(-1.47f, 0.83f, 1),new Vector3(0.69f, 0.78f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.07f,3.89f-4.1f,1),new Vector3(-1.61f, 3.69f-4.1f, 1),new Vector3(1.49f, 2.42f-4.1f, 1),new Vector3(-1.47f, 0.83f-4.1f, 1),new Vector3(0.69f, 0.78f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(0.06f, 0.06f, 1),
                    new Vector3(0.06f, 0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
             case 42:
                levelData.id = 42;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-0.14f,2.33f,1),new Vector3(-1.02f, 3.46f, 1),new Vector3(1.8f, 3.4f, 1),new Vector3(0.18f, 0.83f, 1),new Vector3(1.26f, 1.55f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.14f,2.33f-4.1f,1),new Vector3(-1.02f, 3.46f-4.1f, 1),new Vector3(1.8f, 3.4f-4.1f, 1),new Vector3(0.18f, 0.83f-4.1f, 1),new Vector3(1.26f, 1.55f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(0.06f, 0.06f, 1),
                    new Vector3(0.06f, 0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 43:
                levelData.id = 43;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(0.94f,3.87f,1),new Vector3(-1.04f, 2.72f, 1),new Vector3(-1.11f, 1.72f, 1),new Vector3(1.88f, 0.83f, 1),new Vector3(1.42f, 2.3f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.94f,3.87f-4.1f,1),new Vector3(-1.04f, 2.72f-4.1f, 1),new Vector3(-1.11f, 1.72f-4.1f, 1),new Vector3(1.88f, 0.83f-4.1f, 1),new Vector3(1.42f, 2.3f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(0.07f, 0.07f, 1),
                    new Vector3(0.08f, 0.08f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
             case 44:
                levelData.id = 44;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-1.24f,3.76f,1),new Vector3(-0.68f, 2.78f, 1),new Vector3(0.68f, 4.25f, 1),new Vector3(1.16f, 1.27f, 1),new Vector3(1.81f, 3.24f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.24f,3.76f-4.1f,1),new Vector3(-0.68f, 2.78f-4.1f, 1),new Vector3(0.68f, 4.25f-4.1f, 1),new Vector3(1.16f, 1.27f-4.1f, 1),new Vector3(1.81f, 3.24f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(0.06f, 0.06f, 1),
                    new Vector3(0.07f, 0.07f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 45:
                levelData.id = 45;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(0.39f,4.24f,1),new Vector3(1.1f, 3.61f, 1),new Vector3(-1.18f, 3.12f, 1),new Vector3(-0.55f,1.31f, 1),new Vector3(1.87f, 1.98f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.39f,4.24f-4.1f,1),new Vector3(1.1f, 3.61f-4.1f, 1),new Vector3(-1.18f, 3.12f-4.1f, 1),new Vector3(-0.55f,1.31f-4.1f, 1),new Vector3(1.87f, 1.98f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(0.1f, 0.1f, 1),
                    new Vector3(0.06f, 0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 46:
                levelData.id = 46;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.56f, 4.24f, 1),new Vector3(-0.92f, 3.37f, 1),new Vector3(-1.33f, 1.22f, 1),new Vector3(0.85f, 2.11f, 1),new Vector3(0.15f, 3.13f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.56f, 4.24f-4.1f, 1),new Vector3(-0.92f, 3.37f-4.1f, 1),new Vector3(-1.33f, 1.22f-4.1f, 1),new Vector3(0.85f, 2.11f-4.1f, 1),new Vector3(0.15f, 3.13f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 47:
                levelData.id = 47;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.92f, 2.06f, 1),new Vector3(-0.18f, 4.25f, 1),new Vector3(-1.046f, 1.75f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.92f, 2.06f-4.1f, 1),new Vector3(-0.18f, 4.25f-4.1f, 1),new Vector3(-1.046f, 1.75f-4.1f, 1)                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.07f, -0.07f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.07f, -0.07f, 1)
                };
                levelData.numberOfDiff = 3;
                break;
             case 48:
                levelData.id = 48;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.45f, 0.85f, 1),new Vector3(-0.53f, 4.25f, 1),new Vector3(-0.95f, 2.37f, 1),new Vector3(1.43f, 2.39f, 1),new Vector3(0.13f, 1.05f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.45f, 0.85f-4.1f, 1),new Vector3(-0.53f, 4.25f-4.1f, 1),new Vector3(-0.95f, 2.37f-4.1f, 1),new Vector3(1.36f, 2.28f-4.1f, 1),new Vector3(0.13f, 1.05f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.07f, -0.07f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 50:
                levelData.id = 50;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.86f, 3.05f, 1),new Vector3(-1.27f, 3.46f, 1),new Vector3(-1.04f, 2.49f, 1),new Vector3(-0.63f, 1.64f, 1),new Vector3(0.91f, 1.99f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.86f, 3.05f-4.1f, 1),new Vector3(-1.27f, 3.46f-4.1f, 1),new Vector3(-1.04f, 2.49f-4.1f, 1),new Vector3(-0.63f, 1.64f-4.1f, 1),new Vector3(0.91f, 1.99f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.04f, -0.04f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 64:
            //easy level
                levelData.id = 64;
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
               case 65:
                //difficult
                levelData.id = 65;
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
                    new Vector3(-1.46f, 1.99f, 1),new Vector3(1.87f, 4.13f, 1),new Vector3(-1.91f, 2.96f, 1),new Vector3(-1.31f, 3.91f, 1),new Vector3(0.59f, 1.48f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.46f, 1.99f-4.1f, 1),new Vector3(1.87f, 4.13f-4.1f, 1),new Vector3(-1.91f, 2.96f-4.1f, 1),new Vector3(-1.31f, 3.91f-4.1f, 1),new Vector3(0.59f, 1.48f-4.1f, 1)                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.03f, -0.03f, 1f),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.08f, -0.08f, 1)
                };
                levelData.numberOfDiff = 5;
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
            case 67:
                //easy
                levelData.id = 67;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.12f, 3.48f, 1),new Vector3(1.46f, 3.85f, 1),new Vector3(0.1f, 2.25f, 1),new Vector3(0.39f, 1.25f, 1),new Vector3(1.41f, 1.92f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.12f, 3.48f-4.1f, 1),new Vector3(1.46f, 3.85f-4.1f, 1),new Vector3(0.1f, 2.25f-4.1f, 1),new Vector3(0.39f, 1.25f-4.1f, 1),new Vector3(1.41f, 1.92f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3> 
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 66:
                //medium
                levelData.id = 66;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.66f, 3.72f, 1),new Vector3(1.78f, 1.35f, 1),new Vector3(-0.3f, 1.46f, 1),new Vector3(0.75f, 2.63f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                     new Vector3(-1.66f, 3.72f-4.1f, 1),new Vector3(1.72f, 1.35f-4.1f, 1),new Vector3(-0.4f, 1.56f-4.1f, 1),new Vector3(0.75f, 2.63f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.08f, -0.08f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 15:
                //medium
                levelData.id = 15;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.01f,2.91f, 1),new Vector3(-1.4f, 3.79f, 1),new Vector3(1.93f, 4.02f, 1),new Vector3(0.75f, 1.17f, 1),new Vector3(-0.91f, 2.43f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.01f,2.91f-4.1f, 1),new Vector3(-1.4f, 3.79f-4.1f, 1),new Vector3(1.93f, 4.02f-4.1f, 1),new Vector3(0.75f, 1.17f-4.1f, 1),new Vector3(-0.91f, 2.43f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.1f, -0.1f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 16:
                //hard
                levelData.id = 16;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(2.02f, 3.5f, 1),new Vector3(0.32f, 3.7f, 1),new Vector3(-0.74f, 4.17f, 1),new Vector3(-0.95f, 1.49f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(2.02f, 3.5f-4.1f, 1),new Vector3(0.32f, 3.7f-4.1f, 1),new Vector3(-0.74f, 4.17f-4.1f, 1),new Vector3(-0.95f, 1.49f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 17:
                //hard
                levelData.id = 17;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.9f, 2.93f, 1),new Vector3(0.35f, 0.97f, 1),new Vector3(0.01f, 2.49f, 1),new Vector3(0.94f, 2.99f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.9f, 2.93f-4.1f, 1),new Vector3(0.35f, 0.97f-4.1f, 1),new Vector3(0.01f, 2.49f-4.1f, 1),new Vector3(0.94f, 2.99f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 18:
                //hard
                levelData.id = 18;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.24f, 3.39f, 1),new Vector3(-1.25f, 3.49f, 1),new Vector3(-1.52f, 2.45f, 1),new Vector3(1.56f, 1.81f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.24f, 3.39f-4.1f, 1),new Vector3(-1.34f, 3.43f-4.1f, 1),new Vector3(-1.52f, 2.45f-4.1f, 1),new Vector3(1.56f, 1.81f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.03f, -0.03f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 19:
                levelData.id = 19;
                levelData.diffPos1 = new List<Vector3>
                {
                    
                    new Vector3(-1.55f,2.29f,1),new Vector3(-0.84f, 4.12f, 1),new Vector3(0.6f, 3.91f, 1),new Vector3(1.33f, 2.65f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.55f,2.29f-4.1f,1),new Vector3(-0.84f, 4.12f-4.1f, 1),new Vector3(0.6f, 3.91f-4.1f, 1),new Vector3(1.33f, 2.65f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
             case 68:
                //hard
                levelData.id = 68;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.37f, 3.72f, 1),new Vector3(0.92f, 2.8f, 1),new Vector3(-1.99f, 2.26f, 1),new Vector3(1.65f, 4.02f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.37f, 3.72f-4.1f, 1),new Vector3(0.92f, 2.8f-4.1f, 1),new Vector3(-1.99f, 2.26f-4.1f, 1),new Vector3(1.65f, 4.02f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.03f, -0.03f, 1), 
                    new Vector3(-0.08f, -0.08f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 69:
                //hard
                levelData.id = 69;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.43f, 3.5f, 1),new Vector3(0.21f, 2.88f, 1),new Vector3(-1.99f, 3.23f, 1),new Vector3(0.17f, 0.86f, 1), new Vector3(1.29f, 2.03f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.43f, 3.5f-4.1f, 1),new Vector3(0.21f, 2.88f-4.1f, 1),new Vector3(-1.99f, 3.23f-4.1f, 1),new Vector3(0.17f, 0.86f-4.1f, 1), new Vector3(1.29f, 2.03f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1f),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
              case 70:
                //hard
                levelData.id = 70;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.16f, 3.5f, 1),new Vector3(0.84f, 1.22f, 1),new Vector3(1.82f, 3.23f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.16f, 3.5f-4.1f, 1),new Vector3(0.84f, 1.22f-4.1f, 1),new Vector3(1.82f, 3.23f-4.1f, 1)                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.09f, -0.09f, 1)
                };
                levelData.numberOfDiff = 3;
                break;
            case 20:
                //hard
                levelData.id = 20;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.3f, 3.72f, 1),new Vector3(0.16f, 2.35f, 1),new Vector3(-1.3f, 1.35f, 1),new Vector3(1.59f, 2.32f, 1),new Vector3(1.56f, 3.26f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.3f, 3.72f-4.1f, 1),new Vector3(0.16f, 2.35f-4.1f, 1),new Vector3(-1.3f, 1.35f-4.1f, 1),new Vector3(1.59f, 2.32f-4.1f, 1),new Vector3(1.56f, 3.26f-4.1f, 1)

                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.08f, -0.08f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
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
                    new Vector3(0.58f, 4.15f-4.1f, 1),new Vector3(1.12f, 2.79f-4.1f, 1),new Vector3(-1.64f, 1.05f-4.1f, 1),new Vector3(1.54f, 0.95f-4.1f, 1)
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
                    new Vector3(0.41f, 2.66f, 1),new Vector3(0.1f, 1.96f, 1),new Vector3(-1.74f, 1.44f, 1),new Vector3(0.91f, 2.06f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.41f, 2.66f-4.1f, 1),new Vector3(0.1f, 1.96f-4.1f, 1),new Vector3(-1.74f, 1.44f-4.1f, 1),new Vector3(0.91f, 2.06f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(0.05f, 0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
        case 24:
                //hard
                levelData.id = 24;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.5f, 3.85f, 1),new Vector3(-0.24f, 3.36f, 1),new Vector3(0.51f, 1.63f, 1),new Vector3(-1.26f, 1.92f, 1),new Vector3(2.11f, 2.47f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.5f, 3.85f-4.1f, 1),new Vector3(-0.24f, 3.36f-4.1f, 1),new Vector3(0.51f, 1.63f-4.1f, 1),new Vector3(-1.26f, 1.92f-4.1f, 1),new Vector3(2.11f, 2.47f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.03f, -0.03f, 1f),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(0.04f, 0.04f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(0.05f, 0.05f, 1),
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
                    new Vector3(0.31f, 3.04f-4.1f, 1),new Vector3(-0.87f, 3.61f-4.1f, 1),new Vector3(0.42f, 4.06f-4.1f, 1),new Vector3(-1.63f, 1.5f-4.1f, 1),new Vector3(0.12f, 1.73f-4.1f, 1)
                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(0.08f, 0.08f, 1),
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
                    new Vector3(-1.09f, 1.86f, 1),new Vector3(-0.75f, 4.15f, 1),new Vector3(-1.68f, 4.17f, 1),new Vector3(1.75f, 0.83f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.09f, 1.86f-4.1f, 1),new Vector3(-0.75f, 4.15f-4.1f, 1),new Vector3(-1.68f, 4.17f-4.1f, 1),new Vector3(1.75f, 0.83f-4.1f, 1)                                     };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(0.07f, 0.07f, 1),
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
                    new Vector3(-0.54f, 4.36f, 1),new Vector3(-1.89f, 1.83f, 1),new Vector3(0.08f, 0.89f, 1),new Vector3(1.74f, 3.76f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.54f, 4.36f-4.1f, 1),new Vector3(-1.89f, 1.83f-4.1f, 1),new Vector3(0.08f, 0.7f-4.1f, 1),new Vector3(1.74f, 3.76f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.04f, -0.04f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(0.06f, 0.06f, 1),
                    new Vector3(-0.08f, -0.08f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 51:
                levelData.id = 51;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.78f, 2.35f, 1),new Vector3(0.05f, 3.92f, 1),new Vector3(-0.18f, 0.84f, 1),new Vector3(1.72f, 3.63f, 1),new Vector3(1.88f, 0.99f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.78f, 2.35f-4.1f, 1),new Vector3(0.05f, 3.92f-4.1f, 1),new Vector3(-0.18f, 0.84f-4.1f, 1),new Vector3(1.72f, 3.63f-4.1f, 1),new Vector3(1.88f, 0.99f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.08f, -0.08f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 52:
                levelData.id = 52;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.31f, 4.2f, 1),new Vector3(1.79f, 4.05f, 1),new Vector3(2.02f, 3.06f, 1),new Vector3(-1.36f, 2.52f, 1),new Vector3(-0.3f, 1.75f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.31f, 4.2f-4.1f, 1),new Vector3(1.79f, 4.05f-4.1f, 1),new Vector3(2.02f, 3.06f-4.1f, 1),new Vector3(-1.36f, 2.52f-4.1f, 1),new Vector3(-0.3f, 1.75f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.1f, -0.1f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 53:
                levelData.id = 53;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.31f, 3.6f, 1),new Vector3(-1.78f, 3.69f, 1),new Vector3(-1.31f, 1.18f, 1),new Vector3(0.44f, 1.64f, 1),new Vector3(1.1f, 2.35f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.31f, 3.6f-4.1f, 1),new Vector3(-1.78f, 3.69f-4.1f, 1),new Vector3(-1.31f, 1.18f-4.1f, 1),new Vector3(0.44f, 1.64f-4.1f, 1),new Vector3(1.1f, 2.35f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 54:
                levelData.id = 54;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.76f, 3.51f, 1),new Vector3(-0.31f, 3.45f, 1),new Vector3(-1.45f, 2.03f, 1),new Vector3(0.11f, 1.7f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.76f, 3.51f-4.1f, 1),new Vector3(-0.31f, 3.45f-4.1f, 1),new Vector3(-1.45f, 2.03f-4.1f, 1),new Vector3(0.11f, 1.7f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.08f, -0.08f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 55:
                levelData.id = 55;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.88f, 3.92f, 1),new Vector3(0.35f, 4.24f, 1),new Vector3(-1.7f, 3.72f, 1),new Vector3(0.08f, 0.88f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.88f, 3.92f-4.1f, 1),new Vector3(0.35f, 4.24f-4.1f, 1),new Vector3(-1.7f, 3.72f-4.1f, 1),new Vector3(0.08f, 0.88f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.07f, -0.07f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 56:
                levelData.id = 56;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.27f, 3.17f, 1),new Vector3(-1.85f, 4.04f, 1),new Vector3(-0.23f, 1.79f, 1),new Vector3(0.88f, 1.41f, 1),new Vector3(-1.62f, 0.9f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.27f, 3.17f-4.1f, 1),new Vector3(-1.85f, 4.04f-4.1f, 1),new Vector3(-0.23f, 1.79f-4.1f, 1),new Vector3(0.88f, 1.41f-4.1f, 1),new Vector3(-1.62f, 0.9f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.08f, -0.08f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.07f, -0.07f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 57:
                levelData.id = 57;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.81f, 3.3f, 1),new Vector3(-2.09f, 3.37f, 1),new Vector3(-0.01f, 1.43f, 1),new Vector3(-1.89f, 0.7f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.81f, 3.3f-4.1f, 1),new Vector3(-2.09f, 3.37f-4.1f, 1),new Vector3(-0.01f, 1.43f-4.1f, 1),new Vector3(-1.89f, 0.7f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.08f, -0.08f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 58:
                levelData.id = 58;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.27f, 4.21f, 1),new Vector3(-1.77f, 3.08f, 1),new Vector3(2.17f, 2.8f, 1),new Vector3(-1.49f, 1.52f, 1),new Vector3(0.43f, 2.69f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.27f, 4.21f-4.1f, 1),new Vector3(-1.77f, 3.08f-4.1f, 1),new Vector3(2.17f, 2.8f-4.1f, 1),new Vector3(-1.49f, 1.52f-4.1f, 1),new Vector3(0.43f, 2.69f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
                case 59:
                levelData.id = 59;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.08f, 4.24f, 1),new Vector3(0.72f, 3.46f, 1),new Vector3(-1.05f, 1.81f, 1),new Vector3(0.2f, 0.75f, 1),new Vector3(1.81f, 0.84f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.08f, 4.24f-4.1f, 1),new Vector3(0.72f, 3.46f-4.1f, 1),new Vector3(-1.05f, 1.81f-4.1f, 1),new Vector3(0.2f, 0.75f-4.1f, 1),new Vector3(1.81f, 0.84f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
                case 60:
                levelData.id = 60;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.16f, 3.83f, 1),new Vector3(-1.89f, 2.84f, 1),new Vector3(-1.55f, 1.97f, 1),new Vector3(0.58f, 2.09f, 1),new Vector3(1.29f, 2.5f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.16f, 3.83f-4.1f, 1),new Vector3(-1.89f, 2.84f-4.1f, 1),new Vector3(-1.55f, 1.97f-4.1f, 1),new Vector3(0.58f, 2.09f-4.1f, 1),new Vector3(1.29f, 2.5f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1f),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.04f, -0.04f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 71:
                //hard
                levelData.id = 71;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.92f, 3.13f, 1),new Vector3(-0.12f, 2.77f, 1),new Vector3(1.11f, 3.47f, 1),new Vector3(0.78f, 2.36f, 1), new Vector3(-1.94f, 1.51f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.92f, 3.13f-4.1f, 1),new Vector3(-0.12f, 2.77f-4.1f, 1),new Vector3(1.11f, 3.47f-4.1f, 1),new Vector3(0.78f, 2.36f-4.1f, 1), new Vector3(-1.94f, 1.51f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.04f, -0.04f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.06f, -0.06f, 1)
                };
                levelData.numberOfDiff = 5;
                break;
            case 72:
                //hard
                levelData.id = 72;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.52f, 4.04f, 1),new Vector3(-0.15f, 1.47f, 1),new Vector3(1.19f, 2.26f, 1),new Vector3(-1.45f, 2.37f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.52f, 4.04f-4.1f, 1),new Vector3(-0.15f, 1.47f-4.1f, 1),new Vector3(1.19f, 2.26f-4.1f, 1),new Vector3(-1.45f, 2.37f-4.1f, 1)
                                                  };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.07f, -0.07f, 1)
                };
                levelData.numberOfDiff = 4;
                break;
            case 73:
                //hard
                levelData.id = 73;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.02f, 3.35f, 1),new Vector3(1.46f, 3.86f, 1),new Vector3(-1.32f, 1.17f, 1),new Vector3(-1.96f, 2.54f, 1),new Vector3(1.25f, 1.68f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.02f, 3.35f-4.1f, 1),new Vector3(1.46f, 3.86f-4.1f, 1),new Vector3(-1.32f, 1.17f-4.1f, 1),new Vector3(-1.96f, 2.54f-4.1f, 1),new Vector3(1.25f, 1.68f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.06f, -0.06f, 1),

                };
                levelData.numberOfDiff = 5;
                break;
             case 74:
                //hard
                levelData.id = 74;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.26f, 3.77f, 1),new Vector3(-1.56f, 3.7f, 1),new Vector3(-0.23f, 2.64f, 1),new Vector3(-1.82f, 2.54f, 1),new Vector3(1.27f, 1.48f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.26f, 3.77f-4.1f, 1),new Vector3(-1.56f, 3.7f-4.1f, 1),new Vector3(-0.23f, 2.64f-4.1f, 1),new Vector3(-1.82f, 2.54f-4.1f, 1),new Vector3(1.27f, 1.48f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(0.1f, -0.06f, 1),

                };
                levelData.numberOfDiff = 5;
                break;
             case 75:
                //hard
                levelData.id = 75;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.12f, 2.78f, 1),new Vector3(1.76f, 4.13f, 1),new Vector3(0.26f, 1.49f, 1)
                     };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.12f, 2.78f-4.1f, 1),new Vector3(1.76f, 4.13f-4.1f, 1),new Vector3(0.26f, 1.49f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.07f, -0.07f, 1f),
                    new Vector3(-0.09f, -0.09f, 1),
                    new Vector3(-0.05f, -0.05f, 1)
                };
                levelData.numberOfDiff = 3;
                break;
             case 76:
                //hard
                levelData.id = 76;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.47f, 4.03f, 1),new Vector3(0.99f, 2.84f, 1),new Vector3(0.47f, 1.34f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.47f, 4.03f-4.1f, 1),new Vector3(0.99f, 2.84f-4.1f, 1),new Vector3(0.47f, 1.34f-4.1f, 1)                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1)

                };
                levelData.numberOfDiff = 3;
                break;
            case 77:
                //hard
                levelData.id = 77;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.43f, 3.67f, 1),new Vector3(1.24f, 2.35f, 1),new Vector3(-0.46f, 1.74f, 1),new Vector3(-1.97f, 2.46f, 1),new Vector3(-1.52f, 1.18f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.43f, 3.67f-4.1f, 1),new Vector3(1.24f, 2.35f-4.1f, 1),new Vector3(-0.46f, 1.74f-4.1f, 1),new Vector3(-1.97f, 2.46f-4.1f, 1),new Vector3(-1.52f, 1.18f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.07f, -0.07f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(0.07f, 0.07f, 1),

                };
                levelData.numberOfDiff = 5;
                break;
            case 78:
                //hard
                levelData.id = 78;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.78f, 3.42f, 1),new Vector3(-0.82f, 3.74f, 1),new Vector3(-1.22f, 1.14f, 1),new Vector3(1.81f, 1.01f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.78f, 3.42f-4.1f, 1),new Vector3(-0.82f, 3.74f-4.1f, 1),new Vector3(-1.22f, 1.14f-4.1f, 1),new Vector3(1.81f, 1.01f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.07f, -0.07f, 1)

                };
                levelData.numberOfDiff = 4;
                break;
            case 79:
                //hard
                levelData.id = 79;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.96f, 4.34f, 1),new Vector3(1.22f, 3.29f, 1),new Vector3(-0.64f, 1.3f, 1),new Vector3(-1.9f, 2.48f, 1),new Vector3(2.01f, 1.93f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.96f, 4.34f-4.1f, 1),new Vector3(1.22f, 3.29f-4.1f, 1),new Vector3(-0.64f, 1.3f-4.1f, 1),new Vector3(-1.9f, 2.48f-4.1f, 1),new Vector3(2.01f, 1.93f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(0.07f, -0.07f, 1),

                };
                levelData.numberOfDiff = 5;
                break;
            case 80:
                //hard
                levelData.id = 80;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.51f, 3.26f, 1),new Vector3(-1.32f, 3.7f, 1),new Vector3(-1.07f, 2.03f, 1),new Vector3(-0.52f, 1.22f, 1),new Vector3(1.52f, 1.88f, 1)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.51f, 3.26f-4.1f, 1),new Vector3(-1.32f, 3.7f-4.1f, 1),new Vector3(-1.07f, 2.03f-4.1f, 1),new Vector3(-0.52f, 1.22f-4.1f, 1),new Vector3(1.52f, 1.88f-4.1f, 1)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1f),
                    new Vector3(-0.06f, -0.06f, 1),
                    new Vector3(-0.07f, -0.07f, 1),
                    new Vector3(-0.05f, -0.05f, 1),
                    new Vector3(0.05f, 0.05f, 1),

                };
                levelData.numberOfDiff = 5;
                break;
             case 81:
                //hard
                levelData.id = 81;         
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(2.05f, 3.46f, 1.00f),
                    new Vector3(0.00f, 3.36f, 1.00f),
                    new Vector3(-0.35f, 1.38f, 1.00f),
                    new Vector3(1.03f, 1.37f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(2.05f, -0.64f, 1.00f),
                    new Vector3(0.00f, -0.74f, 1.00f),
                    new Vector3(-0.35f, -2.72f, 1.00f),
                    new Vector3(1.03f, -2.73f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(-0.07f, -0.07f, 1.00f)
                };
                levelData.numberOfDiff = 4;

                break;
             case 82:
                //hard
                levelData.id = 82;
               levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.67f, 3.96f, 1.00f),
                    new Vector3(1.60f, 3.41f, 1.00f),
                    new Vector3(0.16f, 2.18f, 1.00f),
                    new Vector3(-0.98f, 1.26f, 1.00f),
                    new Vector3(0.77f, 0.88f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.67f, -0.14f, 1.00f),
                    new Vector3(1.60f, -0.69f, 1.00f),
                    new Vector3(0.16f, -1.92f, 1.00f),
                    new Vector3(-0.98f, -2.84f, 1.00f),
                    new Vector3(0.77f, -3.22f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.07f, -0.07f, 1.17f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 0.71f),
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(0.05f, 0.05f, 1.00f)
                };
                levelData.numberOfDiff = 5;

                break;
             case 83:
                //hard
                levelData.id = 83;
                            levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.82f, 4.03f, 1.00f),
                    new Vector3(-1.95f, 2.59f, 1.00f),
                    new Vector3(0.42f, 2.03f, 1.00f),
                    new Vector3(1.02f, 1.65f, 1.00f),
                    new Vector3(-2.01f, 1.22f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.82f, -0.07f, 1.00f),
                    new Vector3(-1.95f, -1.51f, 1.00f),
                    new Vector3(0.42f, -2.07f, 1.00f),
                    new Vector3(1.02f, -2.45f, 1.00f),
                    new Vector3(-2.01f, -2.88f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.08f, -0.08f, 1.33f),
                    new Vector3(0.05f, 0.05f, -0.71f),
                    new Vector3(0.05f, 0.05f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.20f)
                };
                levelData.numberOfDiff = 5;
                break;
                 case 84:
                //hard
                levelData.id = 84;
              levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.52f, 3.41f, 1.00f),                    new Vector3(0.31f, 3.08f, 1.00f),
                    new Vector3(0.80f, 2.22f, 1.00f),
                    new Vector3(0.94f, 1.17f, 1.00f),
                    new Vector3(-1.15f, 0.69f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.52f, -0.69f, 1.00f),
                    new Vector3(0.31f, -1.02f, 1.00f),
                    new Vector3(0.80f, -1.88f, 1.00f),
                    new Vector3(0.94f, -2.93f, 1.00f),
                    new Vector3(-1.15f, -3.41f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(0.05f, 0.05f, 1.00f),
                    new Vector3(-0.07f, -0.07f, 1.00f)
                };
                levelData.numberOfDiff = 5;

                break;
              case 85:
                //hard
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.16f, 3.99f, 1.00f),
                    new Vector3(-1.99f, 2.66f, 1.00f),
                    new Vector3(1.10f, 2.49f, 1.00f),
                    new Vector3(-1.45f, 1.56f, 1.00f),
                    new Vector3(1.88f, 0.84f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.16f, -0.11f, 1.00f),
                    new Vector3(-1.99f, -1.44f, 1.00f),
                    new Vector3(1.10f, -1.61f, 1.00f),
                    new Vector3(-1.45f, -2.54f, 1.00f),
                    new Vector3(1.88f, -3.26f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.08f, -0.08f, 1.33f),
                    new Vector3(-0.07f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.05f, 1.00f),
                    new Vector3(0.07f, 0.07f, -0.70f),
                    new Vector3(-0.10f, -0.10f, 1.00f)
                };
                levelData.numberOfDiff = 5;
                levelData.id = 85;
                break;
            case 86:
                //hard
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.26f, 4.12f, 1.00f),
                    new Vector3(-0.97f, 3.05f, 1.00f),
                    new Vector3(1.26f, 2.12f, 1.00f),
                    new Vector3(0.02f, 1.27f, 1.00f),
                    new Vector3(-1.45f, 1.16f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.26f, 0.02f, 1.00f),
                    new Vector3(-0.97f, -1.05f, 1.00f),
                    new Vector3(1.26f, -1.98f, 1.00f),
                    new Vector3(0.02f, -2.83f, 1.00f),
                    new Vector3(-1.45f, -2.94f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.07f, -0.07f, 1.17f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(0.05f, 0.05f, -0.50f),
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(-0.10f, -0.10f, 1.00f)
                };
                levelData.numberOfDiff = 5;
                levelData.id = 86;
                break;
            case 87:
                //hard
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.38f, 4.06f, 1.00f),
                    new Vector3(0.50f, 3.88f, 1.00f),
                    new Vector3(0.09f, 1.98f, 1.00f),
                    new Vector3(-1.98f, 1.94f, 1.00f),
                    new Vector3(1.55f, 1.47f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.38f, -0.04f, 1.00f),
                    new Vector3(0.50f, -0.22f, 1.00f),
                    new Vector3(0.09f, -2.12f, 1.00f),
                    new Vector3(-1.98f, -2.16f, 1.00f),
                    new Vector3(1.55f, -2.63f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 0.86f),
                    new Vector3(0.05f, 0.05f, 1.00f)
                };
                levelData.numberOfDiff = 5;
                    levelData.id = 87;
                break;
            case 88:
                            //hard
            levelData.diffPos1 = new List<Vector3>
            {
                new Vector3(0.26f, 4.09f, 1.00f),
                new Vector3(-0.56f, 3.52f, 1.00f),
                new Vector3(-1.00f, 2.22f, 1.00f),
                new Vector3(-1.58f, 1.51f, 1.00f),
                new Vector3(1.18f, 0.69f, 1.00f)
            };
            levelData.diffPos2 = new List<Vector3>
            {
                new Vector3(0.26f, -0.01f, 1.00f),
                new Vector3(-0.56f, -0.58f, 1.00f),
                new Vector3(-1.00f, -1.88f, 1.00f),
                new Vector3(-1.58f, -2.59f, 1.00f),
                new Vector3(1.18f, -3.41f, 1.00f)
            };
            levelData.diffScale = new List<Vector3>
            {
                new Vector3(-0.06f, -0.06f, 1.00f),
                new Vector3(-0.06f, -0.06f, 1.00f),
                new Vector3(-0.05f, -0.05f, 1.00f),
                new Vector3(0.05f, 0.05f, 1.00f),
                new Vector3(-0.05f, -0.05f, 0.71f)
            };
            levelData.numberOfDiff = 5;
                levelData.id = 88;
                break;
            case 89:
                //hard
                levelData.id = 89;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.58f, 4.21f, 1.00f),
                    new Vector3(-1.46f, 3.41f, 1.00f),
                    new Vector3(1.67f, 2.98f, 1.00f),
                    new Vector3(-1.59f, 1.21f, 1.00f),
                    new Vector3(2.01f, 1.06f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.58f, 0.11f, 1.00f),
                    new Vector3(-1.46f, -0.69f, 1.00f),
                    new Vector3(1.67f, -1.12f, 1.00f),
                    new Vector3(-1.59f, -2.89f, 1.00f),
                    new Vector3(2.01f, -3.04f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(0.05f, 0.05f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(-0.07f, -0.07f, 1.00f)
                };
                levelData.numberOfDiff = 5;

                break;
            case 90:
                //hard
                levelData.id = 90;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.02f, 3.35f, 1.00f),
                    new Vector3(-1.34f, 3.03f, 1.00f),
                    new Vector3(1.12f, 2.39f, 1.00f),
                    new Vector3(1.87f, 1.11f, 1.00f),
                    new Vector3(-0.58f, 1.00f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.02f, -0.75f, 1.00f),
                    new Vector3(-1.34f, -1.07f, 1.00f),
                    new Vector3(1.12f, -1.71f, 1.00f),
                    new Vector3(1.87f, -2.99f, 1.00f),
                    new Vector3(-0.58f, -3.10f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(0.05f, 0.05f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 0.86f)
                };
                levelData.numberOfDiff = 5;

                break;
            case 91:
                //hard
                levelData.id = 91;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.73f, 3.84f, 1.00f),
                    new Vector3(-1.01f, 3.40f, 1.00f),
                    new Vector3(-1.43f, 2.23f, 1.00f),
                    new Vector3(1.89f, 1.75f, 1.00f),
                    new Vector3(0.01f, 1.51f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.73f, -0.26f, 1.00f),
                    new Vector3(-1.01f, -0.70f, 1.00f),
                    new Vector3(-1.43f, -1.87f, 1.00f),
                    new Vector3(1.89f, -2.35f, 1.00f),
                    new Vector3(0.01f, -2.59f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(0.05f, 0.05f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 0.86f),
                    new Vector3(-0.05f, -0.05f, 1.00f)
                };
                levelData.numberOfDiff = 5;



                break;
            case 92:
                //hard
                levelData.id = 92;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.49f, 3.97f, 1.00f),
                    new Vector3(1.34f, 3.59f, 1.00f),
                    new Vector3(-0.25f, 3.56f, 1.00f),
                    new Vector3(-1.74f, 1.33f, 1.00f),
                    new Vector3(0.64f, 0.84f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.49f, -0.13f, 1.00f),
                    new Vector3(1.34f, -0.51f, 1.00f),
                    new Vector3(-0.25f, -0.54f, 1.00f),
                    new Vector3(-1.74f, -2.77f, 1.00f),
                    new Vector3(0.64f, -3.26f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(0.05f, 0.05f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 0.71f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.07f, -0.07f, 1.17f)
                };
                levelData.numberOfDiff = 5;

                break;
            case 93:
                //hard
                levelData.id = 93;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-1.39f, 4.07f, 1.00f),
                    new Vector3(1.51f, 3.62f, 1.00f),
                    new Vector3(-0.41f, 2.43f, 1.00f),
                    new Vector3(1.43f, 1.68f, 1.00f),
                    new Vector3(-1.16f, 0.90f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-1.39f, -0.03f, 1.00f),
                    new Vector3(1.51f, -0.48f, 1.00f),
                    new Vector3(-0.41f, -1.67f, 1.00f),
                    new Vector3(1.43f, -2.42f, 1.00f),
                    new Vector3(-1.16f, -3.20f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 0.71f),
                    new Vector3(0.05f, 0.05f, 1.00f)
                };
                levelData.numberOfDiff = 5;

                break;
            case 94:
                //hard
                levelData.id = 94;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.73f, 3.82f, 1.00f),
                    new Vector3(-1.38f, 2.63f, 1.00f),
                    new Vector3(-0.49f, 2.30f, 1.00f),
                    new Vector3(1.37f, 2.29f, 1.00f),
                    new Vector3(0.06f, 0.78f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.73f, -0.28f, 1.00f),
                    new Vector3(-1.38f, -1.47f, 1.00f),
                    new Vector3(-0.49f, -1.80f, 1.00f),
                    new Vector3(1.37f, -1.81f, 1.00f),
                    new Vector3(0.06f, -3.32f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.05f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(0.05f, 0.05f, 1.00f),
                    new Vector3(-0.07f, -0.07f, 1.00f)
                };
                levelData.numberOfDiff = 5;

                break;
            case 95:
                //hard
                levelData.id = 95;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.96f, 4.22f, 1.00f),
                    new Vector3(0.03f, 4.21f, 1.00f),
                    new Vector3(0.01f, 2.50f, 1.00f),
                    new Vector3(-1.27f, 1.32f, 1.00f),
                    new Vector3(1.31f, 1.27f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.96f, 0.12f, 1.00f),
                    new Vector3(0.03f, 0.11f, 1.00f),
                    new Vector3(0.01f, -1.60f, 1.00f),
                    new Vector3(-1.27f, -2.78f, 1.00f),
                    new Vector3(1.31f, -2.83f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.07f, -0.07f, 1.00f),
                    new Vector3(0.06f, 0.06f, 1.00f)
                };
                levelData.numberOfDiff = 5;

                break;
            case 96:
                //hard
                levelData.id = 96;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.18f, 4.21f, 1.00f),
                    new Vector3(1.35f, 3.45f, 1.00f),
                    new Vector3(-1.96f, 2.61f, 1.00f),
                    new Vector3(0.03f, 1.92f, 1.00f),
                    new Vector3(1.44f, 1.38f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.18f, 0.11f, 1.00f),
                    new Vector3(1.35f, -0.65f, 1.00f),
                    new Vector3(-1.96f, -1.49f, 1.00f),
                    new Vector3(0.03f, -2.18f, 1.00f),
                    new Vector3(1.44f, -2.72f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.07f, -0.07f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(0.05f, 0.05f, 1.00f)
                };
                levelData.numberOfDiff = 5;

                break;
            case 97:
                //hard
                levelData.id = 97;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(0.83f, 3.86f, 1.00f),
                    new Vector3(-0.20f, 3.25f, 1.00f),
                    new Vector3(-1.66f, 2.22f, 1.00f),
                    new Vector3(0.23f, 2.02f, 1.00f),
                    new Vector3(0.54f, 1.34f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(0.83f, -0.24f, 1.00f),
                    new Vector3(-0.20f, -0.85f, 1.00f),
                    new Vector3(-1.66f, -1.88f, 1.00f),
                    new Vector3(0.23f, -2.08f, 1.00f),
                    new Vector3(0.54f, -2.76f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(0.05f, 0.05f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 0.86f)
                };
                levelData.numberOfDiff = 5;

                break;
            case 98:
                //hard
                levelData.id = 98;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.03f, 3.57f, 1.00f),
                    new Vector3(-1.80f, 2.79f, 1.00f),
                    new Vector3(0.27f, 2.74f, 1.00f),
                    new Vector3(1.12f, 1.26f, 1.00f),
                    new Vector3(-1.86f, 1.09f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.03f, -0.53f, 1.00f),
                    new Vector3(-1.80f, -1.31f, 1.00f),
                    new Vector3(0.27f, -1.36f, 1.00f),
                    new Vector3(1.12f, -2.84f, 1.00f),
                    new Vector3(-1.86f, -3.01f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 0.83f),
                    new Vector3(0.05f, 0.05f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 0.86f)
                };
                levelData.numberOfDiff = 5;

                break;
            case 99:
                //hard
                levelData.id = 99;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.25f, 4.22f, 1.00f),
                    new Vector3(-0.11f, 3.90f, 1.00f),
                    new Vector3(-1.31f, 1.91f, 1.00f),
                    new Vector3(-1.21f, 0.76f, 1.00f),
                    new Vector3(0.84f, 0.65f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.25f, 0.12f, 1.00f),
                    new Vector3(-0.11f, -0.20f, 1.00f),
                    new Vector3(-1.31f, -2.19f, 1.00f),
                    new Vector3(-1.21f, -3.34f, 1.00f),
                    new Vector3(0.84f, -3.45f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.05f, -0.05f, 0.71f),
                    new Vector3(0.06f, 0.06f, 1.00f)
                };
                levelData.numberOfDiff = 5;

                break;
            case 100:
                //hard
                levelData.id = 100;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(1.21f, 4.20f, 1.00f),
                    new Vector3(-1.23f, 3.44f, 1.00f),
                    new Vector3(1.15f, 2.54f, 1.00f),
                    new Vector3(-0.74f, 1.42f, 1.00f),
                    new Vector3(0.34f, 1.06f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(1.21f, 0.10f, 1.00f),
                    new Vector3(-1.23f, -0.66f, 1.00f),
                    new Vector3(1.15f, -1.56f, 1.00f),
                    new Vector3(-0.74f, -2.68f, 1.00f),
                    new Vector3(0.34f, -3.04f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 0.83f),
                    new Vector3(-0.06f, -0.06f, 1.00f),
                    new Vector3(-0.06f, -0.06f, 1.20f),
                    new Vector3(-0.06f, -0.06f, 0.86f),
                    new Vector3(0.06f, 0.06f, 1.20f)
                };
                levelData.numberOfDiff = 5;

                break;        
            case 101:
                //hard
                levelData.id = 101;
                levelData.diffPos1 = new List<Vector3>
                {
                    new Vector3(-0.08f, 3.93f, 1.00f),
                    new Vector3(1.59f, 3.92f, 1.00f),
                    new Vector3(1.22f, 3.23f, 1.00f),
                    new Vector3(-1.78f, 2.46f, 1.00f),
                    new Vector3(0.22f, 1.17f, 1.00f)
                };
                levelData.diffPos2 = new List<Vector3>
                {
                    new Vector3(-0.08f, -0.17f, 1.00f),
                    new Vector3(1.59f, -0.18f, 1.00f),
                    new Vector3(1.22f, -0.87f, 1.00f),
                    new Vector3(-1.78f, -1.64f, 1.00f),
                    new Vector3(0.22f, -2.93f, 1.00f)
                };
                levelData.diffScale = new List<Vector3>
                {
                    new Vector3(-0.05f, -0.05f, 0.83f),
                    new Vector3(-0.07f, -0.07f, 1.17f),
                    new Vector3(-0.04f, -0.04f, 0.80f),
                    new Vector3(-0.04f, -0.04f, 0.57f),
                    new Vector3(0.04f, 0.04f, 0.80f)
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