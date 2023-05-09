
using UnityEngine;
using UnityEngine.UI ; 
using Unity.Netcode ; 
public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Button StartServerButton ; 
    [SerializeField]
    private Button StartHostButton ; 
    [SerializeField]
    private Button StartClientButton ; 
    // [SerializeField]
    // private Text PlayersInGameText ; 

    private void Awake() 
    {
        // Ensures all sessons have cursor 
        Cursor.visible = true ; 
    }
    private void Update() 
    {
        // PlayersInGameText.text = "No of Players : " + PlayerManager.Instance.PlayersInGame ; 
    }

    private void Start()
    {
        StartClientButton.onClick.AddListener(()=>{
        NetworkManager.Singleton.StartClient();
            
        });
        StartHostButton.onClick.AddListener(()=>{
        NetworkManager.Singleton.StartHost();
            
        });
        StartServerButton.onClick.AddListener(()=>{
        NetworkManager.Singleton.StartClient(); 
            
        });
       
    }

}
