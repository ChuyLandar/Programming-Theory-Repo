using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] TMP_InputField playerNameInput;
    [SerializeField] TextMeshProUGUI errorMessage;
    private string m_playerName = "";
    public string PlayerName // ENCAPSULATION
    {
        get { return m_playerName; }        
        set
        {
            if(value.Length <= 0)
            {
                errorMessage.gameObject.SetActive(true);
            }
            else
            {
                errorMessage.gameObject.SetActive(false);
                m_playerName = value;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return)) 
        {                
            if (GetPlayerName()) // ABSTRACTION
            {
                SceneManager.LoadScene(1);
            }
        }

    }

    private bool GetPlayerName()
    {
        PlayerName = playerNameInput.text;
        MainManager.Instance.PlayerName = PlayerName;
        if(PlayerName.Length > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
