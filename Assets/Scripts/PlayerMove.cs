using UnityEngine;
using System.Collections;
using System;

public class PlayerMove : MonoBehaviour
{

    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Variables                                                                 //                
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////
    public enum SIDE { Left, Right }

    static public PlayerMove instance;

    public float speed; 

    private Vector3 newPos;
    private SIDE side;
    private bool mbMagDown = false;

    private Vector3 moveVector = new Vector3(0, 0, 1);

    public event EventHandler MagnetTriggered;

    private bool move = false;

    protected virtual void OnMagnetTriggered()
    {
        move = true;

        if (MagnetTriggered != null)
            MagnetTriggered(this, EventArgs.Empty);

    }

    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Unity Functions                                                           //                
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        transform.position = new Vector3(-2.5f, 1.5f, -95);
        newPos = transform.position;
        side = SIDE.Left;
    }

    void Update()
    {

        //transform.Translate(moveVector * speed * Time.deltaTime);


#if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (side == SIDE.Left)
            {
                newPos = new Vector3(2.5f, transform.position.y, transform.position.z);
                side = SIDE.Right;
            }
            else
            {
                newPos = new Vector3(-2.5f, transform.position.y, transform.position.z);
                side = SIDE.Left;
            }
        }
#endif

#if UNITY_ANDROID || UNITY_IPHONE
        if (!mbMagDown)
        {
            if (DInput.magnet_trigger == 1)
            {
                mbMagDown = true;
            }
        }
        else
        {
            if (DInput.magnet_trigger != 1)
            {
                OnMagnetTriggered();
                mbMagDown = false;
            }
        }

        if (move)
        {
            if (side == SIDE.Left)
            {
                newPos = new Vector3(2.5f, transform.position.y, transform.position.z);
                side = SIDE.Right;
                move = false;

            }
            else
            {
                newPos = new Vector3(-2.5f, transform.position.y, transform.position.z);
                side = SIDE.Left;
                move = false;
            }
        }

#endif

        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * 10);
    }

    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Custom Functions                                                          //
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////

}
