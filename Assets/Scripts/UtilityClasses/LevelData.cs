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
         if(level ==1){
            levelData.id =0;
            levelData.diffPos1 = new List<Vector3>
                            {
                                new Vector3(-1.71000004f,4.03999996f,1f),
                                new Vector3(1.50999999f,4.01000023f,1f),
                                new Vector3(-0.310000002f,0.75999999f,1),
                            } ;
            levelData.diffPos2 = new List<Vector3>
                            {
                               new Vector3(-1.71000004f,0.0199999996f,1),
                                new Vector3(1.50999999f,0,1),
                                new Vector3(-0.310000002f,-3.29999995f,1)
                            };
            levelData.diffScale = new List<Vector3>{
                                new Vector3(-0.0799999982f,-0.0799999982f,1),
                                new Vector3(-0.0799999982f,-0.0799999982f,1),
                                new Vector3(-0.0700000003f,-0.0700000003f,1)
                            };
            levelData.numberOfDiff = 3;
      
        }
        else if(level == 2){
                


                levelData.id =2;
            levelData.diffPos1 = new List<Vector3>
                            {
                               new Vector3(0.50999999f,2.93000007f,1),
                                new Vector3(2.17000008f,3.92000008f,1),
                                new Vector3(-1.49000001f,1.88f,1f)
                            } ;
            levelData.diffPos2 = new List<Vector3>
                            {
                               new Vector3(0.50999999f,-1.09f,1),
                                new Vector3(2.17000008f,-0.15f,1),
                                new Vector3(-1.49000001f,-2.23f,1f)
                            };
            levelData.diffScale = new List<Vector3>{
                                new Vector3(-0.0799999982f,-0.0799999982f,1),
                                new Vector3(-0.0399999991f,-0.0399999991f,0.5f),
                                new Vector3(0.0500000007f,0.0500000007f,-0.714285731f)
                            };
            levelData.numberOfDiff = 3;
        }
         else if(level == 3){
                levelData.id =3;
            levelData.diffPos1 = new List<Vector3>
                            {
                                new Vector3(0.75999999f,4.30999994f,1),
                                new Vector3(-0.159999996f,2.73000002f,1),
                                new Vector3(1.80999994f,2.99000001f,1),
                                new Vector3(-1.50999999f,2.83999991f,1),
                                new Vector3(-0.970000029f,1.12f,1)
                            } ;
            levelData.diffPos2 = new List<Vector3>
                            {
                                new Vector3(0.75999999f,0.23f,1),
                                new Vector3(-0.159999996f,-1.35f,1),
                                new Vector3(1.80999994f,-1.05f,1),
                                new Vector3(-1.50999999f,-1.27f,1),
                                new Vector3(-0.970000029f,-2.94f,1)
                            };
            levelData.diffScale = new List<Vector3>{    
                                new Vector3(-0.0399999991f,-0.0399999991f,1),
                                new Vector3(-0.0599999987f,-0.0599999987f,1),
                                new Vector3(-0.0500000007f,-0.0500000007f,1),
                                 new Vector3(-0.0700000003f,-0.0700000003f,1),
                                  new Vector3(0.0500000007f,0.0500000007f,1)
                            };
            levelData.numberOfDiff = 5;
        }

        return levelData;
    }   
}