using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece : MonoBehaviour, IInteractable
{
    public bool isSelected = false;
    public void Interact()
    {
        isSelected = true;
    }

    internal bool IsCorrectlyPlaced()
    {
        throw new NotImplementedException();
    }
}
