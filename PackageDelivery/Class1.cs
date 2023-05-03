using System;

public class Calculations
{
	private double _weight;
	private double _height;
	private double _length;
	private double _width;
	private double _volume=_height*_length*_width;
	
	public Calculations(double weight, double height, double length, double width, double _volume)
	{
		_weight=weight;
		_height=height;
		_length=length;
		_width=width;
		_volume=volume;
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
	public string Description
	{
		get=>$"The weight is {Weight}kg. The height is {Height}cm. The length is {Length}cm. The width is {Width}cm.";
	}
}