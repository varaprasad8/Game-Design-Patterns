using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform playerTrans;
    public static List<Command> commands;

    private Command buttonW, buttonS, buttonA, buttonD, buttonZ, buttonR;


    // Start is called before the first frame update
    void Start()
    {
        commands = new List<Command>();

        buttonW = new MoveForward();
        buttonA = new MoveLeft();
        buttonS = new MoveBack();
        buttonD = new MoveRight();
        buttonZ = new Undo();
        //buttonR = new Redo();

    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
            buttonW.Execute(playerTrans, buttonW);
        else if (Input.GetKeyDown(KeyCode.A))
            buttonA.Execute(playerTrans, buttonA);
        else if (Input.GetKeyDown(KeyCode.S))
            buttonS.Execute(playerTrans, buttonS);
        else if (Input.GetKeyDown(KeyCode.D))
            buttonD.Execute(playerTrans, buttonD);
        else if (Input.GetKeyDown(KeyCode.Z))
            buttonZ.Execute(playerTrans, buttonZ);
        else if (Input.GetKeyDown(KeyCode.R))
            buttonR.Execute(playerTrans, buttonR);
    }


}
