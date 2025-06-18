using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace lpr29
{
    public partial class Form1 : Form
    {
        bool alive = false;
        UdpClient client;
        const int TTL = 20;

        IPAddress groupAddress = IPAddress.Parse("235.5.5.1");
        int localPort = 8001;
        int remotePort = 8001;
        Font chatFont = new Font("Segoe UI", 10);
        string userName;
        private StringBuilder chatLog = new StringBuilder();
        Color chatTextColor = Color.Black;



        public Form1()
        {
            InitializeComponent();
            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
            chatTextBox.ReadOnly = true;
            chatTextBox.Font = chatFont;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = userNameTextBox.Text;
            userNameTextBox.ReadOnly = true;

            try
            {
                client = new UdpClient(localPort);
                client.JoinMulticastGroup(groupAddress, TTL);

                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();

                string message = userName + " зайшов(ла) в чат";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, groupAddress.ToString(), remotePort);

                loginButton.Enabled = false;
                logoutButton.Enabled = true;
                sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);

                    this.Invoke(new MethodInvoker(() =>
                    {
                        string time = DateTime.Now.ToShortTimeString();
                        chatTextBox.Font = chatFont;
                        chatTextBox.Text = time + " " + message + "\r\n" + chatTextBox.Text;
                        chatLog.AppendLine($"{DateTime.Now:HH:mm} {message}");

                    }));
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive) return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = $"{userName}: {messageTextBox.Text}";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, groupAddress.ToString(), remotePort);
                messageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            ExitChat();
        }

        private void ExitChat()
        {
            string message = userName + " покинув(ла) чат";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, groupAddress.ToString(), remotePort);
            client.DropMulticastGroup(groupAddress);
            alive = false;
            client.Close();

            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (alive)
            {
                MessageBox.Show("Спочатку вийдіть із чату, щоб змінити налаштування IP/порту.",
                                "Зміна заборонена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var settingsForm = new settings(groupAddress.ToString(), localPort, chatFont, chatTextColor);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                groupAddress = IPAddress.Parse(settingsForm.Host);
                localPort = settingsForm.Port;
                remotePort = settingsForm.Port;
                chatFont = settingsForm.SelectedFont;
                chatTextColor = settingsForm.SelectedColor;

                chatTextBox.Font = chatFont;
                chatTextBox.ForeColor = chatTextColor;
            }

        }

        private void saveLogButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Зберегти лог чату";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.IO.File.WriteAllText(saveFileDialog.FileName, chatLog.ToString(), Encoding.UTF8);
                        MessageBox.Show("Лог чату збережено успішно.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка при збереженні: " + ex.Message);
                    }
                }
            }
        }


    }
}
