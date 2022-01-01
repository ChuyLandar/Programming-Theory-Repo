using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSphere : Sphere // INHERITANCE
{
    public override string GetName()
    {
        return "Blue Sphere";
    }

    public override void SphereQuote() // POLYMORPHISM
    {
        gameManager.QuoteText.text = "Blue Sphere:  Friends buy you food. Best friends eat your food.";
    }
}
