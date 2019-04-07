using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoToKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            serialPort.PortName = "COM" + numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false){ //if not open, open the port
                serialPort.Open();
            }
        }

        private string tString = string.Empty;

        private static bool isBlank(String s)
        {
            return s.ToLower().Equals("");
        }

        private void portRead(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Initialize a buffer to hold the received data 
            byte[] buffer = new byte[serialPort.ReadBufferSize];

            //There is no accurate method for checking how many bytes are read 
            //unless you check the return from the Read method 
            int bytesRead = serialPort.Read(buffer, 0, buffer.Length);

            //For the example assume the data we are received is ASCII data. 
            tString += Encoding.ASCII.GetString(buffer, 0, bytesRead);
            //Check if string contains the terminator  
            //if (tString.IndexOf((char)_terminator) > -1)
          //  {
                //If tString does contain terminator we cannot assume that it is the last character received 
               // string workingString = tString.Substring(0, tString.IndexOf((char)_terminator));
                //Remove the data up to the terminator from tString 
                //tString = tString.Substring(tString.IndexOf((char)_terminator));
                //Do something with workingString 
                int read;
                List<string> msg = tString.ToString().Split("\r\n".ToCharArray()).ToList();
                msg.RemoveAll(isBlank);
                    bool succeed = Int32.TryParse(msg[0]===, out read);
                    if (succeed)
                    {
                        switch (read)
                        {
                            case 0:
                                SendKeys.SendWait(textBox1.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 1:
                                SendKeys.SendWait(textBox2.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 2:
                                SendKeys.SendWait(textBox3.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 3:
                                SendKeys.SendWait(textBox4.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 4:
                                SendKeys.SendWait(textBox5.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 5:
                                SendKeys.SendWait(textBox6.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 6:
                                SendKeys.SendWait(textBox7.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 7:
                                SendKeys.SendWait(textBox8.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 8:
                                SendKeys.SendWait(textBox9.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 9:
                                SendKeys.SendWait(textBox10.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 10:
                                SendKeys.SendWait(textBox11.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 11:
                                SendKeys.SendWait(textBox12.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 12:
                                SendKeys.SendWait(textBox13.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 13:
                                SendKeys.SendWait(textBox14.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 14:
                                SendKeys.SendWait(textBox15.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            case 15:
                                SendKeys.SendWait(textBox16.Text);
                                Console.WriteLine("Sending \"" + textBox1.Text + "\" To the current application");
                                break;
                            default:
                                Console.WriteLine("No match");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error, Data not read");
                    }
                
                
          //  } 
        }

        private void Exit(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }
    }
}
