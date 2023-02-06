using Godot;
using System;

public class Player : Node2D
{
    public const String res = "res://src/scenes/player/Player.tscn";
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    [Export] public int something = 3;

    // on Ready
    private PlayerMovement playerMovement;
    private Camera2D camera;

    public override void _Ready() {
        // Not actually fetching this for anything.
        playerMovement = GetNode<PlayerMovement>("PlayerMovement");
        camera = GetNode<Camera2D>("PlayerMovement/Camera2D");
        camera.Zoom = new Vector2((float)0.5, (float)0.5);

        GD.Print("The Player was created!");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
