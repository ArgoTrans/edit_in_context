using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "word.docx";
        string searchText = "Lorem ipsum dolor sit amet";
        string replaceText = "Hello, world";

        using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath, true))
        {
            var body = wordDoc.MainDocumentPart.Document.Body;
            foreach (var text in body.Descendants<Text>())
            {
                if (text.Text.Contains(searchText))
                {
                    text.Text = text.Text.Replace(searchText, replaceText);
                }
            }
        }
    }
}
