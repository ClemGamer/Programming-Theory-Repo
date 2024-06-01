using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : Shape
{
    protected override void DisplayText()
    {
        Text.text = "I'm Triangle...";
    }
}
