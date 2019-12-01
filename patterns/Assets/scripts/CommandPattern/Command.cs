using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public abstract void Execute(Transform go, Command com);
    public virtual void Undo(Transform go) { }

}

public class MoveForward : Command
{
    public override void Execute(Transform go, Command com)
    {
        PlayerMovement.commands.Add(com);
        go.transform.position += Vector3.forward;
    }

    public override void Undo(Transform go)
    {
        go.transform.position += Vector3.back;
    }
}

public class MoveBack : Command
{
    public override void Execute(Transform go, Command com)
    {
        PlayerMovement.commands.Add(com);
        if (Input.GetKeyDown(KeyCode.S))
        {
            go.transform.position += Vector3.back;
        }
    }
    public override void Undo(Transform go)
    {
        go.transform.position += Vector3.forward;
    }
}

public class MoveLeft : Command
{
    public override void Execute(Transform go, Command com)
    {
        PlayerMovement.commands.Add(com);
        if (Input.GetKeyDown(KeyCode.A))
        {
            go.transform.position += Vector3.left;
        }
    }
    public override void Undo(Transform go)
    {
        go.transform.position += Vector3.right;
    }

}

public class MoveRight : Command
{
    public override void Execute(Transform go, Command com)
    {
        PlayerMovement.commands.Add(com);
        if (Input.GetKeyDown(KeyCode.D))
        {
            go.transform.position += Vector3.right;
        }
    }
    public override void Undo(Transform go)
    {
        go.transform.position += Vector3.left;
    }
}

public class Undo : Command
{
    List<Command> temp = PlayerMovement.commands;

    public override void Execute(Transform go, Command com)
    {
        if(temp.Count > 0)
        {
            Command latestCommand = temp[temp.Count - 1];
            latestCommand.Undo(go);
           // redo.Add(latestCommand);
            temp.RemoveAt(temp.Count - 1);
        }
    }
}

//public class Redo:Command
//{
//    List<Command> = Undo.
//    public override void Execute(Transform go, Command com)
//    {
//        Undo
//    }
//}