using Godot;
using System;

public class Tile : TextureButton
{
    [Signal]
    delegate void TilePressed();

    [Signal]
    delegate void SlideCompleted();

    public override void _Ready()
    {
        GD.Print("Hello from C#");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
