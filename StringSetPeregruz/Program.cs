StringSet set1 = new StringSet();
set1.Add("apple");
set1.Add("banana");
set1.Add("cherry");

StringSet set2 = new StringSet();
set2.Add("banana");
set2.Add("date");
set2.Add("cherry");

Console.WriteLine("Объединение множеств:");
StringSet union = set1 + set2;
union.Print();

Console.WriteLine("Пересечение множеств:");
StringSet intersection = set1 & set2;
intersection.Print();

Matrix matrix = new Matrix(3, 3);
matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[1, 1] = 3;
matrix[2, 2] = 4;

Console.WriteLine("Матрица:");
matrix.Print();

StringCollection collection = new StringCollection();
collection.Add("apple");
collection.Add("banana");
collection.Add("cherry");

Console.WriteLine("Коллекция строк:");
collection.Print();