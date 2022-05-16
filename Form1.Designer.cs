namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.list_box = new System.Windows.Forms.ListBox();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.start_merging = new System.Windows.Forms.Button();
            this.delete_all = new System.Windows.Forms.Button();
            this.log_box = new System.Windows.Forms.RichTextBox();
            this.select_src_folder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.select_files = new System.Windows.Forms.Button();
            this.delete_selected = new System.Windows.Forms.Button();
            this.destination_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.whatsdis = new System.Windows.Forms.Button();
            this.destination_select = new System.Windows.Forms.Button();
            this.filename_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_box
            // 
            this.list_box.AllowDrop = true;
            this.list_box.FormattingEnabled = true;
            this.list_box.Location = new System.Drawing.Point(11, 25);
            this.list_box.Name = "list_box";
            this.list_box.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.list_box.Size = new System.Drawing.Size(617, 147);
            this.list_box.TabIndex = 0;
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(11, 384);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(90, 23);
            this.progress_bar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drag and drop PDFs here ->";
            // 
            // start_merging
            // 
            this.start_merging.BackColor = System.Drawing.Color.Transparent;
            this.start_merging.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_merging.Location = new System.Drawing.Point(513, 368);
            this.start_merging.Margin = new System.Windows.Forms.Padding(0);
            this.start_merging.Name = "start_merging";
            this.start_merging.Size = new System.Drawing.Size(115, 39);
            this.start_merging.TabIndex = 3;
            this.start_merging.Text = "Start merging";
            this.start_merging.UseVisualStyleBackColor = false;
            this.start_merging.Click += new System.EventHandler(this.start_button_Click);
            // 
            // delete_all
            // 
            this.delete_all.Location = new System.Drawing.Point(445, 178);
            this.delete_all.Name = "delete_all";
            this.delete_all.Size = new System.Drawing.Size(75, 23);
            this.delete_all.TabIndex = 4;
            this.delete_all.Text = "Remove all";
            this.delete_all.UseVisualStyleBackColor = true;
            this.delete_all.Click += new System.EventHandler(this.delete_all_Click);
            // 
            // log_box
            // 
            this.log_box.Location = new System.Drawing.Point(11, 269);
            this.log_box.Name = "log_box";
            this.log_box.ReadOnly = true;
            this.log_box.Size = new System.Drawing.Size(617, 96);
            this.log_box.TabIndex = 7;
            this.log_box.Text = "";
            // 
            // select_src_folder
            // 
            this.select_src_folder.Location = new System.Drawing.Point(11, 178);
            this.select_src_folder.Name = "select_src_folder";
            this.select_src_folder.Size = new System.Drawing.Size(98, 23);
            this.select_src_folder.TabIndex = 8;
            this.select_src_folder.Text = "Select folder";
            this.select_src_folder.UseVisualStyleBackColor = true;
            this.select_src_folder.Click += new System.EventHandler(this.select_src_folder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Logs ->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Progress ->";
            // 
            // select_files
            // 
            this.select_files.Location = new System.Drawing.Point(115, 178);
            this.select_files.Name = "select_files";
            this.select_files.Size = new System.Drawing.Size(97, 23);
            this.select_files.TabIndex = 13;
            this.select_files.Text = "Select files";
            this.select_files.UseVisualStyleBackColor = true;
            this.select_files.Click += new System.EventHandler(this.browse_files_Click);
            // 
            // delete_selected
            // 
            this.delete_selected.Location = new System.Drawing.Point(526, 178);
            this.delete_selected.Name = "delete_selected";
            this.delete_selected.Size = new System.Drawing.Size(102, 23);
            this.delete_selected.TabIndex = 14;
            this.delete_selected.Text = "Remove Selected";
            this.delete_selected.UseVisualStyleBackColor = true;
            this.delete_selected.Click += new System.EventHandler(this.delete_selected_Click);
            // 
            // destination_box
            // 
            this.destination_box.Location = new System.Drawing.Point(11, 224);
            this.destination_box.Name = "destination_box";
            this.destination_box.Size = new System.Drawing.Size(313, 20);
            this.destination_box.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Destination path ->";
            // 
            // whatsdis
            // 
            this.whatsdis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatsdis.Location = new System.Drawing.Point(218, 178);
            this.whatsdis.Name = "whatsdis";
            this.whatsdis.Size = new System.Drawing.Size(118, 40);
            this.whatsdis.TabIndex = 18;
            this.whatsdis.Text = "What is this ( help )";
            this.whatsdis.UseVisualStyleBackColor = true;
            this.whatsdis.Click += new System.EventHandler(this.whatsdis_Click);
            // 
            // destination_select
            // 
            this.destination_select.Location = new System.Drawing.Point(324, 224);
            this.destination_select.Name = "destination_select";
            this.destination_select.Size = new System.Drawing.Size(25, 20);
            this.destination_select.TabIndex = 19;
            this.destination_select.Text = "...";
            this.destination_select.UseVisualStyleBackColor = true;
            this.destination_select.Click += new System.EventHandler(this.destination_select_Click);
            // 
            // filename_box
            // 
            this.filename_box.Location = new System.Drawing.Point(374, 225);
            this.filename_box.Name = "filename_box";
            this.filename_box.Size = new System.Drawing.Size(203, 20);
            this.filename_box.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Your file name here (default: yourMergedPdf) ->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 416);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filename_box);
            this.Controls.Add(this.destination_select);
            this.Controls.Add(this.whatsdis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.destination_box);
            this.Controls.Add(this.delete_selected);
            this.Controls.Add(this.select_files);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.select_src_folder);
            this.Controls.Add(this.log_box);
            this.Controls.Add(this.delete_all);
            this.Controls.Add(this.start_merging);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.list_box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Merge PDFs for free!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_box;
        private System.Windows.Forms.ProgressBar progress_bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_merging;
        private System.Windows.Forms.Button delete_all;
        private System.Windows.Forms.Button select_src_folder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox log_box;
        private System.Windows.Forms.Button select_files;
        private System.Windows.Forms.Button delete_selected;
        private System.Windows.Forms.TextBox destination_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button whatsdis;
        private System.Windows.Forms.Button destination_select;
        private System.Windows.Forms.TextBox filename_box;
        private System.Windows.Forms.Label label5;
    }
}

