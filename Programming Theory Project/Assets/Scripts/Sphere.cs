using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Sphere : MonoBehaviour
{
    protected GameManager gameManager;
    private string playerName;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerName = MainManager.Instance.PlayerName;
    }

    public virtual void DisplayText()
    {
        gameManager.MessageText.text = $"{playerName} clicked the {GetName()}";
    }

    public abstract void SphereQuote();
 

    private void OnMouseDown()
    {
        DisplayText();
        SphereQuote();
    }

    public virtual string GetName()
    {
        return "Sphere Name";
    }



}