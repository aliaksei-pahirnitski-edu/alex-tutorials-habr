using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;

// Еще один "артефакт". Создает Main, который нуже ндля работы тулсета
return;

public partial class FileProcessor
{
    // Экспортируем метод
    [JSExport]
    internal static async Task<int> ProcessFile(byte[] file)
    {
		await Task.Delay(100); // эмулируем работу
        return file.Length;
    }
}