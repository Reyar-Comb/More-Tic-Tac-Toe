using Godot;
using System;

public class BoardCell : ICell
{
    public Board Board;
    
    public CellState State => Board.State;
    public bool IsPlayable => Board.IsPlayable;
}