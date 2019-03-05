using System.Windows.Forms;

namespace Backend
{
    public class Program
    {
        public static void Main(string[] Args)
        {
            new Tournament().Start();
            MessageBox.Show($"Tournament has been draw. You can find the file in: {Utilities.OutputFilePath}",
                "Finished!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
