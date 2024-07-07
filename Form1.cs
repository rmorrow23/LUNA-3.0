using Moonbase.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class FormMain : Form
    {
        // Variable to hold the user's current position
        string currentPosition;
        // array to hold different locations
        string[] location = new string [5];

        public FormMain()
        {
            InitializeComponent();
        }

        //function to update form based on location
        public void updateForm(string newLocation)
        {   //checks the new location selected to see what info to put
            if (newLocation == location[0])
            {
                // Update user position
                UpdateUserPosition("Command Center");
                
                // Change the background image to command center
                this.BackgroundImage = Properties.Resources.command_center;
                // Change Room Title to Command Center
                TBRoomName.Text = "Lunar Operations Command Center";
                // Change room description to Command Center Description
                TXBXRoomDesc.Text = "The Lunar Operations Command Center is the heart of the moonbase, featuring walls of sleek metallic panels embedded with soft, ambient LED lights that create a futuristic glow. Large, reinforced windows offer a breathtaking view of the lunar landscape and Earth. High-tech consoles with holographic displays dominate the room, providing real-time data and interactive controls for managing base operations.";
            }
            else if (newLocation == location[1])
            {
                // Update user position
                UpdateUserPosition("Lab");
                // Change background image to Laboratory
                this.BackgroundImage = Properties.Resources.lab;
                // Change Room Title to Laboratory
                TBRoomName.Text = "Lunar Laboratory";
                // Change room description to Laboratory Description
                TXBXRoomDesc.Text = "The Lunar Laboratory is a hub of scientific discovery, featuring sleek metallic walls illuminated by ambient LED lights. Large windows offer a view of the lunar surface, enhancing the high-tech atmosphere. Equipped with advanced scientific instruments and robotic assistants, the lab enables groundbreaking experiments and efficient research.";
            }

            else if(newLocation == location[2])
            {
                // Update user position
                UpdateUserPosition("Living Quarters");
                // Change background image to Living Quarters
                this.BackgroundImage = Properties.Resources.living;
                // Change Room Title to Living Quarters
                TBRoomName.Text = "Lunar Living Quarters";
                // Change room description to Living Quarters Description
                TXBXRoomDesc.Text = "The Lunar Living Quarters offer a cozy refuge with sleek metallic walls and warm LED lighting. Large windows provide a stunning lunar landscape view. Modern furniture, including a comfortable bed, seating area, and holographic work desk, ensure comfort and functionality, while personal items add a homely touch.";
            }

            else if(newLocation == location[3])
            {
                // Update user position
                UpdateUserPosition("MedBay");
                // Change background image to MedBay
                this.BackgroundImage = Properties.Resources.medbay;
                // Change Room Title to MedBay
                TBRoomName.Text = "Lunar Medical Bay";
                // Change room description to MedBay Description
                TXBXRoomDesc.Text = "The Lunar Medbay is a state-of-the-art medical facility with sleek metallic walls and soft LED lighting. Large windows provide a calming view of the lunar surface. Equipped with advanced medical technology and robotic assistants, the medbay ensures top-notch care and efficient patient management.";
            }

            else if (newLocation == location[4])
            {
                // Update user position
                UpdateUserPosition("Lobby");
                // Change background image to MedBay
                this.BackgroundImage = Properties.Resources.lobby;
                // Change Room Title to MedBay
                TBRoomName.Text = "Lunar Lobby";
                // Change room description to MedBay Description
                TXBXRoomDesc.Text = "The Lunar Lobby is the central hub of the moonbase, featuring high ceilings, sleek metallic walls, and large panoramic windows offering stunning lunar views. Modern seating areas and a state-of-the-art reception desk with holographic displays provide comfort and efficient communication. Astronauts in advanced space suits and robotic assistants seamlessly move through the lobby, reflecting the integration of human and robotic efforts in moonbase operations.";
            }
            disableNav(newLocation);
        }

        public void disableNav(string currentlocation)
        {
            if ((currentlocation == location[0]) || (currentlocation == location[1]) || (currentlocation == location[2]) || (currentlocation == location[3]))
            {
                //sets all buttons to disabled except the main lobby
                commandCenterBTN.Enabled = false;
                labBTN.Enabled = false;
                livingQtBTN.Enabled = false;
                medBayBTN.Enabled = false;

                LobbyBTN.Enabled = true;
            }

            else if (currentlocation == location[4])
            {
                //re-enable all buttons except the main lobby
                commandCenterBTN.Enabled = true;
                labBTN.Enabled = true;
                livingQtBTN.Enabled = true;
                medBayBTN.Enabled = true;

                LobbyBTN.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize array with the different locations
            location[0] = "Command Center";
            location[1] = "Laboratory";
            location[2] = "Living Quarters";
            location[3] = "Medical Bay";
            location[4] = "Lobby";

            updateForm(location[4]);
        }

        private void UpdateUserPosition(string newPosition)
        {
            currentPosition = newPosition;
            LogUserPosition();
        }

        private void LogUserPosition()
        {
            //log file will be under MoonBase\bin\x64\Debug
            string logFilePath = "user_location_log.txt";
            string logMessage = $"{DateTime.Now}: User moved to {currentPosition}";

            try
            {   //saves the new location to the specified log file
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {   //shows error message
                MessageBox.Show($"Error logging user position: {ex.Message}");
            }
        }

        private void TBRoomName_TextChanged(object sender, EventArgs e)
        {
            // Handle any changes to the room name textbox if necessary
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle any actions related to label2 if necessary
        }

        // Nav Buttons
        private void commandCenterBTN_Click(object sender, EventArgs e)
        {
            updateForm(location[0]);
        }

        private void labBTN_Click(object sender, EventArgs e)
        {
            updateForm(location[1]);
        }

        private void medBayBTN_Click(object sender, EventArgs e)
        {
            updateForm(location[3]);
        }

        private void livingQtBTN_Click(object sender, EventArgs e)
        {
            updateForm(location[2]);
        }

        private void LobbyBTN_Click(object sender, EventArgs e)
        {
            updateForm(location[4]);
        }
    }
}
