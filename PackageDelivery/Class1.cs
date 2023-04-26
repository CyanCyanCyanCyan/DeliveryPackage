﻿using System;

public class Calculations
{
	private double _weight;
	private double _height;
	private double _length;
	private double _width;
	private double _volume=_height*_length*_width;
	
	public Calculations(double weight, double height, double length, double width)
	{
		_weight=weight;
		_height=height;
		_length=length;
		_width=width;
	}
	public double Weight
	{
		get=>_weight;
	}
	public double Height
	{
		get=>_height;
	}
	public double Length
	{
		get=>_length;
	}
	public double Width
	{
		get=>_width;
	}
}