using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using SwissTransport.Core;
using SwissTransport.Models;
using System.Net.NetworkInformation;
using System.Runtime;
using System.Runtime.InteropServices;

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

            try
            {
                InternetConnection internetConnection = new InternetConnection();


                if (internetConnection.CheckConnectionWifi() == true)
                {
                    if (startCombobox.Text != "" && arrivalCombobox.Text != "")
                    {
                        ITransport transport = new Transport();


                        //Get Data with input
                        var connectionsList = transport.GetConnections(startCombobox.Text, arrivalCombobox.Text,
                            DepartureDatePicker.Value, DepartureTimePicker.Value);

                        //output
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
                    else
                    {
                        MessageBox.Show("Sie müssen eine Startstation und eine Endtsation angeben!");
                    }
                }
                else
                {
                    MessageBox.Show("Bei der InternetVerbindung ist etwas schiefgelaufen!");
                }

            }
            catch (OverflowException overflowException)
            {
                MessageBox.Show(overflowException.ToString());
            }
            catch (FormatException formatException)
            {
                MessageBox.Show(formatException.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }




        private void ShowDeparturesButton_Click(object sender, EventArgs e)
        {
            GridViewChanger.SelectedTab = DeparturesTabPage;

            InternetConnection internetConnection = new InternetConnection();

            DepartureTable.Rows.Clear();

            try
            {
                
                if (internetConnection.CheckConnectionWifi() == true)
                {
                    ITransport transport = new Transport();

                    //Get data with input
                    var departureList = transport.GetStationBoard(startCombobox.Text, startCombobox.Text);

                    //output
                    foreach (StationBoard stationBoard in departureList.Entries)
                    {
                        DepartureTable.Rows.Add(
                            departureList.Station.Name,
                            stationBoard.To,
                            string.Format("{0:t}", stationBoard.Stop.Departure)
                            );
                    }

                }
                else
                {
                    MessageBox.Show("Bei der Internetverbindung ist etwas schiefgelaufen!");
                }
                
                

            }
            catch (OverflowException overflowException)
            {
                MessageBox.Show(overflowException.ToString());
            }
            catch (FormatException formatException)
            {
                MessageBox.Show(formatException.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

        }




        private void StationSearchButton_Click(object sender, EventArgs e)
        {

            try
            {


                if (startCombobox.Text != "")
                {
                    InternetConnection internetConnection = new InternetConnection();

                    if (internetConnection.CheckConnectionWifi() == true)
                    {
                        ITransport transportStart = new Transport();

                        //get data with input
                        Stations startStations = transportStart.GetStations(startCombobox.Text);

                        //list add
                        foreach (Station station in startStations.StationList)
                        {
                            startCombobox.Items.Add(station.Name);

                        }

                        if (arrivalCombobox.Text != "")
                        {
                            ITransport transportEnd = new Transport();
                            //get data with input
                            Stations arrivalStations = transportEnd.GetStations(arrivalCombobox.Text);

                            //ouput
                            foreach (Station station in arrivalStations.StationList)
                            {
                                arrivalCombobox.Items.Add(station.Name);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bei der Internetverbindung ist etwas schiefgelaufen!");
                    }
                }
                else
                {
                    MessageBox.Show("Sie müssen mindestens einen Abfahrtsort angeben!");
                }

            }
            catch (OverflowException overflowException)
            {
                MessageBox.Show(overflowException.ToString());
            }
            catch (FormatException formatException)
            {
                MessageBox.Show(formatException.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }


        }



        private void OnFormLoad(object sender, EventArgs e)
        {
            try
            {

                InternetConnection internetConnection = new InternetConnection();
                if (internetConnection.CheckConnectionWifi() == true)
                {
                    //standard input on load for automatical output
                    GridViewChanger.SelectedTab = DeparturesTabPage;

                    DepartureDatePicker.Value = DateTime.Now;
                    DepartureTimePicker.Value = DateTime.Now;

                    startCombobox.Text = "Adligenswil, Stuben";
                }
                else
                {
                    MessageBox.Show("Bei der Internetverbindung ist etwas schiefgelaufen!");
                }


            }
            catch (OverflowException overflowException)
            {
                MessageBox.Show(overflowException.ToString());
            }
            catch (FormatException formatException)
            {
                MessageBox.Show(formatException.ToString());
            }
            catch (Exception )
            {
                MessageBox.Show("Error");
            }
        }


        
    }
    
}