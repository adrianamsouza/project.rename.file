// See https://aka.ms/new-console-template for more information

string fileActual = @"C:\Users\usuario\pastaDoArquivo\";

string newDestine = @"C:\Users\usuario\pastaDestinoArquivo\";

string[] files = Directory.GetFiles(fileActual);

foreach (var file in files)
{
	try
	{
		var extension = Path.GetExtension(file);

		DateTime timestamp = DateTime.Now;
		string newPath;
		string rename;

		do
		{
			rename = $"{timestamp.ToString("yyyyMMdd_HHmm")}_wallet{extension}";

			newPath = Path.Combine(newDestine, rename);

			timestamp = timestamp.AddMinutes(1);
		}
		while (File.Exists(newPath));

		File.Move(file, newPath);
	}
	catch (Exception ex)
	{

		throw new Exception($"Erro ao renomear o arquivo: {ex.Message}");
	}
	
}
