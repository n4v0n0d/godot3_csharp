using Godot;
using System;

public class World : Node2D
{
    // Note: Must match values in the project.godot file.
    public const String INPUT_LEFT = "left";
    public const String INPUT_RIGHT = "right";
    public const String INPUT_UP = "up";
    public const String INPUT_DOWN = "down";

    // on Ready
    private Player player;

    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready() {
        GD.Print("The World was created!");
        player = GetNode<Player>("Player");
        // player.Translate(Vector2.Down * 100);


        // playerPackedScene = GD.Load<PackedScene>(Player.res);
        // player = playerPackedScene.Instance<Player>();
        // AddChild(player);
        // GD.Print("Created the Player");
        // player.Transform = player.Transform.Translated(Vector2.Down * 10);
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
