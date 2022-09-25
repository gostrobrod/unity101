using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public override GameObject createShape() {
        return GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
