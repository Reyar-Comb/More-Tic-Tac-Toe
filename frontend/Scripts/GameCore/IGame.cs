using Godot;
using System;
using System.Collections.Generic;

public interface IGame
{
    int Dimension { get; }
    CellState CurrentPlayer { get; }
    CellState Winner { get; }
    bool IsFinished { get; }

    bool MakeMove(Move move);
    #nullable enable
    IList<int>? GetAllowedBoards();

    GameStateDto ToDto();
    void LoadFromDto(GameStateDto dto);
}