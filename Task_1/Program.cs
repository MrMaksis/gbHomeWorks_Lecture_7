void Show2dArray(double[,] arr){

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
            Console.Write(Math.Round(arr[i,j], 3) + "\t");
        Console.WriteLine();
    } 
    Console.WriteLine();
}

double[,] CreateRandom2dArray(){

	Console.Write("Input a number of rows: ");
	int rows = Convert.ToInt32(Console.ReadLine());

	Console.Write("Input a number of columns: ");
	int columns = Convert.ToInt32(Console.ReadLine());

	Console.Write("Input min: ");
	int minValue = Convert.ToInt32(Console.ReadLine());

	Console.Write("Input max: ");
	int maxValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

	double[,] arr = new double[rows,columns];
        Random r = new Random();

	for(int i = 0; i < rows; i++){
		for(int j = 0; j < columns; j++){
			arr[i,j] = r.NextDouble() * (maxValue - minValue);
		}
	}
	return arr;
}

Show2dArray(CreateRandom2dArray());
