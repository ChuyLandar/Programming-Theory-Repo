using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSphere : Sphere // INHERITANCE
{
    public override string GetName()
    {
        return "Red Sphere";
    }

    public override void SphereQuote() // POLYMORPHISM
    {
        gameManager.QuoteText.text = "Red Sphere:  Never let your best friends get lonely, keep disturbing them.";

    }
}
