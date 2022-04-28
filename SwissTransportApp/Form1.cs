using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void ShowConnectionsButton_Click(object sender, EventArgs e)
        {

            ITransport transport = new Transport();


            var connectionsList = transport.GetConnections(startCombobox.Text, arrivalCombobox.Text);

            foreach (Connection connections in connectionsList.ConnectionList)
            {
                connectionsTable.Rows.Add(
                    connections.From.Station.Name,
                    connections.From.Departure,
                    connections.From.Platform,
                    connections.To.Station.Name,
                    connections.To.Arrival
                    
                );
            }
        }

        private void ShowDeparturesButton_Click(object sender, EventArgs e)
        {
            ITransport transport = new Transport();

            var departureList = transport.GetStationBoard(startCombobox.Text, startCombobox.Text);
            

            foreach (StationBoard stationBoard in departureList.Entries )
            {
                var connectionsList = transport.GetConnections(startCombobox.Text, stationBoard.To);
                DepartureTable.Rows.Add(
                    departureList.Station.Name,
                    stationBoard.To,
                    "anzeigen"
                    

                );

            }


        }

        private void StationSearchButton_Click(object sender, EventArgs e)
        {


            if (startCombobox.Text != null)
            {
                ITransport transportStart = new Transport();
                Stations startStations = transportStart.GetStations(startCombobox.Text);

                foreach (Station station in startStations.StationList)
                {
                    startCombobox.Items.Add(station.Name);

                }
            }
            else
            {
                MessageBox.Show("Sie m�ssen mindestens einen Abfahrtsort angeben!");
            }


            if (arrivalCombobox.Text != "")
            {
                ITransport transportEnd = new Transport();

                Stations arrivalStations = transportEnd.GetStations(arrivalCombobox.Text);

                foreach (Station station in arrivalStations.StationList)
                {
                    arrivalCombobox.Items.Add(station.Name);

                }
            }
        }
    }
}