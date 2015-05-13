using UnityEngine;
using System.Collections;

public class Obstacle  : MonoBehaviour
{

    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Variables                                                                 //                
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////


    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Unity Functions                                                           //                
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////
    void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        ScrollingTile.instance.stop = true;
        StartCoroutine(ResetLevel());
    }

    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Custom Functions                                                          //
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////


    IEnumerator ResetLevel()
    {

        yield return new WaitForSeconds(5);

        Application.LoadLevel(0);
    }

}
