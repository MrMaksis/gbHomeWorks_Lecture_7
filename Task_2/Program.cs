void Show2dArray(int[,] arr){

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i,j] + "\t");
        Console.WriteLine();
    } 
    Console.WriteLine();
}

int[,] CreateRandom2dArray(){

	Console.Write("Input a number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());

	Console.Write("Input a number of columns: ");
	int columns = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

	int[,] arr = new int[rows,columns];
        Random r = new Random();

	for(int i = 0; i < rows; i++){
		for(int j = 0; j < columns; j++){
			arr[i,j] = r.Next(51,99) - r.Next(0,50);
		}
	}
    return arr;
}

string FindIndexArray(int[,] arr){
    Console.Write("Input a index 1: ");
    int index_1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a index 2: ");
    int index_2 = Convert.ToInt32(Console.ReadLine());

    if(index_1 < arr.GetLength(0) && index_2 < arr.GetLength(1)){
        return $"По введенным индексам найдено значение: {arr[index_1,index_2]}";
    }
    else return "Индекс не найден!";
}

int[,] arr = CreateRandom2dArray();
Show2dArray(arr);
Console.WriteLine(FindIndexArray(arr));



