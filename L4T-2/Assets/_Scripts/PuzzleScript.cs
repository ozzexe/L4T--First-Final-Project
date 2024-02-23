using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityTutorial.Manager;
using UnityTutorial.PlayerControl;

public class PuzzleScript : MonoBehaviour, IInteractable
{
   
    public void Interact()
    {
        GetPuzzle();
    }
    public void GetPuzzle()
    {
        {
            // Burada yap�lacak i�lemler
            if (IsPuzzleCompleted()) // Puzzle tamamland� m� kontrol�
            {
                CompletePuzzle(); // Puzzle tamamland�ysa yap�lacak i�lemler
            }
        }
    }

    private bool IsPuzzleCompleted()
    {
        // Puzzle par�alar�n�n do�ru konumda olup olmad���n� kontrol et
        PuzzlePiece[] puzzlePieces = FindObjectsOfType<PuzzlePiece>();
        foreach (PuzzlePiece puzzlePiece in puzzlePieces)
        {
            if (!puzzlePiece.IsCorrectlyPlaced())
            {
                return false; // E�er bir par�a do�ru konumda de�ilse, puzzle tamamlanmam��t�r
            }
        }
        return true; // E�er t�m par�alar do�ru konumdaysa, puzzle tamamlanm��t�r
    }
    private void CompletePuzzle()
    {
        // Puzzle tamamland�ysa yap�lacak i�lemler
        Debug.Log("Puzzle tamamland�!");
    }
}
