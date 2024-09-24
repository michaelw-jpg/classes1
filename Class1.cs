using System;

 public class Rectangle
{
    private int _width;
	private int _height;

	//default konstruktur
	public Rectangle()
	{

	}
   
	
	//class constructor, will be called automatically when you create an instance of a class.
    public Rectangle(int height, int width)
	{
		
		//this. kopplar (private) _width med width
		//funkar också att bra skita i this. och bara ha _width=width; så när vi skapar en ny rectangle blir den inkommande height blir den privata _height

		this._width = width;
		this._height = height;
	}

	//kopplar ihop width och height att vi kommer åt dem även UTANFÖR klassen även om själva värderna är privata från början
	public int Width
	{
		get { return _width; }
		set { _width = value; }
	}

    public int Height //{ get; set; }
    {
        get { return _height; }
        set { _height = value; }
    }


	//metod sida gånger höjd metoden måste vara public
	//variablarna är ihopkopplade så du behöver inte lägga variablarna i () som i en vanlig metod utan använd variabelnamn
    public int AreaCalc()
	{
		return _height * _width;
	}

}
