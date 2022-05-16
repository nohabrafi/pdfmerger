using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using Microsoft.WindowsAPICodePack.Dialogs;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.list_box.DragDrop += new DragEventHandler(listBox1_DragDrop);
        
            this.list_box.DragEnter += new DragEventHandler(listBox1_DragEnter);
     
        }

        List<string> addedFileList = new List<string>();

        private void logMessage(string message)
        {
            string messageToPrint = String.Format(">>{0}<< {1}", DateTime.Now, message) + Environment.NewLine;
            log_box.AppendText(messageToPrint);
            Console.WriteLine(messageToPrint);
            // auto scroll to the end
            log_box.SelectionStart = log_box.Text.Length;
            log_box.ScrollToCaret();
        }


        private void addList_BoxItemsAndLog(string[] files)
        {
            for (int i = 0; i < files.Length; i++)
            {
                addedFileList.Add(files[i]);
                logMessage(Path.GetFileName(files[i]) + " added!");
                list_box.Items.Add(Path.GetFileName(files[i]));
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            addList_BoxItemsAndLog(files);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logMessage("Welcome!");
            destination_box.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if(addedFileList.Count < 1)
            {
                logMessage("There are no PDFs to process!");
                return;
            }
            if(string.IsNullOrWhiteSpace(destination_box.Text))
            {
                logMessage("No destination selected!");
                return;
            }
            MergePDFs(destination_box.Text.ToString(), progress_bar, filename_box.Text.ToString(), logMessage, addedFileList.ToArray());
        }

        
        public static void MergePDFs(string targetPath, ProgressBar progressBar, string filename, Action<string> logMessage, params string[] pdfs)
        {
            if(filename == "")
            {
                filename = "yourMergedPdf";
            }

            string fullPath = targetPath + "\\" + filename + ".pdf";

            // merging pdfs by pages
            using (var targetDoc = new PdfDocument())
            {
                foreach (var pdf in pdfs)
                {
                    using (var pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                    {
                        for (var i = 0; i < pdfDoc.PageCount; i++)
                            targetDoc.AddPage(pdfDoc.Pages[i]);
                    }
                }
                // exception handling
                try
                {   
                    progressBar.Value = 0;
                    logMessage("Trying to save PDF....");
                    targetDoc.Save(fullPath);
                    if (File.Exists(fullPath))
                    {
                        logMessage("Merged PDF file created. Full path: " + fullPath + "!");
                        progressBar.Value = 100;
                    }
                    else
                    {
                        progressBar.Value = 0;
                        logMessage("Something went wrong...");
                    }
                }
                catch (InvalidOperationException exception)
                {
                    logMessage(exception.Message);
                }
            }
        }

        private void browse_files_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.InitialDirectory = "C:\\";
            openfiledialog.Multiselect = true;
            openfiledialog.Title = "Pls select PDFs only";
            openfiledialog.Filter = "pdf | *.pdf";
            openfiledialog.ShowDialog();
            if (openfiledialog.FileName != "")
            {
                addedFileList.Clear();
                list_box.Items.Clear();
                addList_BoxItemsAndLog(openfiledialog.FileNames);
            }
        }

        private void delete_all_Click(object sender, EventArgs e)
        {
            if (list_box.Items.Count < 1)
            {
                logMessage("PDF field is empty!");
            }
            else
            {
                addedFileList.Clear();
                list_box.Items.Clear();
                logMessage("PDF field cleared!");
            }
        }

        private void delete_selected_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(list_box);
            selectedItems = list_box.SelectedItems;
            if (list_box.Items.Count < 1)
            {
                logMessage("PDF field is empty!");
            }
            else
            {
                if (list_box.SelectedIndex != -1)
                {
                    List<string> removedFileNames = new List<string>();

                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        // remove from addedFileList too
                        addedFileList.RemoveAll(x => x.Contains("\\" + selectedItems[i].ToString()));
                        removedFileNames.Add(selectedItems[i].ToString());
                        list_box.Items.Remove(selectedItems[i]);
                    }
                    /*
                    logMessage("items in adddedFileList: ");
                    foreach (string item in addedFileList)
                    {
                        logMessage(item);
                    }
                    logMessage(addedFileList.Count.ToString());
                    */
                    if (list_box.Items.Count < 1)
                    {
                        logMessage(String.Join(", ", removedFileNames) + " removed!");
                        logMessage("PDF field is empty!");
                    }
                    else
                    {
                        logMessage(String.Join(", ", removedFileNames) + " removed!");
                    }
                }
                else
                {
                    logMessage("Pls select something");
                }
            }
        }

        private void whatsdis_Click(object sender, EventArgs e)
        {
            logMessage("This is a tool for merging PDF files into one single PDF file.");
        }

        private void destination_select_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                destination_box.Text = dialog.FileName;
            }
        }

        private void select_src_folder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                // get all pdf files from directory
                string[] files = Directory.GetFiles(dialog.FileName, "*.pdf");

                if (files.Length > 0)
                {
                    addList_BoxItemsAndLog(files);
                }
                else
                {
                    logMessage("No pdfs there!");
                }
            }
        }
    }
}
