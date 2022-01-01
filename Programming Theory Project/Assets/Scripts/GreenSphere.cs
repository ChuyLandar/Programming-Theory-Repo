using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenSphere : Sphere // INHERITANCE
{
    public override string GetName()
    {
        return "Green Sphere";
    }

    public override void SphereQuote() // POLYMORPHISM
    {
        gameManager.QuoteText.text = "Green Sphere:  My wallet is like an onion, opening it makes me cry.";

    }
}
