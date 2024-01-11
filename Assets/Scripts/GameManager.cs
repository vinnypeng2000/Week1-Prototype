using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gamemanager : MonoBehaviour
{

    public GameObject inventory;
    public Button inventoryButton;
    public TextMeshProUGUI text;
    public GameObject scroll;
    // public GameObject[] items;
    public Image scrollText;

    // public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        inventoryButton.onClick.AddListener(OpenInventory);
        // audio = GetComponent<AudioSource>();
        // GetComponent<AudioSource>().Play();
    }

    void OpenInventory()
    {
        Debug.Log("OK");
        inventory.SetActive(!inventory.active);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            OpenInventory();
        }
        if (text.gameObject.active == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Destroy(scroll);
                text.gameObject.SetActive(false);
                scrollText.gameObject.SetActive(true);
            }
        }
    }
}
