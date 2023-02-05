using Godot;
using System;

public class PlayerMovement : KinematicBody2D
{
    [Export] public int speed = 200;

    // TODO: implement acceleration
    [Export] public int acceleration = 1;

    public Vector2 velocity = new Vector2();

    public void UpdateVelocity() {
        var leftPressed = Input.IsActionPressed(World.INPUT_LEFT);
        var rightPressed = Input.IsActionPressed(World.INPUT_RIGHT);
        var upPressed = Input.IsActionPressed(World.INPUT_UP);
        var downPressed = Input.IsActionPressed(World.INPUT_DOWN);

        velocity = new Vector2();

        if (leftPressed ^ rightPressed) {
            if (leftPressed) {
                velocity.x -= acceleration;
            } else if (rightPressed) {
                velocity.x += acceleration;
            }
        }
        if (upPressed ^ downPressed) {
            if (upPressed) {
                velocity.y -= acceleration;
            } else if (downPressed) {
                velocity.y += acceleration;
            }
        }

        velocity = velocity.Normalized() * speed;
    }

    public override void _PhysicsProcess(float delta)
    {
        UpdateVelocity();
        velocity = MoveAndSlide(velocity, upDirection: Vector2.Up);
    }



    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
