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

            Station station = new Station();

            


            /*var departurelist = transport.GetStationBoard(startCombobox.Text, station.Id);

            foreach(StationBoard stationboard in departurelist.Entries)
            {
                connectionsDeparturesTable.Rows.Add(
                    stationboard.From.Station.Name,
                    stationboard.From.Departure,
                    stationboard.From.Platform,
                    stationboard.To.Station.Name,
                    stationboard.To.Arrival

                );

            }*/

            

        }


    }
}