using System;

namespace app
{


    class BRICKAPP
    {
        static void inititalbrick()
        {
            var PressedBRICK1 = new BRICK(){
                Width = 10,
                Lenght = 20,
                Thickness = 5
            };
        
    
    var PressedBRICK2 = new BRICK()
    {
        Width = 11,
            Lenght = 22,
            Thickness = 5.5
        };
        BRICK MILITARYBRICK1 = new BRICK()
        {
            Width = 50,
        Lenght = 50,
        Thickness = 5
    };
    var MILITARYBRICK2 = new BRICK()
    {
        Width = 40,
    Lenght = 40,
        Thickness = 5
    };
var ROOFBRICK = new BRICK()
{
    Width = 50,
Lenght = 20,
        Thickness = 25
    };
  var BRICK3CM1 = new BRICK()
  {
      Width = 22,
Lenght = 11,
    Thickness = 3
};
var BRICK3CM2 = new BRICK()
{
    Width = 22,
Lenght = 11,
Thickness = 3.5
};
var BRICK3CM3 = new BRICK()
{
    Width = 22,
Lenght = 11,
Thickness = 4
};




}
    static void main(string[] args)
{
inititalbrick;

}

class calculations

{




}
class BRICK
{
    public float Width;
    public float Lenght;
    public double Thickness;
}

class WALL
{
    public float WALLHeight;
    public float WALLLenght;
    public float WALLThickness;
}
    
}
}