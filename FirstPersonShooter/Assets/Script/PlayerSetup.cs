using UnityEngine;
using UnityEngine.Networking;  
using Unity.Netcode;


public class PlayerSetup : NetworkBehaviour
{
    // list of components that are to be disabled in a [player 1}machine 
   [SerializeField]
   Behaviour[] ComponentsToDisable;   
    public AudioListener Audio ; 
   
    private void Start() 
    {
        
       
        // if(!IsLocalPlayer)
        // {
            

        //     Audio.enabled = false ; 
        //     Debug.Log("You are Client ");
        //     for(int i = 0 ; i<ComponentsToDisable.Length ; i++)
        //     {
        //         ComponentsToDisable[i].enabled = false ; 
        //     }

        // }
        
    }
}
