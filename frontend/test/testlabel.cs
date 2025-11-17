using Godot;
using System;

public partial class testlabel : Label
{
	private Tween tween;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		tween = GetTree().CreateTween();
		tween.TweenProperty(this, "modulate:a", 0.0f, 0.5f).SetTrans(Tween.TransitionType.Sine).SetEase(Tween.EaseType.InOut);
		tween.TweenProperty(this, "modulate:a", 1.0f, 0.5f).SetTrans(Tween.TransitionType.Sine).SetEase(Tween.EaseType.InOut);
		tween.SetLoops();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
