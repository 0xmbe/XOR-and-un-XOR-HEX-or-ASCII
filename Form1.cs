using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace XOR_test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateComboBox();
            Text = "XOR and un-XOR HEX or ASCII";
        }

        private void buttonUnXor_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = Process_XOR(
               richTextBox1.Text,
               comboBox_Xored_TextType.SelectedItem.ToString(),
               comboBox_UnXored_TextType.SelectedItem.ToString(),
               textBox1.Text);
            richTextBox2.SelectAll();
            richTextBox2.Focus();
        }
        private void buttonXor_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Process_XOR(
                richTextBox2.Text,
                comboBox_UnXored_TextType.SelectedItem.ToString(),
                comboBox_Xored_TextType.SelectedItem.ToString(),
                textBox1.Text);
            richTextBox1.SelectAll();
            richTextBox1.Focus();
        }
        private string Process_XOR(string inputText, string inputTextType, string outputTextType, string xorValue)
        {
            try
            {
                string[] inputHexStringArray = null;
                byte[] inputBytesArray = null;

                // Convert the XOR value from string to byte
                byte xorByte = Convert.ToByte(xorValue, 16);

                if (inputTextType == "ASCII")
                {
                    inputHexStringArray = Ascii2HexArray(inputText);
                }
                if (inputTextType == "HEX")
                {
                    inputHexStringArray = Hex2HexArray(inputText);
                }

                inputBytesArray = HexStringArray2ByteArray(inputHexStringArray);

                XOR_ByteArray(xorByte, inputBytesArray);

                // OUTPUT:
                if (outputTextType == "ASCII")
                {
                    return BytesArray2Ascii(inputBytesArray);
                }
                if (outputTextType == "HEX")
                {
                    return BytesArray2Hex(inputBytesArray);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return null;
        }
        private static string BytesArray2Hex(byte[] inputBytesArray)
        {
            // Convert processed inputBytesArray back to hex string
            string js = string.Join("", inputBytesArray.Select(b => b.ToString("X2")));

            // Split into pairs of characters
            string[] outjs = Enumerable.Range(0, js.Length / 2)
                                       .Select(i => js.Substring(i * 2, 2))
                                       .ToArray();

            // Join the array back into a single string with spaces
            js = string.Join(" ", outjs);

            StringBuilder sb = SplitHexEvery16Bytes(outjs);

            return sb.ToString().Trim();
        }

        private static StringBuilder SplitHexEvery16Bytes(string[] outjs)
        {
            // Insert newline characters after every 16 bytes
            var sb = new StringBuilder();
            for (int i = 0; i < outjs.Length; i++)
            {
                if (i > 0 && i % 16 == 0)
                {
                    sb.AppendLine();
                }
                sb.Append(outjs[i] + " ");
            }

            return sb;
        }
        private static string BytesArray2Ascii(byte[] inputBytesArray)
        {
            for (int i = 0; i < inputBytesArray.Length; i++)
            {
                if (inputBytesArray[i] == 0)
                {
                    inputBytesArray[i] = 32; // ASCII value for space, so it is not empty
                }
            }
            return Encoding.ASCII.GetString(inputBytesArray);
        }

        private static byte[] HexStringArray2ByteArray(string[] inputHexStringArray)
        {
            // Convert hex string array to byte array
            byte[] inputBytesArray = new byte[inputHexStringArray.Length];
            for (int i = 0; i < inputHexStringArray.Length; i++)
            {
                inputBytesArray[i] = Convert.ToByte(inputHexStringArray[i], 16);
            }
            return inputBytesArray;
        }

        private static string[] Ascii2HexArray(string inputString)
        {
            string[] inputHexStringArray;
            // Convert ASCII inputText to hex
            byte[] asciiBytes = Encoding.ASCII.GetBytes(inputString);
            inputHexStringArray = asciiBytes.Select(b => b.ToString("X2")).ToArray();
            return inputHexStringArray;
        }

        private static string[] Hex2HexArray(string inputString)
        {
            // Split the inputText string into individual hex values
            string[] inputHexStringArray = inputString.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Join the array back into a single string without spaces
            string joinedString = string.Join("", inputHexStringArray);

            // Split into pairs of characters
            inputHexStringArray = Enumerable.Range(0, joinedString.Length / 2)
                                       .Select(i => joinedString.Substring(i * 2, 2))
                                       .ToArray();
            return inputHexStringArray;
        }

        private static void XOR_ByteArray(byte xorByte, byte[] inputBytesArray)
        {
            // Process each byte: XORING
            for (int i = 0; i < inputBytesArray.Length; i++)
            {
                inputBytesArray[i] = (byte)(xorByte ^ inputBytesArray[i]);
            }
        }
        private string StringToHex(string inputText)
        {
            StringBuilder hex = new StringBuilder(inputText.Length * 2);
            foreach (char c in inputText)
            {
                hex.AppendFormat("{0:X2} ", (int)c);
            }
            return hex.ToString().Trim();
        }
        private void PopulateComboBox()
        {
            comboBox_Xored_TextType.Items.Add(Variables.hex);
            comboBox_Xored_TextType.Items.Add(Variables.ascii);
            comboBox_Xored_TextType.SelectedIndex = 0;

            comboBox_UnXored_TextType.Items.Add(Variables.hex);
            comboBox_UnXored_TextType.Items.Add(Variables.ascii);
            comboBox_UnXored_TextType.SelectedIndex = 1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox_Xored_TextType.SelectedItem.ToString();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox_Xored_TextType.SelectedItem.ToString();
        }
    }
    static class Variables
    {
        public static string hex = "HEX";
        public static string ascii = "ASCII";
    }
}
