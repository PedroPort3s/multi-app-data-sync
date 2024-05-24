using System.Net.Sockets;
using Microsoft.AspNetCore.SignalR.Client;
using Models;

namespace WinForm
{
    public partial class FormInputOutput : Form
    {
        private HubConnection _connection;
        private string senderUser = $"WinForms-{Guid.NewGuid().ToString().Substring(0, 7)}";

        public FormInputOutput()
        {
            InitializeComponent();
            EnableChatComponents(false);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInput.Text))
                {
                    throw new ArgumentException("Add a text to send to the server.");
                }

                await SendMessageAsync(txtInput.Text);

                txtInput.Text = string.Empty;
            }
            catch (ArgumentNullException argNullException)
            {
                MessageBox.Show(argNullException.Message, "Empty message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnConnect_Click(object whoSent, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtServerAddress.Text))
                {
                    throw new FormatException("Invalid IP/Port, try another one.");
                }

                Uri uri = new Uri(txtServerAddress.Text);

                string serverEndpointWithIpAndPort = uri.AbsoluteUri;

                await ConnectToChatServerAsync(serverEndpointWithIpAndPort);

                _connection.On<ChatMessage>("ReceiveMessage", UpdateReceivedText);

                MessageBox.Show($"Connected successfully stablished with server {serverEndpointWithIpAndPort}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EnableChatComponents(true);
            }
            catch (FormatException formatException)
            {
                MessageBox.Show(formatException.Message, "IP Conversion error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateReceivedText(ChatMessage message)
        {
            if (listBoxOutput.InvokeRequired)
            {
                listBoxOutput.Invoke(new Action(() => listBoxOutput.Items.Add(message.ToString())));
            }
            else
            {
                listBoxOutput.Items.Add(message.ToString());
            }
        }

        private async Task DisconnectAsync()
        {
            if (_connection != null)
            {
                await _connection.DisposeAsync();
                _connection = null;
            }
        }

        private async Task SendMessageAsync(string messageText)
        {
            if (_connection.State == HubConnectionState.Connected)
            {
                ChatMessage message = new ChatMessage
                {
                    Content = messageText,
                    Sender = senderUser,
                    Timestamp = DateTime.Now
                };

                await _connection.SendAsync("SendMessage", message);
            }
            else
            {
                MessageBox.Show("Unable to send messages to server, try connecting again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableChatComponents(false);
                await DisconnectAsync();
            }
        }

        private void EnableChatComponents(bool shouldBeEnabled)
        {
            pnlInputOutput.Enabled = shouldBeEnabled;
            btnDisconnect.Enabled = shouldBeEnabled;
            btnConnect.Enabled = !shouldBeEnabled;

            if (!shouldBeEnabled)
            {
                txtInput.Text = string.Empty;
                listBoxOutput.Items.Clear();
            }
        }

        private async Task ConnectToChatServerAsync(string serverUrl)
        {
            serverUrl += "chat";

            _connection = new HubConnectionBuilder()
            .WithUrl(serverUrl)
            .Build();

            await _connection.StartAsync();
        }

        private async void FormInputOutput_FormClosing(object sender, FormClosingEventArgs e)
        {
            await DisconnectAsync();
        }

        private async void btnDisconnect_Click(object sender, EventArgs e)
        {
            EnableChatComponents(false);
            await DisconnectAsync();
            MessageBox.Show($"Disconnected successfully from the server!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNewInstance_Click(object sender, EventArgs e)
        {
            FormInputOutput formInputOutput = new FormInputOutput();

            formInputOutput.Show();
        }
    }
}
