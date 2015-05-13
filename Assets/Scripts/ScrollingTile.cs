using UnityEngine;
using System.Collections;

public class ScrollingTile : MonoBehaviour
{
    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Variables                                                                 //                
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////
    #region fields
    //public int offset;
    //public float speed;
    //public Transform player;

    //private Vector3 position;
    //private Vector3 startPos;

    public static ScrollingTile instance;

    public float speed;
    [HideInInspector]
    public bool stop = false;
    #endregion


    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Unity Functions                                                           //                
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////
    void Awake()
    {
        instance = this;
        //startPos = new Vector3(0, 0, 18);
    }

    #region Update
    void Update()
    {
        if (!stop)
        {
            transform.Translate(TileManager.moveVector * speed * Time.deltaTime);
        }


        ////Keeps the background pieces moving with the player
        //if (transform.localPosition.x + offset < player.transform.localPosition.x)
        //{
        //    transform.localPosition = new Vector3(transform.localPosition.x + 10 * 3, transform.localPosition.y);
        //}
    }
    #endregion

    //void FixedUpdate()
    //{
    //    if (transform.position.x > 110)
    //    {
    //        TileManager.get.ResetTile(this);
    //    }
    //    //    GameManager.get.DestroyChunk(this);
    //}

    //void OnTriggerEnter(Collider other)
    //{
    //    transform.position = startPos;
    //}

    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Custom Functions                                                          //
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////


}
