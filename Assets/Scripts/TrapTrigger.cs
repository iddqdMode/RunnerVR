using UnityEngine;
using System.Collections;

public class TrapTrigger  : MonoBehaviour
{

    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Variables                                                                 //                
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////

    // Slot for the trap object to be placed.
    [SerializeField]
    private GameObject trap;
    // Select whether the trap will be affected from the left or the right.
    [SerializeField]
    private bool left;
    [SerializeField]
    private bool fence;


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
        // Play animation to move trap.
    }

    void OnTriggerEnter(Collider other)
    { 
        if(!fence)
        {
            Grow();
        }
    }

    //////////////////////////////////////////////////////////////////////////////
    //                                                                          // 
    //Custom Functions                                                          //
    //                                                                          //               
    //////////////////////////////////////////////////////////////////////////////

    void Grow()
    {
        trap.SetActive(true);


    }


    void Drop()
    { 
        
    }

}
