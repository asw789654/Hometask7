using Task1;
//проверки
Sphere sphere = new Sphere(2, 2, 2, 2);
sphere.SetCenter(3, 3, 3);
Console.WriteLine(sphere.Radius);
Console.WriteLine(sphere.GetCenter());
Console.WriteLine(sphere.GetSquare());
Console.WriteLine(sphere.GetVolume());
sphere.Radius = 4;
Console.WriteLine(sphere.Radius);
Console.WriteLine(sphere.IsPointInside(2, 9, 2));

