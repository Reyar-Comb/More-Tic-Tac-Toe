using Godot;
using System;

public interface ICell
{
    public bool IsPlayable { get; }
    CellState State { get; }
}
