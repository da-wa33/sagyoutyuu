using DiscordRPC;
using System;
using System.Windows.Forms;

namespace 作業中
{
    public partial class Form1 : Form
    {
        private DateTime? startTime;

        private DiscordRpcClient client;

        public Form1()
        {
            InitializeComponent();

            client = new DiscordRpcClient("*******************");
            client.Initialize();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;


            Update.Enabled = false;
            Stop.Enabled = false;
            Start.Enabled = true;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Update.Enabled = true;
            Stop.Enabled = true;
            Start.Enabled = false;

            if (client == null || !client.IsInitialized)
            {
                client = new DiscordRpcClient("1462385117753245707");
                client.Initialize();
            }

            startTime = DateTime.UtcNow;

            client.SetPresence(new RichPresence
            {
                Details = detailBox.Text,
                State = stateBox.Text,
                Timestamps = new Timestamps
                {
                    Start = startTime.Value
                }
            });
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (client != null && client.IsInitialized)
            {
                client.ClearPresence();
            }

            Update.Enabled = false;
            Stop.Enabled = false;
            Start.Enabled = true;
        }
        
        private void Update_Click(object sender, EventArgs e)
        {
            if (client == null || !client.IsInitialized || startTime == null)
                return;

            client.SetPresence(new RichPresence
            {
                Details = detailBox.Text,
                State = stateBox.Text,
                Timestamps = new Timestamps
                {
                    Start = startTime.Value
                }
            });
        }

    }
}
