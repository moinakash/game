using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour
{
  
    void Start()
    {

        Debug.Log("GameHandler.Start");

        /*  int count = 0;
          FunctionPeriodic.Create(() =>
          {
              CMDebug.TextPopupMouse("Ding! " +count);
              //Debug.Log("call");
              count++;
          }, .300f);*/


        GameObject gameObject = new GameObject("Pipe", typeof(SpriteRenderer));
        gameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.GetInstance().pipeHeadSprite;


    }


}
