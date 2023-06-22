using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Algorithm
{
    public partial class Main : Form               
    {
        private List<String> comboBoxList;
        private CsvClass csvClass;
        private TheLinkedList<CsvClass> csvList; 
       
        public Main()
        {
            InitializeComponent();
            comboBoxList = new List<String>();
            csvList = new TheLinkedList<CsvClass> ();
        }

        private void updateSortComboBox()
        {
            sortInput.Items.Clear(); // Clear the comboBox

            foreach (var item in comboBoxList) // Iterate through the Column in csv and store the colum name in combobox
            {
                sortInput.Items.Add(item); 
            }
        }

        private void importCsv_Click(object sender, EventArgs e)
        {
            // Opening a dialog file to select the csv file to work with
            FileDialog fileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv"
            };

            if (fileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                DataTable dataAvailable = new DataTable();
                try
                {
                    using (StreamReader streamReader = new StreamReader(fileDialog.FileName))
                    {
                        // Will tell if it is the first row
                        bool firstRow = true;
                        //TheLinkedList<CsvClass> newLinkedList = new TheLinkedList<CsvClass>();
                        while (!streamReader.EndOfStream)
                        {
                            string line = streamReader.ReadLine();
                            string[] lineElements = line.Split(',');

                            if (firstRow)
                            {
                                // The first row defines the column names
                                foreach (string title in lineElements)
                                {
                                    dataAvailable.Columns.Add(title);
                                    comboBoxList.Add(title);
                                }

                                firstRow = false;
                            }
                            else
                            {
                                // Adding values to the DataTable
                                dataAvailable.Rows.Add(lineElements);
                                convertDataIntoClass(lineElements[0], Int32.Parse(lineElements[1]));
                            }
                        }

                        dataGridView1.DataSource = dataAvailable;
                        updateSortComboBox();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("You have to select a valid file!");
            }
        }
        
        public void convertDataIntoClass(string element1, int element2)
        {
            csvClass = new CsvClass(element1, element2);
            csvList.AddFirst(csvClass);
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (sortInput.SelectedItem != null)
            {
                richTextBox1.Clear();


                string compareType = sortInput.SelectedItem.ToString();
                string itemToSearch = null;

                if (searchInput.Text != null && searchInput.Text.Length > 0)
                {
                    itemToSearch = searchInput.Text;
                }
               
                if (binarySearch.Checked) 
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder(); 
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        int searchResult = csvList.binarySearch(itemToSearch, compareType);

                        stopwatch.Stop();

                        long elapsedTicks = stopwatch.ElapsedTicks;
                        double ticksPerNanosecond = Stopwatch.Frequency / 1_000_000_000.0;
                        double elapsedNanoseconds = elapsedTicks / ticksPerNanosecond;
                    

                        sb.Append("Index: " + searchResult.ToString());
                        sb.AppendLine();
                        sb.Append("IntValue: " + csvList.findNodeByIndex(searchResult).Data.IntValue.ToString());
                        sb.AppendLine();
                        sb.Append(richTextBox1.Text += "StringValue: " + csvList.findNodeByIndex(searchResult).Data.StringValue);
                        sb.AppendLine();
                        sb.Append("List: ");
                        sb.AppendLine();
                        sb.Append("Time Spent: " + elapsedNanoseconds);
                        sb.AppendLine();
                        richTextBox1.Text = sb.ToString();
                        foreach (CsvClass csvClass in csvList)
                        {
                            richTextBox1.Text += csvClass.StringValue + ", ";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                if (bubbleSort.Checked)
                {
                    try
                    {
                     
                        StringBuilder sb = new StringBuilder(); //Declear the stringBuilder to store output string
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        TheLinkedList<CsvClass> listSorted = csvList.bubbleSort(compareType);

                        stopwatch.Stop();

                        long elapsedTicks = stopwatch.ElapsedTicks;
                        double ticksPerNanosecond = Stopwatch.Frequency / 1_000_000_000.0;
                        double elapsedNanoseconds = elapsedTicks / ticksPerNanosecond;

                        foreach (CsvClass csvClass in listSorted)
                        {
                            sb.Append(csvClass.StringValue + ", ");
                        }
                        sb.AppendLine();
                        sb.Append("Time Spent: " + elapsedNanoseconds);
                        richTextBox1.Text = sb.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                
                if (mergeSortStack.Checked) 
                {
                    try
                    {
                        Stack<CsvClass> newStack = makeStack(csvList);
                        StringBuilder sb = new StringBuilder(); 
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        newStack.mergeSort(compareType);

                        stopwatch.Stop();

                        long elapsedTicks = stopwatch.ElapsedTicks;
                        double ticksPerNanosecond = Stopwatch.Frequency / 1_000_000_000.0;
                        double elapsedNanoseconds = elapsedTicks / ticksPerNanosecond;
                     
                        foreach (CsvClass csvClass in newStack)
                        {
                            sb.Append(csvClass.StringValue + ", ");                         
                        }
                        sb.AppendLine();
                        sb.Append("Time Spent: " + elapsedNanoseconds);
                        richTextBox1.Text = sb.ToString();
                    }                  
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                if (insertionSortStack.Checked) // Check if BinaryButton is checked
                {
                    try
                    {
                        Stack<CsvClass> newStack = makeStack(csvList);
                   
                        StringBuilder sb = new StringBuilder(); //string will be appended later
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        var stackSorted = newStack.insertionSort(compareType);

                        stopwatch.Stop();

                        long elapsedTicks = stopwatch.ElapsedTicks;
                        double ticksPerNanosecond = Stopwatch.Frequency / 1_000_000_000.0;
                        double elapsedNanoseconds = elapsedTicks / ticksPerNanosecond;

                        foreach (CsvClass csvClass in stackSorted)
                        {
                            sb.Append(csvClass.StringValue + ", ");
                        }

                        sb.AppendLine();
                        sb.Append("Time Spent: " + elapsedNanoseconds);
                        richTextBox1.Text = sb.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (linearSearchStack.Checked) // Check if BinaryButton is checked
                {
                    
                    try
                    {
                        Stack<CsvClass> newStack = makeStack(csvList);
                        StringBuilder sb = new StringBuilder(); //string will be appended later
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        CsvClass data = newStack.linearSearch(itemToSearch, compareType).Data;

                        stopwatch.Stop();
                        long elapsedTicks = stopwatch.ElapsedTicks;
                        double ticksPerNanosecond = Stopwatch.Frequency / 1_000_000_000.0;
                        double elapsedNanoseconds = elapsedTicks / ticksPerNanosecond;
                      
                        sb.Append("StringValue: " + data.StringValue);
                        sb.AppendLine();
                        sb.Append("IntValue: " + data.IntValue.ToString());
                        sb.AppendLine();
                        sb.Append("Time Spent: " + elapsedNanoseconds);
                        sb.AppendLine();
                        richTextBox1.Text = sb.ToString();

                        foreach (CsvClass csvClass in newStack)
                        {
                            //Console.WriteLine(csvClass.IntValue + " ");
                            richTextBox1.Text += csvClass.StringValue + ", ";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (traversePreOrder.Checked) // Check if BinaryButton is checked
                {
                    try
                    {
                        BinaryTree<CsvClass> newTree = makeTree(csvList, compareType);
                        newTree.traverseResult.Clear();
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        newTree.TraversePreOrder(newTree.Root);
                        stopwatch.Stop();
                        long elapsedTicks = stopwatch.ElapsedTicks;
                        double ticksPerNanosecond = Stopwatch.Frequency / 1_000_000_000.0;
                        double elapsedNanoseconds = elapsedTicks / ticksPerNanosecond;
                       
                        StringBuilder sb = new StringBuilder();
                        sb.Append("Sort by: " + compareType);
                        sb.AppendLine();
                        sb.Append("Time Spent: " + elapsedNanoseconds);
                        sb.AppendLine();
                        foreach (CsvClass csvClass in newTree.traverseResult)
                        {                          
                            sb.Append("IntValue: " + csvClass.IntValue + " String Value: " + csvClass.StringValue);
                            sb.AppendLine();
                        }

                        richTextBox1.Text = sb.ToString();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (traverseInOrder.Checked) // Check if BinaryButton is checked
                {
                    try
                    {
                        BinaryTree<CsvClass> newTree = makeTree(csvList, compareType);
                        newTree.traverseResult.Clear();
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        newTree.TraverseInOrder(newTree.Root);

                        stopwatch.Stop();
                        long elapsedTicks = stopwatch.ElapsedTicks;
                        double ticksPerNanosecond = Stopwatch.Frequency / 1_000_000_000.0;
                        double elapsedNanoseconds = elapsedTicks / ticksPerNanosecond;
                     
                        StringBuilder sb = new StringBuilder();
                        sb.Append("Sort by: " + compareType);
                        sb.AppendLine();
                        sb.Append("Time Spent: " + elapsedNanoseconds);
                        sb.AppendLine();
                        foreach (CsvClass csvClass in newTree.traverseResult)
                        {
                            sb.Append("IntValue: " + csvClass.IntValue + " String Value: " + csvClass.StringValue);
                            sb.AppendLine();
                        }

                        richTextBox1.Text = sb.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (traversePostOrder.Checked) // Check if BinaryButton is checked
                {
                    try
                    {
                        BinaryTree<CsvClass> newTree = makeTree(csvList, compareType);
                        newTree.traverseResult.Clear();
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        newTree.TraversePostOrder(newTree.Root);

                        stopwatch.Stop();

                        long elapsedTicks = stopwatch.ElapsedTicks;
                        double ticksPerNanosecond = Stopwatch.Frequency / 1_000_000_000.0;
                        double elapsedNanoseconds = elapsedTicks / ticksPerNanosecond;

                       
                        StringBuilder sb = new StringBuilder();
                        sb.Append("Sort by: " + compareType);
                        sb.AppendLine();
                        sb.Append("Time Spent: " + elapsedNanoseconds);
                        sb.AppendLine();
                        foreach (CsvClass csvClass in newTree.traverseResult)
                        {
                            sb.Append("IntValue: " + csvClass.IntValue + " String Value: " + csvClass.StringValue);
                            sb.AppendLine();
                        }

                        richTextBox1.Text = sb.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (recursiveSearch.Checked) // Check if BinaryButton is checked
                {
                    try
                    {
                        BinaryTree<CsvClass> newTree = makeTree(csvList, compareType);
                        StringBuilder sb = new StringBuilder(); 

                        Stopwatch stopwatch = new Stopwatch(); 
                        stopwatch.Start(); 

                        CsvClass searchResult = newTree.Find(itemToSearch, compareType).Data;

                        stopwatch.Stop();   
             
                        long elapsedTicks = stopwatch.ElapsedTicks; 
                        double ticksPerNanosecond = Stopwatch.Frequency / 1_000_000_000.0; 
                        double elapsedNanoseconds = elapsedTicks / ticksPerNanosecond; 
              
                        //int height = newTree.findHeight(newTree.Find(itemToSearch, compareType).Data.IntValue.ToString(), compareType);
                        //sb.Append("Height: " + height.ToString());
                        //sb.AppendLine();
                        sb.Append("StringValue: " + searchResult.StringValue);
                        sb.AppendLine();
                        sb.Append("IntValue: " + searchResult.IntValue.ToString());
                        sb.AppendLine();
                        sb.Append("Time Spent: " + elapsedNanoseconds.ToString());
                        richTextBox1.Text = sb.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                richTextBox1.AppendText("You have to select an algorithm.");
            }
        }
        private Stack<CsvClass> makeStack(TheLinkedList<CsvClass> list) 
        {
            Stack<CsvClass> stack = new Stack<CsvClass>(); 
            if (list == null)
            {
                MessageBox.Show("You have to import a CSV first");
            }
            else
            {
                foreach (CsvClass csvClass in list)  
                {
                    stack.Push(csvClass);
                }
            }

            return stack; 
        }

        private BinaryTree<CsvClass> makeTree(TheLinkedList<CsvClass> list, string compareType) 
        {
            BinaryTree<CsvClass> tree = new BinaryTree<CsvClass>(); // Create the object for the binary tree
            if (list == null)
            {
                MessageBox.Show("You have to import a CSV first"); // Show message box
            }
            else
            {
                foreach (CsvClass csvClass in list)  // Iterate through the linkedList passed to add items into the tree
                {
                    tree.Add(csvClass, compareType); // Add item into the tree
                }
            }
            return tree; // Return the tree created
        }

        private void removeFromTree(string compareType,string itemToBeRemoved)
        {       
            BinaryTree<CsvClass> newTree = makeTree(csvList, compareType);
            newTree.traverseResult.Clear();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            newTree.Remove(newTree.Find(itemToBeRemoved, compareType).Data, compareType);
            newTree.TraverseInOrder(newTree.Root);

            stopwatch.Stop();
            long elapsedTicks = stopwatch.ElapsedTicks;
            double ticksPerNanosecond = Stopwatch.Frequency / 1_000_000_000.0;
            double elapsedNanoseconds = elapsedTicks / ticksPerNanosecond;

            StringBuilder sb = new StringBuilder();
            sb.Append("Item Removed: " + itemToBeRemoved);
            sb.AppendLine();
            sb.Append("Sort by: " + compareType);
            sb.AppendLine();
            sb.Append("Time Spent: " + elapsedNanoseconds);
            sb.AppendLine();
        
            foreach (CsvClass csvClass in newTree.traverseResult)
            {
                sb.Append("IntValue: " + csvClass.IntValue + " String Value: " + csvClass.StringValue);
                sb.AppendLine();
            }

            richTextBox1.Text = sb.ToString();
        }

        private void removeTreeNode_Click(object sender, EventArgs e)
        {
            if(searchInput.Text != null && sortInput.SelectedItem != null)
            {
                string itemToBeRemoved = searchInput.Text;
                string compareType = sortInput.SelectedItem.ToString();
                removeFromTree(compareType, itemToBeRemoved);
            }    
        }
    }
}
