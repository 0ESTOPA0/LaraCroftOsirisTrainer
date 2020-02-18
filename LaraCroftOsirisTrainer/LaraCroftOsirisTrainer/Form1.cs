using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaraCroftOsirisTrainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool botIsRunning;

        private void button1_Click_1(object sender, EventArgs e)
        {
            botIsRunning = true;
            startNewThread();
        }

        public void startNewThread()
        {
            // Run the botmethods in a different thread, then the UI won't freeze.
            // this starts the above method
            Thread botMethod = new Thread(mainTrainerMethod);
            botMethod.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            botIsRunning = false;
        }

        IntPtr baseAddress = IntPtr.Zero;
        public void mainTrainerMethod() // Focus world of warcraft windows
        {
            // var process = Process.GetProcesses();

            var prc = Process.GetProcessesByName("LC2");
            if (prc.Length > 0)
            {
                Process mainProcess = prc[0];
                foreach (ProcessModule module in mainProcess.Modules)
                {
                    if (module.ModuleName.Contains("LC2"))
                    {
                        baseAddress = module.BaseAddress;
                    }
                }


                VAMemory vMemory = new VAMemory("LC2");
                int ammoFinalAddress = vMemory.ReadInt32((IntPtr)baseAddress + 0x056977B4); 
                int healthFinalAddress = vMemory.ReadInt32((IntPtr)baseAddress + 0x025D1A00); 
                int gemsFinalAddress = vMemory.ReadInt32((IntPtr)baseAddress + 0x00C0ACE8);

                int ammoP1 = vMemory.ReadInt32((IntPtr)ammoFinalAddress + 0x14); // 808 // 288
                int ammoP2 = vMemory.ReadInt32((IntPtr)ammoP1 + 0x0); // 808 // 288
                int ammoOriginal = vMemory.ReadInt32((IntPtr)ammoP2 + 0x8); // 808 // 288
                float healthOriginal = vMemory.ReadFloat((IntPtr)healthFinalAddress + 0x18); // 808 // 288
                int gemsP1 = vMemory.ReadInt32((IntPtr)gemsFinalAddress + 0xc8); // 808 // 288
                int gemsOriginal = vMemory.ReadInt32((IntPtr)gemsP1 + 0xe38); // 808 // 288


                while (botIsRunning)
                {
                    // AMMO
                    ammoOriginal = SetAmmo(vMemory, ammoP2, ammoOriginal);

                    //HEALTH
                    healthOriginal = SetHealth(vMemory, healthFinalAddress, healthOriginal);

                    //GEMS
                    int gems = vMemory.ReadInt32((IntPtr)gemsP1 + 0xe38);
                    Invoke(new Action(() =>
                    {
                        lblGems.Text = gems.ToString();
                    }));

                    Thread.Sleep(200);
                }
                // SetForegroundWindow(prc[0].MainWindowHandle);
            }
            else
                MessageBox.Show("LC2 window not found");

        }

        private float SetHealth(VAMemory vMemory, int healthFinalAddress, float healthOriginal)
        {
            float health = vMemory.ReadFloat((IntPtr)healthFinalAddress + 0x18); // 808 // 288
            Invoke(new Action(() =>
            {
                lblHealth.Text = health.ToString();
            }));
            if (chkHealth.Checked)
            {
                if (health > healthOriginal)
                {
                    healthOriginal = health;
                }

                vMemory.WriteFloat((IntPtr)healthFinalAddress + 0x18, healthOriginal); // 808 // 288
            }
            else
            {
                healthOriginal = health;
            }

            return healthOriginal;
        }

        private int SetAmmo(VAMemory vMemory, int ammoP2, int ammoOriginal)
        {
            int ammo = vMemory.ReadInt32((IntPtr)ammoP2 + 0x8); // 808 // 288
            Invoke(new Action(() =>
            {
                lblCurrentAmmo.Text = ammo.ToString();
            }));
            if (chckAmmo.Checked)
            {
                if (ammo > ammoOriginal)
                {
                    ammoOriginal = ammo;
                }

                vMemory.WriteInt32((IntPtr)ammoP2 + 0x8, ammoOriginal); // 808 // 288
            }
            else
            {
                ammoOriginal = ammo;
            }

            return ammoOriginal;
        }
        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (baseAddress == IntPtr.Zero)
            {
                MessageBox.Show("Press Start");
                return;
            }
               
            VAMemory vMemory = new VAMemory("LC2");

            int gemsFinalAddress = vMemory.ReadInt32((IntPtr)baseAddress + 0x00C0ACE8);

            int gemsP1 = vMemory.ReadInt32((IntPtr)gemsFinalAddress + 0xc8); // 808 // 288
            int gemsOriginal = vMemory.ReadInt32((IntPtr)gemsP1 + 0xe38); // 808 // 288

            vMemory.WriteInt32((IntPtr)gemsP1 + 0xe38, int.Parse(txtGems.Text)); // 808 // 288


            int gems = vMemory.ReadInt32((IntPtr)gemsP1 + 0xe38);
            Invoke(new Action(() =>
            {
                lblCurrentAmmo.Text = gems.ToString();
            }));

        }
    }
}
