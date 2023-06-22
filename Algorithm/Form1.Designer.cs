namespace Algorithm
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.sortInput = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.importCsv = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mergeSortStack = new System.Windows.Forms.RadioButton();
            this.linearSearchStack = new System.Windows.Forms.RadioButton();
            this.bubbleSort = new System.Windows.Forms.RadioButton();
            this.binarySearch = new System.Windows.Forms.RadioButton();
            this.insertionSortStack = new System.Windows.Forms.RadioButton();
            this.traversePreOrder = new System.Windows.Forms.RadioButton();
            this.traversePostOrder = new System.Windows.Forms.RadioButton();
            this.traverseInOrder = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.recursiveSearch = new System.Windows.Forms.RadioButton();
            this.RemoveTreeNode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 20F);
            this.label5.Location = new System.Drawing.Point(373, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 34);
            this.label5.TabIndex = 33;
            this.label5.Text = "Program";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Field To sort/remove/search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Item To Search/Remove";
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(789, 294);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(100, 25);
            this.searchInput.TabIndex = 30;
            // 
            // sortInput
            // 
            this.sortInput.FormattingEnabled = true;
            this.sortInput.Location = new System.Drawing.Point(789, 325);
            this.sortInput.Name = "sortInput";
            this.sortInput.Size = new System.Drawing.Size(121, 23);
            this.sortInput.TabIndex = 29;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(68, 317);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(453, 98);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 151);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(453, 114);
            this.dataGridView1.TabIndex = 25;
            // 
            // importCsv
            // 
            this.importCsv.Location = new System.Drawing.Point(68, 16);
            this.importCsv.Margin = new System.Windows.Forms.Padding(2);
            this.importCsv.Name = "importCsv";
            this.importCsv.Size = new System.Drawing.Size(145, 107);
            this.importCsv.TabIndex = 24;
            this.importCsv.Text = "import csv";
            this.importCsv.UseVisualStyleBackColor = true;
            this.importCsv.Click += new System.EventHandler(this.importCsv_Click);
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(749, 365);
            this.executeButton.Margin = new System.Windows.Forms.Padding(2);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(143, 50);
            this.executeButton.TabIndex = 23;
            this.executeButton.Text = "Search/Sort";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Source data ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "LinkedList";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Stack";
            // 
            // mergeSortStack
            // 
            this.mergeSortStack.AutoSize = true;
            this.mergeSortStack.Location = new System.Drawing.Point(735, 76);
            this.mergeSortStack.Margin = new System.Windows.Forms.Padding(2);
            this.mergeSortStack.Name = "mergeSortStack";
            this.mergeSortStack.Size = new System.Drawing.Size(108, 19);
            this.mergeSortStack.TabIndex = 27;
            this.mergeSortStack.TabStop = true;
            this.mergeSortStack.Text = "Merge Sort";
            this.mergeSortStack.UseVisualStyleBackColor = true;
            // 
            // linearSearchStack
            // 
            this.linearSearchStack.AutoSize = true;
            this.linearSearchStack.Location = new System.Drawing.Point(735, 99);
            this.linearSearchStack.Margin = new System.Windows.Forms.Padding(2);
            this.linearSearchStack.Name = "linearSearchStack";
            this.linearSearchStack.Size = new System.Drawing.Size(132, 19);
            this.linearSearchStack.TabIndex = 28;
            this.linearSearchStack.TabStop = true;
            this.linearSearchStack.Text = "Linear Search";
            this.linearSearchStack.UseVisualStyleBackColor = true;
            // 
            // bubbleSort
            // 
            this.bubbleSort.AutoSize = true;
            this.bubbleSort.Location = new System.Drawing.Point(735, 16);
            this.bubbleSort.Margin = new System.Windows.Forms.Padding(2);
            this.bubbleSort.Name = "bubbleSort";
            this.bubbleSort.Size = new System.Drawing.Size(116, 19);
            this.bubbleSort.TabIndex = 28;
            this.bubbleSort.TabStop = true;
            this.bubbleSort.Text = "Bubble Sort";
            this.bubbleSort.UseVisualStyleBackColor = true;
            // 
            // binarySearch
            // 
            this.binarySearch.AutoSize = true;
            this.binarySearch.Location = new System.Drawing.Point(735, 41);
            this.binarySearch.Margin = new System.Windows.Forms.Padding(2);
            this.binarySearch.Name = "binarySearch";
            this.binarySearch.Size = new System.Drawing.Size(132, 19);
            this.binarySearch.TabIndex = 27;
            this.binarySearch.TabStop = true;
            this.binarySearch.Text = "Binary Search";
            this.binarySearch.UseVisualStyleBackColor = true;
            // 
            // insertionSortStack
            // 
            this.insertionSortStack.AutoSize = true;
            this.insertionSortStack.Location = new System.Drawing.Point(735, 122);
            this.insertionSortStack.Margin = new System.Windows.Forms.Padding(2);
            this.insertionSortStack.Name = "insertionSortStack";
            this.insertionSortStack.Size = new System.Drawing.Size(140, 19);
            this.insertionSortStack.TabIndex = 41;
            this.insertionSortStack.TabStop = true;
            this.insertionSortStack.Text = "Insertion Sort";
            this.insertionSortStack.UseVisualStyleBackColor = true;
            // 
            // traversePreOrder
            // 
            this.traversePreOrder.AutoSize = true;
            this.traversePreOrder.Location = new System.Drawing.Point(735, 208);
            this.traversePreOrder.Margin = new System.Windows.Forms.Padding(2);
            this.traversePreOrder.Name = "traversePreOrder";
            this.traversePreOrder.Size = new System.Drawing.Size(156, 19);
            this.traversePreOrder.TabIndex = 45;
            this.traversePreOrder.TabStop = true;
            this.traversePreOrder.Text = "TraversePreOrder";
            this.traversePreOrder.UseVisualStyleBackColor = true;
            // 
            // traversePostOrder
            // 
            this.traversePostOrder.AutoSize = true;
            this.traversePostOrder.Location = new System.Drawing.Point(735, 162);
            this.traversePostOrder.Margin = new System.Windows.Forms.Padding(2);
            this.traversePostOrder.Name = "traversePostOrder";
            this.traversePostOrder.Size = new System.Drawing.Size(164, 19);
            this.traversePostOrder.TabIndex = 42;
            this.traversePostOrder.TabStop = true;
            this.traversePostOrder.Text = "TraversePostOrder";
            this.traversePostOrder.UseVisualStyleBackColor = true;
            // 
            // traverseInOrder
            // 
            this.traverseInOrder.AutoSize = true;
            this.traverseInOrder.Location = new System.Drawing.Point(735, 185);
            this.traverseInOrder.Margin = new System.Windows.Forms.Padding(2);
            this.traverseInOrder.Name = "traverseInOrder";
            this.traverseInOrder.Size = new System.Drawing.Size(148, 19);
            this.traverseInOrder.TabIndex = 43;
            this.traverseInOrder.TabStop = true;
            this.traverseInOrder.Text = "TraverseInOrder";
            this.traverseInOrder.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "BinaryTree";
            // 
            // recursiveSearch
            // 
            this.recursiveSearch.AutoSize = true;
            this.recursiveSearch.Location = new System.Drawing.Point(735, 231);
            this.recursiveSearch.Margin = new System.Windows.Forms.Padding(2);
            this.recursiveSearch.Name = "recursiveSearch";
            this.recursiveSearch.Size = new System.Drawing.Size(156, 19);
            this.recursiveSearch.TabIndex = 46;
            this.recursiveSearch.TabStop = true;
            this.recursiveSearch.Text = "Recursive Search";
            this.recursiveSearch.UseVisualStyleBackColor = true;
            // 
            // RemoveTreeNode
            // 
            this.RemoveTreeNode.Location = new System.Drawing.Point(595, 365);
            this.RemoveTreeNode.Name = "RemoveTreeNode";
            this.RemoveTreeNode.Size = new System.Drawing.Size(148, 50);
            this.RemoveTreeNode.TabIndex = 48;
            this.RemoveTreeNode.Text = "Remove Node From Tree";
            this.RemoveTreeNode.UseVisualStyleBackColor = true;
            this.RemoveTreeNode.Click += new System.EventHandler(this.removeTreeNode_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 434);
            this.Controls.Add(this.RemoveTreeNode);
            this.Controls.Add(this.recursiveSearch);
            this.Controls.Add(this.traversePreOrder);
            this.Controls.Add(this.traversePostOrder);
            this.Controls.Add(this.traverseInOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.insertionSortStack);
            this.Controls.Add(this.binarySearch);
            this.Controls.Add(this.mergeSortStack);
            this.Controls.Add(this.bubbleSort);
            this.Controls.Add(this.linearSearchStack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.sortInput);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.importCsv);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.ComboBox sortInput;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button importCsv;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton mergeSortStack;
        private System.Windows.Forms.RadioButton linearSearchStack;
        private System.Windows.Forms.RadioButton bubbleSort;
        private System.Windows.Forms.RadioButton binarySearch;
        private System.Windows.Forms.RadioButton insertionSortStack;
        private System.Windows.Forms.RadioButton traversePreOrder;
        private System.Windows.Forms.RadioButton traversePostOrder;
        private System.Windows.Forms.RadioButton traverseInOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton recursiveSearch;
        private System.Windows.Forms.Button RemoveTreeNode;
    }
}

