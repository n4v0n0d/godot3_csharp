using Godot;
using System;

public class Player : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    [Export] public int something = 3;

    private PlayerMovement playerMovement;

    public override void _Ready() {
        // Not actually fetching this for anything.
        playerMovement = (PlayerMovement)GetNode("PlayerMovement");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}