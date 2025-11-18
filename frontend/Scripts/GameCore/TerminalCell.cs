using Godot;
using System;

public class TerminalCell : ICell
{
    public CellState State { get; private set; } = CellState.Empty;
    public bool IsPlayable => State == CellState.Empty;
    
    public void SetState(CellState newState)
    {
        State = newState;
    }
}