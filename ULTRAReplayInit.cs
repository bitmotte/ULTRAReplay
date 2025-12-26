using ULTRAReplay;
using UnityEngine;

public class ULTRAReplayInit : MonoBehaviour
{
    static bool initialized;

    void Awake()
    {
        if(initialized == true)
        {
            Destroy(gameObject);
        } 
        else
        {
            
        }
    }
}