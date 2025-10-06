using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] private Transform gameTransform;
    [SerializeField] private Transform piecePrefab;

    private int emptyLocation;
    private int size;

    // create the game setup with size x size pieces.
    private void CreateGamePieces(float gapThickness) {
        // this is the width of each tile.
        float width = 1 / (float)size;
        for (int row = 0; row < size; row++) {
            for (int col = 0; col < size; col++) {
                Transform piece = Instantiate(piecePrefab, gameTransform);
            }
        }
    }

































     
    // Start is called before the first frame update
    void Start()
    {
        size = 3;
        CreateGamePieces(0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }












}