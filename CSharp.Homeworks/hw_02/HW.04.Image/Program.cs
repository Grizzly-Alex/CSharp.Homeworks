//1. Загрузить данные файла.
//2. Прочитать весь файл.
//3. Очистить временную пямять от загруженных данных.
//4. Разбить строки на массив строк.
//5. Определить размер массива байт.
//6. Конвертировать каждый элемент массива строк в массив байт.
//7. Сохранить полученный массив байт в png формате.


StreamReader textReader = new StreamReader(@"C:\Users\alexandr.medved\Desktop\IT_Academy\image.txt", true); 
string textReaderResult = textReader.ReadToEnd();
textReader.Dispose();

string[] arrayOfTextResult = textReaderResult.Split(' '); 
byte[] imageBytes = new byte[arrayOfTextResult.Length - 1]; 

for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
{
    byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
    imageBytes[i] = binary;
}

File.WriteAllBytes(@"C:\Users\alexandr.medved\Desktop\IT_Academy\image.png", imageBytes);









