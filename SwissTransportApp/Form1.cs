using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
            GridViewChanger.SelectedTab = ConnectionsTabPage;

            connectionsTable.Rows.Clear();

                ITransport transport = new Transport();


                var connectionsList = transport.GetConnections(startCombobox.Text, arrivalCombobox.Text,DepartureDatePicker.Value, DepartureTimePicker.Value);

                foreach (Connection connections in connectionsList.ConnectionList)
                {
                    connectionsTable.Rows.Add(
                        connections.From.Station.Name,
                        string.Format("{0:t}", connections.From.Departure),
                        connections.From.Platform,
                        connections.To.Station.Name,
                        string.Format("{0:t}", connections.To.Arrival)

                    );
                }
            
        }

        private void ShowDeparturesButton_Click(object sender, EventArgs e)
        {
            GridViewChanger.SelectedTab = DeparturesTabPage;

            DepartureTable.Rows.Clear();

            ITransport transport = new Transport();

            var departureList = transport.GetStationBoard(startCombobox.Text, startCombobox.Text);


            foreach (StationBoard stationBoard in departureList.Entries)
            {
                DepartureTable.Rows.Add(
                    departureList.Station.Name,
                    stationBoard.To,
                    string.Format("{0:t}", stationBoard.Stop.Departure)

                );

            }

        }


        private void StationSearchButton_Click(object sender, EventArgs e)
        {


            if (startCombobox.Text != "")
            {
                ITransport transportStart = new Transport();
                Stations startStations = transportStart.GetStations(startCombobox.Text);

                foreach (Station station in startStations.StationList)
                {
                    startCombobox.Items.Add(station.Name);

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
            else
            {
                MessageBox.Show("Sie müssen mindestens einen Abfahrtsort angeben!");
            }


        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            GridViewChanger.SelectedTab = DeparturesTabPage;
            
            DepartureDatePicker.Value = DateTime.Now;
            DepartureTimePicker.Value = DateTime.Now;

            startCombobox.Text = "Adligenswil, Stuben";
        }

        private void SearchStartOnMap_Click(object sender, EventArgs e)
        {
            ITransport transport = new Transport();

            GridViewChanger.SelectedTab = MapTabPage;

            string startStation = startCombobox.Text;

            StringBuilder querryAddress = new StringBuilder();



        }
    }
    
}