using Godot;
using System;

public class Game
{
    public Board RootBoard;
    public int Depth;

    public CellState CurrentPlayer = CellState.X;

    public Board CurrentBoard;
}