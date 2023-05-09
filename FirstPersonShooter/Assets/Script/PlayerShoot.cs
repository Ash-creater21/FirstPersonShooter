using UnityEngine;
using Unity.Netcode ; 

public class PlayerShoot : NetworkBehaviour
{
    public PlayerWepon wepon ;
    [SerializeField] private LayerMask mask ; 
    [SerializeField] private Camera cam ; 
  void Start() 
  {
    if(cam==null)
    {
        Debug.LogError("no camera Reference ;( "); 
        this.enabled = false ; 

    }
  }
   void Update() 
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot() 
    {
        RaycastHit hit ; 
        if(Physics.Raycast(cam.transform.position,cam.transform.forward,out hit,wepon.range,mask))
        {
            Debug.Log("We Hit :) "+hit.collider.name);
        }
    }
}
