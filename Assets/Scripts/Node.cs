using System.Diagnostics;
using JetBrains.Annotations;
using UnityEngine;

[DebuggerDisplay("pos: {Position}, parent: {Parent}, score: {Score}")]
public sealed class Node
{

    public readonly Vector2 Position;

    public readonly Node Parent;

    public readonly float DistanceFromStart;

    public readonly float DistanceHeuristicToTarget;

    public readonly float Score;

    public Node(Vector2 position, [CanBeNull] Node parent, float gScore, float hScore)
    {
        Position = position;
        Parent = parent;
        DistanceFromStart = gScore;
        DistanceHeuristicToTarget = hScore;
        Score = gScore + hScore;
    }
}
