//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CallCommands : MonoBehaviour
//{
//    static List<Command> RepeatCommands;
//    static Queue<Command> commands;

//    private void Awake()
//    {
//        commands = new Queue<Command>();
//        RepeatCommands = new List<Command>();
//    }
//    public static void AddCommand(Command c)
//    {
//        RepeatCommands.Add(c);
//        commands.Enqueue(c);
//    }

//    private void Update()
//    {
//        if (commands.Count > 0)
//            commands.Dequeue().Execute();
//    }

//}
