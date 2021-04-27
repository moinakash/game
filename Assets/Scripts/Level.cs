using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    private const float PIPE_WIDTH = 7.8f;
    private const float PIPE_HEAD_WIDTH = 3.75f;

    public GameObject Pipe;

    private void Start()
    {
        //CreatePipe(50f, 0f);
        //CreatePipe(50f, 20f);

        //InvokeRepeating()
        //Invoke("PipeCreate", 1f);
        InvokeRepeating("PipeCreate", 1f, 2f);
    }

    private void PipeCreate() 
    {
        GameObject pipe = Instantiate(Pipe, transform.position, transform.rotation);

        float rand = Random.Range(-10f, 10f);

        pipe.transform.position = new Vector3(pipe.transform.position.x, pipe.transform.position.y + rand, pipe.transform.position.z);
    }



    private void CreatePipe(float height, float xPosition)
    {

        Transform pipeHead = Instantiate(GameAssets.GetInstance().pfPipeHead);
        pipeHead.position = new Vector3(xPosition, height - PIPE_HEAD_WIDTH * .5f);

        Transform pipeBody = Instantiate(GameAssets.GetInstance().pfPipeBody);
        pipeBody.position = new Vector3(xPosition, 0f);

        SpriteRenderer pipBodySpriteRender = pipeBody.GetComponent<SpriteRenderer>();
        
        pipBodySpriteRender.size = new Vector2(PIPE_WIDTH, height);
        pipeBody.position = Vector3.zero;
        //pipeBody.localScale = new Vector3(1, 1f, 1f);

        BoxCollider2D pipebodyBoxCollider = pipeBody.GetComponent<BoxCollider2D>();
        pipebodyBoxCollider.size = new Vector2(PIPE_WIDTH,height);
    }
  

}
