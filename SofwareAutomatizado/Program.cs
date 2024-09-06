string folderPath = @"C:\Users\luiss\Desktop\Curso Backend c#";

try
{
    if (Directory.Exists(folderPath))
    {

        string[] files = Directory.GetFiles(folderPath);

        foreach (string file in files)
        {
            try
            {
                File.Delete(file);
                Console.WriteLine($"El archivo {file} ha sido eliminado");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error al eliminar el archivo {file}: {e.Message}");
            }
        }
        Console.WriteLine($"Los archivos han sido eliminados");
    }
    else
    {
        Console.WriteLine($"La carpeta no existe:  + {folderPath}");
    }
}
catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}
