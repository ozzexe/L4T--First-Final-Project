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
            // Burada yapýlacak iþlemler
            if (IsPuzzleCompleted()) // Puzzle tamamlandý mý kontrolü
            {
                CompletePuzzle(); // Puzzle tamamlandýysa yapýlacak iþlemler
            }
        }
    }

    private bool IsPuzzleCompleted()
    {
        // Puzzle parçalarýnýn doðru konumda olup olmadýðýný kontrol et
        PuzzlePiece[] puzzlePieces = FindObjectsOfType<PuzzlePiece>();
        foreach (PuzzlePiece puzzlePiece in puzzlePieces)
        {
            if (!puzzlePiece.IsCorrectlyPlaced())
            {
                return false; // Eðer bir parça doðru konumda deðilse, puzzle tamamlanmamýþtýr
            }
        }
        return true; // Eðer tüm parçalar doðru konumdaysa, puzzle tamamlanmýþtýr
    }
    private void CompletePuzzle()
    {
        // Puzzle tamamlandýysa yapýlacak iþlemler
        Debug.Log("Puzzle tamamlandý!");
    }
}
