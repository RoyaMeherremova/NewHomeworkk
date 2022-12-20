


using Class_Work.Models;
using Class_Work.Service;
using Class_Work.Service.Interface;

Bird bird= new Bird();
bird.Sound();
bird.Eating();
Shark shark= new Shark();   
shark.Sound();
shark.Eating();
//Animal animal= new Animal();
//animal.Sound();

Car car= new Car();
car.Test();


GetNums(1, 2, 3, 4, 5);
static void GetNums(int num,params int[]arr)
{
	foreach (var item in arr)
	{
		Console.WriteLine(item);
    }

}


ICalculateService calculate = new CalculateService();
calculate.SumNumbers(3, 6);


IPerson person= new Person();
person.GetName();


ICalculateService service= new CalculateService();
int result = service.GetSumNumbersFromArray(new int[] { 1, 2, 3, 4, 5, });
Console.WriteLine(result);
