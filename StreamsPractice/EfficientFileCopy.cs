using System;
namespace StreamsPractice
{
	public class EfficientFileCopy
	{
        static void CopyUsingFileStream(string source, string destination)
        {
            byte[] buffer = new byte[4096];

            using (FileStream input = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream output = new FileStream(destination, FileMode.Create, FileAccess.Write))
            {
                int bytesRead;

                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    output.Write(buffer, 0, bytesRead);
                }
            }
        }

        static void CopyUsingBufferedStream(string source, string destination)
        {
            byte[] buffer = new byte[4096];

            using (FileStream inputFile = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream outputFile = new FileStream(destination, FileMode.Create, FileAccess.Write))
            using (BufferedStream input = new BufferedStream(inputFile))
            using (BufferedStream output = new BufferedStream(outputFile))
            {
                int bytesRead;

                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    output.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}

