﻿using UnityEngine;
using System.Collections;

public class Grass : BlockSolid
{

    public static int health = 100;
    public static int toughness = 50;
    public static bool canBeWalkedOn = true;

    public Grass() : base() { }

    public override void BuildFace(Chunk chunk, BlockPos pos, MeshData meshData, Direction direction)
    {
        BlockBuilder.BuildRenderer(chunk, pos, meshData, direction, this);
        BlockBuilder.BuildTexture(chunk, pos, meshData, direction, this, new Tile[] { Textures.Grass, Textures.Dirt, Textures.GrassSide, Textures.GrassSide, Textures.GrassSide, Textures.GrassSide });
        BlockBuilder.BuildColors(chunk, pos, meshData, direction, this);
        BlockBuilder.BuildCollider(chunk, pos, meshData, direction, this);
    }
}
