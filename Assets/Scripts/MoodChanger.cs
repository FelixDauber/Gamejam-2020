using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoodChanger : MonoBehaviour
{
    [SerializeField]
    public float DetectionRange;
    [SerializeField]
    public float PlayerDetectionRange;

    protected float jackingoff;
    //For the Jack Meme

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    
    // Update is called once per frame
   
      //  if (Vector2.Distance(PlayerController, RedBloodCellAI, WhiteBloodCellAI.transform.position) <= PlayerDetectionRange
             void Update()
          //  {
                // = GameObject.FindGameObjectWithTag("RedBloodCell").transform;

               // if (Vector2.Distance(transform.position, blocks.position) < 10)
                {
                   // RedBloodCellAI.GetComponent<Renderer>().render = Color.green;
                }
            }