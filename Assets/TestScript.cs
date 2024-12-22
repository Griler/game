using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    [SerializeField] private Button clientBtn;

    [SerializeField] private Button serverBtn;

    // Start is called before the first frame update
    void Start()
    {
        serverBtn.onClick.AddListener(() => { NetworkManager.Singleton.StartServer(); });

        clientBtn.onClick.AddListener(() => { NetworkManager.Singleton.StartClient(); });
    }

    // Update is called once per frame
    void Update()
    {
    }
}