/*
 * Filename      : FrmModbus.cs
 * Author        : Saurabh A. Wani
 * Version       : 1.0
 * Date Modifiied: 02/16/2017
 * Description   : Windows Form Application which connects to device using it's IP address. 
 *                 Once connected it perform Read/Write operations on single or multiple Holding Registers and Coil 
 *                 Registers. 
 * Notes         : Port number 502 is dedicated for MODBUS communication.               
 * 
 **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Modbus.Device;


namespace NModbusTest
{
    public partial class FrmModbus : Form
    {


        public FrmModbus()
        {
            InitializeComponent();
        }

        private void FrmModbus_Load(object sender, EventArgs e){}

        /*
         * Reads Holding Register values based on the address received from the 'textReadModbusAddress' and 
         * the count of the holding registers to be read from 'txtReadModbusCount'.
         * */
        private void btnReadRegister_Click(object sender, EventArgs e)
        {
            try
            {

                // Taking ip from the text box and connects to port 502 of the slave. 
                using (TcpClient client = new TcpClient(txtIPAddress.Text, 502))
                {
                    // Clearing register values to be read
                    txtReadRegisterValue.Text    = "";

                    // Establishing a connection between the master and slave. 
                    ModbusIpMaster master        = ModbusIpMaster.CreateIp(client);

                    // Assign Modbus-StartAddress and number of registers to be read
                    ushort StartAddress          = Convert.ToUInt16(textReadModbusAddress.Text);
                    ushort RegisterCount         = Convert.ToUInt16(txtReadModbusCount.Text);

                    // read input register values
                    ushort[] values              = master.ReadHoldingRegisters(StartAddress, RegisterCount);

                    //Write the register value/s in the textbox. 
                    foreach (ushort us in values)
                    {
                        txtReadRegisterValue.Text += us.ToString() + "; ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*
         * Writes into Holding Register values based on the address received from the 'textWriteModbusAddress' and 
         * the count of the holding registers to be read from 'txtWriteModbusCount'.
         * */
        private void btnWriteRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking ip from the text box and connects to port 502 of the slave. 
                using  (TcpClient client        = new TcpClient(txtIPAddress.Text, 502))
                {
                    // Establishing a connection between the master and slave. 
                    ModbusIpMaster master       = ModbusIpMaster.CreateIp(client);

                    // Assign Modbus StartAddress and number of registers to be written.
                    ushort StartAddress         = Convert.ToUInt16(textWriteModbusAddress.Text);
                    ushort HoldingRegisterValue = Convert.ToUInt16(txtWriteRegisterValue.Text);

                    // Write register values.
                    master.WriteSingleRegister(StartAddress, HoldingRegisterValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e) { }

        private void txtReadRegisterValue_TextChanged(object sender, EventArgs e) { }

        private void groupBox3_Enter(object sender, EventArgs e) { }

        private void groupBox4_Enter(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        /*
         * Reads Coil Register values based on the address received from the 'textReadCoilAddress' and 
         * the count of the holding registers to be read from 'txtReadCoilCount'.
         * */
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Taking ip from the text box.
                using (TcpClient client   = new TcpClient(txtIPAddress.Text, 502))
                {
                    // Clearing register values to be read.
                    txtReadCoilValue.Text = "";

                    // Establishing a connection. 
                    ModbusIpMaster master = ModbusIpMaster.CreateIp(client);
                    
                    // Assign Modbus-StartAddress and number of registers to be read.
                    ushort StartAddress   = Convert.ToUInt16(textReadCoilAddress.Text);
                    ushort RegisterCount  = Convert.ToUInt16(txtReadCoilCount.Text);

                    // Read input register values.
                    bool[] values         = master.ReadCoils(StartAddress, RegisterCount);

                    // Write the register values.
                    foreach (bool us in values)
                    {
                        txtReadCoilValue.Text += us.ToString() + "; ";
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textReadModbusAddress_TextChanged(object sender, EventArgs e){}

        /*
         * Establish a connection between the master and the slave. 
         * */
        public void btnTCPConnect_Click(object sender, EventArgs e)
        {
            // Get the IP address of the device to be connected from the textbox.
            TcpClient clientMain  = new TcpClient(txtIPAddress.Text, 502);
            
            // Creating a connection based on the IP address and the port number. 
            ModbusIpMaster master = ModbusIpMaster.CreateIp(clientMain);

        }

        private void btnTCPDisconnect_Click(object sender, EventArgs e){}

        private void txtWriteRegisterValue_TextChanged(object sender, EventArgs e){}

        private void textWriteModbusAddress_TextChanged(object sender, EventArgs e){}

        private void label5_Click(object sender, EventArgs e){}

        private void textBox7_TextChanged(object sender, EventArgs e){}

        private void label6_Click(object sender, EventArgs e){}

        private void textBox5_TextChanged(object sender, EventArgs e){}

        /*
         * Writes into Coil Register values based on the address received from the 'textWriteCoilAddress' and 
         * the value to be written obtained from 'txtWriteCoilCount'.
         * */
        private void btnWriteCoil_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the IP address of the device to be connected from the textbox.
                using (TcpClient client   = new TcpClient(txtIPAddress.Text, 502))
                {
                    // Create connection based on the IP address and port number obtained.
                    ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

                    // Assign Modbus StartAddress and number of registers to be written
                    ushort StartAddress   = Convert.ToUInt16(textWriteCoilAddress.Text);
                    ushort CoilValue      = Convert.ToUInt16(txtWriteCoilValue.Text);

                    // Write register values
                    master.WriteSingleCoil(StartAddress, Convert.ToBoolean(CoilValue));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtWriteCoilValue_TextChanged(object sender, EventArgs e){}

        private void label1_Click(object sender, EventArgs e){}

        private void txtIPAddress_TextChanged(object sender, EventArgs e){}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking ip from the text box.
                using (TcpClient client = new TcpClient(txtIPAddress.Text, 502))
                {
                    // Clearing register values to be read.
                    txtStatusCheck.Text = "";

                    // Establishing a connection. 
                    ModbusIpMaster master = ModbusIpMaster.CreateIp(client);

                    // Assign Modbus-StartAddress and number of registers to be read.
                    ushort TrackAddress = Convert.ToUInt16(txtTrackNumber.Text);

                    // Read input register values.
                    bool[] value = master.ReadCoils(TrackAddress, 1);

                    // Write the register values.
                    txtStatusCheck.Text += value[0].ToString() ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
