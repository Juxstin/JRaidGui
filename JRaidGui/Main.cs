using Discord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRaidGui
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        WMPLib.WindowsMediaPlayer a;

        private void playmp3(string path)
        {
            a = new WMPLib.WindowsMediaPlayer();
            a.URL = path;
            a.controls.play();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            playmp3(AppDomain.CurrentDomain.BaseDirectory + "\\internetBoi.mp3");
        }
        static void WriteErrorLog(string log)
        {
            StreamWriter fileauth = new StreamWriter("ErrorLogs.txt", true);
            fileauth.WriteLine(log);
            fileauth.Close();
        }
       
        private void FloodFriend_Click(object sender, EventArgs e)
        {
            var rt = Task.Run(async delegate
            {
                foreach (string line in File.ReadAllLines("Tokens.txt"))
                {
                    try
                    {
                        DiscordClient client = new DiscordClient(line);

                        client.SendFriendRequest(Username.Text, uint.Parse(Tag.Text));

                        await Task.Delay(Int32.Parse(Delay.Text));
                    }
                    catch (Exception ex)
                    {
                        WriteErrorLog("[Friend Flood] " + ex.ToString());
                        await Task.Delay(50);
                    }
                }
            });
        }

        private void JoinGuild_Click(object sender, EventArgs e)
        {
            var rt = Task.Run(async delegate
            {
                foreach (string line in File.ReadAllLines("Tokens.txt"))
                {
                    try
                    {
                        DiscordClient client = new DiscordClient(line);

                        client.JoinGuild(InviteCode.Text);

                        await Task.Delay(Int32.Parse(Delay.Text));
                    }
                    catch (Exception ex)
                    {
                        WriteErrorLog("[Join Guild] " + ex.ToString());
                        await Task.Delay(50);
                    }
                }
            });
        }

        private void JoinGroupBtn_Click(object sender, EventArgs e)
        {
            var rt = Task.Run(async delegate
            {
                foreach (string line in File.ReadAllLines("Tokens.txt"))
                {
                    try
                    {
                        DiscordClient client = new DiscordClient(line);

                        GroupInvite invite = client.JoinGroup(InviteCodeGroup.Text);

                        await Task.Delay(Int32.Parse(Delay.Text));
                    }
                    catch (Exception ex)
                    {
                        WriteErrorLog("[Join Group] " + ex.ToString());
                        await Task.Delay(50);
                    }
                }
            });
        }

        private void LeaveGuild_Click(object sender, EventArgs e)
        {
            var rt = Task.Run(async delegate
            {
                foreach (string line in File.ReadAllLines("Tokens.txt"))
                {
                    try
                    {
                        DiscordClient client = new DiscordClient(line);

                        client.LeaveGuild(ulong.Parse(GuildID.Text));

                        await Task.Delay(Int32.Parse(Delay.Text));
                    }
                    catch (Exception ex)
                    {
                        WriteErrorLog("[Leave Guild] " + ex.ToString());
                        await Task.Delay(50);
                    }
                }
            });
        }

        private void LeaveGroupBtn_Click(object sender, EventArgs e)
        {
            var rt = Task.Run(async delegate
            {
                foreach (string line in File.ReadAllLines("Tokens.txt"))
                {
                    try
                    {
                        DiscordClient client = new DiscordClient(line);

                        client.LeaveGroup(ulong.Parse(GroupID2.Text));

                        await Task.Delay(Int32.Parse(Delay.Text));
                    }
                    catch (Exception ex)
                    {
                        WriteErrorLog("[Leave Group] " + ex.ToString());
                        await Task.Delay(50);
                    }
                }
            });
        }

        private void SpamGuild_Click(object sender, EventArgs e)
        {
            var rt = Task.Run(async delegate
            {
                foreach (string line in File.ReadAllLines("Tokens.txt"))
                {
                    try
                    {
                        DiscordClient client = new DiscordClient(line);

                        TextChannel channel = client.GetChannel(ulong.Parse(ChannelId.Text)).ToTextChannel();
                        if (Typing.Checked)
                        {
                            channel.TriggerTyping();
                            channel.SendMessage(SpamText.Text);
                            await Task.Delay(Int32.Parse(Delay.Text));
                        }
                        else
                        {
                            channel.SendMessage(SpamText.Text);
                            await Task.Delay(Int32.Parse(Delay.Text));
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteErrorLog("[Spam Guild] " + ex.ToString());
                        await Task.Delay(50);
                    }
                }
            });
        }

        private void SpamDMButton_Click(object sender, EventArgs e)
        {
            var rt = Task.Run(async delegate
            {
                foreach (string line in File.ReadAllLines("Tokens.txt"))
                {
                    try
                    {
                        DiscordClient client = new DiscordClient(line);

                        DMChannel channel = client.CreateDM(ulong.Parse(UserID.Text));
                        if (Typing.Checked)
                        {
                            channel.TriggerTyping();
                            channel.SendMessage(SpamTextDM.Text);
                            await Task.Delay(Int32.Parse(Delay.Text));
                        }
                        else
                        {
                            channel.SendMessage(SpamTextDM.Text);
                            await Task.Delay(Int32.Parse(Delay.Text));
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteErrorLog("[Spam DM] " + ex.ToString());
                        await Task.Delay(50);
                    }
                }
            });
        }

        private void SpamGroupBtn_Click(object sender, EventArgs e)
        {
            var rt = Task.Run(async delegate
            {
                foreach (string line in File.ReadAllLines("Tokens.txt"))
                {
                    try
                    {
                        DiscordClient client = new DiscordClient(line);

                        DMChannel channel = client.GetGroup(ulong.Parse(GroupID.Text));
                        if (Typing.Checked)
                        {
                            channel.TriggerTyping();
                            channel.SendMessage(GroupText.Text);
                            await Task.Delay(Int32.Parse(Delay.Text));
                        }
                        else
                        {
                            channel.SendMessage(GroupText.Text);
                            await Task.Delay(Int32.Parse(Delay.Text));
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteErrorLog("[Spam Group] " + ex.ToString());
                        await Task.Delay(50);
                    }

                }
            });
        }

        private void FloodInvite_Click(object sender, EventArgs e)
        {
            var rt = Task.Run(async delegate
            {
                foreach (string line in File.ReadAllLines("Tokens.txt"))
                {
                    try
                    {
                        DiscordClient client = new DiscordClient(line);

                        client.CreateInvite(ulong.Parse(InviteChannel.Text));

                        await Task.Delay(Int32.Parse(Delay.Text));
                    }
                    catch (Exception ex)
                    {
                        WriteErrorLog("[Invite Spam] " + ex.ToString());
                        await Task.Delay(50);
                    }
                }
            });
        }
        private void MusicControl_CheckedChanged(object sender)
        {
            if (MusicControl.Checked)
            {
                a.controls.stop();
            }
            else
            {
                a.controls.play();
            }
        }
    }
}
