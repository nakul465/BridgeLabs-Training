using System;
namespace StreamsPractice
{
	public class ReadWriteTxtFile
	{
        static void CopyFile(string sourceFile, string destinationFile)
        {
            try
            {
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }

                using (FileStream sourceStream = new FileStream(
                    sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream destinationStream = new FileStream(
                    destinationFile, FileMode.Create, FileAccess.Write))
                {
                    int data;

                    while ((data = sourceStream.ReadByte()) != -1)
                    {
                        destinationStream.WriteByte((byte)data);
                    }
                }

                Console.WriteLine("File copied successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File operation failed: {ex.Message}");
            }
        }
    }
}

