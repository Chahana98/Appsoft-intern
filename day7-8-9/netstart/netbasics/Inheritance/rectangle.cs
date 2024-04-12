// program to find area and perimeter of different 2D shapes.
class Rectangle{
    public Rectangle(float l, float b){
        length=l;
        breadth=b;
    }
    float Area,Perimeter,length,breadth;
    public GetArea()=> length*breadth;
    // or public GetArea(){
    //     return length*breadth;
    // }
    public GetPerimeter()=> 2(length+breadth);
}