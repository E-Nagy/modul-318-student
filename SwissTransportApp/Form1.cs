using System.ComponentModel;
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
                connectionsDeparturesTable.Rows.Add(
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

            foreach (StationBoard stationboard in departureList.Entries )
            {
                connectionsDeparturesTable.Rows.Add(
                    departureList.Station,
                    stationboard.Stop.Departure
                    
                    
                    );

            }


        }

        private void StationSearchButton_Click(object sender, EventArgs e)
        {

            ITransport transportstart = new Transport();

            Stations startStations = transportstart.GetStations(startCombobox.Text);

            foreach (Station station in startStations.StationList )
            {
                startCombobox.Items.Add(station.Name);
                    
            }

            ITransport transportend = new Transport();

            Stations arrivalStations = transportend.GetStations(startCombobox.Text);

            foreach (Station station in arrivalStations.StationList)
            {
                arrivalCombobox.Items.Add(station.Name);

            }
        }
    }
}