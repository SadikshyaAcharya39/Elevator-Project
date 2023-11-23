
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;



namespace Project1_Elevator
{
    public partial class Form1 : Form
    {
        // declare private variables
        private DataSet dataSet;
        private MySqlDataAdapter dataAdapter;
        private MySqlConnection connection;
        private BackgroundWorker backgroundWorker;
        private ProgressBar progressBar;



        public Form1()
        {
            InitializeComponent();

            // Initialize the DataSet and DataAdapter
            dataSet = new DataSet();
            dataAdapter = new MySqlDataAdapter();

            // Initialize the MySqlConnection with your connection string
            connection = new MySqlConnection("datasource=localhost; Database=Elevator_Project; " +
                "port=3306;username=root;password=Password@3");

            // Set the dataAdapter's SelectCommand and connection
            dataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM Display_Table", connection);
            // Fill the dataSet with data from the database
            dataAdapter.Fill(dataSet, "Display_Table");



            // Initialize the BackgroundWorker
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += backgroundWorker1_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            backgroundWorker.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;


            // Initialize the progress bar form
            progressBar = new ProgressBar();


        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            // Perform  long-running tasks here
            for (int i = 1; i <= 100; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                // Simulate work
                System.Threading.Thread.Sleep(10);


                //  Report progress
                backgroundWorker.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the progress bar in the ProgressBarForm
            progressBar.UpdateProgress(e.ProgressPercentage, $"Working: {e.ProgressPercentage}%");

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Background work is completed
            progressBar.Close(); // Close the progress bar form
            this.Show(); // Show Form1
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Show the progress bar form
            progressBar.WindowState = FormWindowState.Normal; // Ensure the window state is normal
            progressBar.Show();

            // Run the background worker when the form loads
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }

        }

        private void floor_1_Click(object sender, EventArgs e) //Floor 1 button
        {
            Global.DOOR_STATE = 1;
            timer3.Start();

            Events("Arrived at the first floor.");

            // Close the doors at Ground floor (pictureBox1 and pictureBox2)
            timer1.Stop();
            timer2.Stop();
            Events("The doors are shut on the ground floor.");
            pictureBox6.Image = Properties.Resources._20861982_button_number_1;
        }

        private void floor_G_Click(object sender, EventArgs e) // Ground Floor button
        {
            Global.DOOR_STATE = 2;
            timer4.Start();
            timer5.Start();
            timer3.Start();
            Events("Arrived at the Ground Floor");
            pictureBox6.Image = Properties.Resources.ruga;
        }

        private void timer1_Tick(object sender, EventArgs e) //Left Door
        {
            int leftLimit = 80;   // The left boundary
            int rightLimit = 230; // The right boundary

            if (Global.DOOR_STATE == 1)
            {
                // Moving to the left
                if (pictureBox1.Left <= leftLimit)
                {
                    // Stop when reaching the left boundary
                    timer1.Stop();


                }
                else
                {
                    // Continue moving to the left
                    pictureBox1.Left -= 5;
                }
            }
            else if (Global.DOOR_STATE == 2)
            {
                // Moving to the right
                if (pictureBox1.Right >= rightLimit)
                {
                    // Stop when reaching the right boundary
                    timer1.Stop();

                }
                else
                {
                    // Continue moving to the right
                    pictureBox1.Left += 5;
                }
            }
        }


        private void open_Click(object sender, EventArgs e) //open button
        {
            Global.DOOR_STATE = 1;
            timer1.Start();

            // Start timer2 when the door is opened
            timer2.Start();

            // timer4.Start();
            //timer5.Start();
            Events("Door Opened ");

        }
        private void close_Click(object sender, EventArgs e) //close button
        {
            Global.DOOR_STATE = 2;
            timer1.Start();

            // Stop timer2 when the door is closed
            timer2.Start();

            timer3.Stop();
            timer6.Start();
            // timer4.Start();
            // timer5.Start();
            timer8.Start();

            // Log a "Closed" event in the database
            Events(" Door Closed");
        }

        private void timer2_Tick_1(object sender, EventArgs e) //Right door
        {
            int leftLimit = 233;  // The left boundary
            int rightLimit = 400; // The right boundary


            if (Global.DOOR_STATE == 1)
            {
                // Moving to the right
                if (pictureBox2.Right >= rightLimit)
                {
                    // Stop when reaching the right boundary
                    timer2.Stop();

                }
                else
                {
                    // Continue moving to the right
                    pictureBox2.Left += 5;
                }
            }
            else if (Global.DOOR_STATE == 2)
            {
                // Moving to the left
                if (pictureBox2.Left <= leftLimit)
                {
                    // Stop when reaching the left boundary
                    timer2.Stop();

                }
                else
                {
                    // Continue moving to the left
                    pictureBox2.Left -= 5;
                }
            }
        }

        private void timer3_Tick_1(object sender, EventArgs e) 
        {
            if (Global.DOOR_STATE == 1)
            {
                if (pictureBox3.Top < 110)
                {
                    timer3.Stop(); // Stop the timer when both picture boxes reach the target Y location.
                                   // Start timer4 and timer5 to open the doors
                    timer4.Start();
                    timer5.Start();
                    //can log an event when the doors open
                    Events("Doors opened");
                }

                else
                {
                    pictureBox3.Top -= 5;

                }
            }

            else if (Global.DOOR_STATE == 2)
            {
                if (pictureBox3.Bottom > 820)
                {
                    timer3.Stop(); // Stop the timer when both picture boxes reach the target Y location.
                                   // Start timer6 and timer7 to close the doors

                    timer7.Start();
                    // log an event when the doors close
                    Events("Doors closed");

                }
                else
                {
                    pictureBox3.Top += 5;

                }
            }

        }


        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }

        private void Stop_1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Stop();
            //timer4.Stop();
            //timer5.Stop();
        }



        private void timer4_Tick(object sender, EventArgs e) //Picturebox 4 left door
        {
            int leftLimit = 80;   // The left boundary
            int rightLimit = 230; // The right boundary

            if (Global.DOOR_STATE == 1)
            {
                // Moving to the left
                if (pictureBox4.Left <= leftLimit)
                {
                    // Stop when reaching the left boundary
                    timer4.Stop();
                }
                else
                {
                    // Continue moving to the left
                    pictureBox4.Left -= 5;
                }
            }
            else if (Global.DOOR_STATE == 2)
            {
                // Moving to the right
                if (pictureBox4.Right >= rightLimit)
                {
                    // Stop when reaching the right boundary
                    timer4.Stop();
                }
                else
                {
                    // Continue moving to the right
                    pictureBox4.Left += 5;
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            int leftLimit = 233;  // The left boundary
            int rightLimit = 400; // The right boundary


            if (Global.DOOR_STATE == 1)
            {
                // Moving to the right
                if (pictureBox5.Right >= rightLimit)
                {
                    // Stop when reaching the right boundary
                    timer5.Stop();
                }
                else
                {
                    // Continue moving to the right
                    pictureBox5.Left += 5;
                }
            }
            else if (Global.DOOR_STATE == 2)
            {
                // Moving to the left
                if (pictureBox5.Left <= leftLimit)
                {
                    // Stop when reaching the left boundary
                    timer5.Stop();
                }
                else
                {
                    // Continue moving to the left
                    pictureBox5.Left -= 5;
                }
            }
        }

        /*  private void button1_Click(object sender, EventArgs e)
          {
              string url = "datasource=localhost;port=3306;username=root;password=Password@3";
              try
              {
                  MySqlConnection conn = new MySqlConnection(url);
                  conn.Open();
                  conn.Close();
                  MessageBox.Show("Connected successfully");

              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }

          } */

        private void button2_Click(object sender, EventArgs e) // Display Events Button
        {
            try
            {
                // Check if there are any records in the dataset
                if (dataSet.Tables["Display_Table"].Rows.Count == 0)
                {
                    // If there are no records, create an empty DataTable and display it
                    DataTable emptyTable = new DataTable();

                    emptyTable.Columns.Add("event");
                    emptyTable.Columns.Add("time");
                    emptyTable.Columns.Add("event_date");
                    dataGridView1.DataSource = emptyTable;
                }
                else
                {
                    // Filter the dataset to exclude "Auto-increment reset" records
                    var filteredRows = dataSet.Tables["Display_Table"].Select("event <> 'Auto-increment reset'", "", DataViewRowState.CurrentRows);
                    DataTable filteredTable = filteredRows.CopyToDataTable();

                    // Sort the filtered data by time in ascending order
                    DataView sortedView = filteredTable.DefaultView;
                    sortedView.Sort = "time ASC";

                    // Display the sorted data in dataGridView1
                    dataGridView1.DataSource = sortedView;
                    // hide event_id column
                    dataGridView1.Columns["Event_ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void InsertData(string Event, string Time, string Event_Date)
        {
            // Insert  data to the DataSet
            DataRow newRow = dataSet.Tables["Display_Table"].NewRow();
            newRow["event"] = Event;
            newRow["time"] = Time;
            newRow["Event_date"] = Event_Date;
            dataSet.Tables["Display_Table"].Rows.Add(newRow);

            // Update the database
            UpdateDatabase();
        }



        private void Events(string eventDescription)
        {
            string Event_Date = DateTime.Now.ToString("yyyy-MM-dd");
            string Time = DateTime.Now.ToString("HH:mm:ss"); // Including seconds
            InsertData(eventDescription, Time, Event_Date);
        }
        private void UpdateDatabase()
        {
            try
            {
                // Open the database connection
                connection.Open();
                // Create a DeleteCommand for the data adapter
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();

                // Update the database with changes from the DataSet
                dataAdapter.Update(dataSet, "Display_Table");

                // Reset the auto-increment counter
                ResetAutoIncrement();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        private void button3_Click(object sender, EventArgs e)//clear events
        {
            // Clear the dataset to remove all records from the DataGridView
            dataSet.Tables["Display_Table"].Clear();
            MessageBox.Show("All datas has been cleared");
        }

        private void ResetAutoIncrement()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    // Open the database connection if it's not already open
                    connection.Open();
                }

                // Check if the auto-increment reset log already exists in the dataset
                DataRow[] existingRows = dataSet.Tables["Display_Table"].Select("event = 'Auto-increment reset'");

                if (existingRows.Length == 0)
                {
                    // Create a new row
                    DataRow newRow = dataSet.Tables["Display_Table"].NewRow();

                    newRow["event"] = "Auto-increment reset";
                    newRow["time"] = DateTime.Now.ToString("HH:mm:ss");
                    newRow["event_date"] = DateTime.Now.ToString("yyyy-MM-dd");


                    // Add the new row to the dataset
                    dataSet.Tables["Display_Table"].Rows.Add(newRow);

                    // Create an InsertCommand for the data adapter
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
                    dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();

                    // Use the Update method to update the database
                    dataAdapter.Update(dataSet, "Display_Table");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void DeleteAllRecords()
        {
            try
            {
                // Open the database connection
                connection.Open();

                // Create a MySqlCommand to delete all records except "Auto-increment reset" from the "logs" table
                using (MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM Display_Table WHERE event <> 'Auto-increment reset'", connection))
                {
                    deleteCommand.ExecuteNonQuery();
                }

                // Clear the dataset to remove all records from the DataGridView
                dataSet.Tables["Display_Table"].Clear();

                // Display a message to indicate successful deletion
                MessageBox.Show("Every entry has been removed from the database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e) // Delete Events
        {
            DeleteAllRecords();
            MessageBox.Show("All the datas are deleted");
        }

        private void button1_Click_1(object sender, EventArgs e)//up call button
        {
            Global.DOOR_STATE = 1;
            timer3.Start();
            Events("Arrived at the first floor.");

            // Close the doors at Ground floor (pictureBox1 and pictureBox2)
            timer1.Stop();
            timer2.Stop();
            Events("The doors are shut on the ground floor.");
            pictureBox6.Image = Properties.Resources._20861982_button_number_1;
        }

        private void button5_Click(object sender, EventArgs e) //down call button
        {
            Global.DOOR_STATE = 2;
            timer3.Start();
            timer1.Start();
            timer2.Start();
            timer5.Start();
            timer4.Start();
            Events("Arrived at the Ground Floor");
            pictureBox6.Image = Properties.Resources.ruga;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            int leftLimit = 80;   // The left boundary
            int rightLimit = 230; // The right boundary
            {
                // Always move to the left if the timer is active
                if (pictureBox1.Left >= leftLimit)
                {
                    // Stop when reaching the left boundary
                    timer6.Stop();
                    // timer7.Stop();
                }
                else
                {
                    // Continue moving to the left
                    pictureBox1.Left += 5;
                }

            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {

            int leftLimit = 233;  // The left boundary
            int rightLimit = 400; // The right boundary

            // Always move to the right if the timer is active
            if (pictureBox2.Right >= rightLimit)
            {
                // Stop when reaching the right boundary
                timer7.Stop();
            }
            else
            {
                // Continue moving to the right
                pictureBox2.Left += 5;
            }

        }


        private void timer8_Tick(object sender, EventArgs e)
        {
            int leftLimit = 233;  // The left boundary
            int rightLimit = 400; // The right boundary

            if (Global.DOOR_STATE == 1)
            {
                // Moving to the right
                if (pictureBox2.Right >= rightLimit)
                {
                    // Stop when reaching the right boundary
                    timer8.Stop();
                }
                else
                {
                    // Continue moving to the right
                    pictureBox2.Left += 5;
                }
            }


            else if (Global.DOOR_STATE == 2)
            {
                // Moving to the left
                if (pictureBox2.Left <= leftLimit)
                {
                    // Stop when reaching the left boundary
                    timer8.Stop();
                }
                else
                {
                    // Continue moving to the left
                    pictureBox2.Left -= 5;
                }
            }

        }

    }
}

