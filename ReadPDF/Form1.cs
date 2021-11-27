using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Forms;
using iText.Kernel.Pdf;
using iText.Forms.Fields;
using System.IO;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;

namespace ReadPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtPath.Text = Application.ExecutablePath;
            txtPath.Text = @"C:\Users\rdeva\source\repos\roddeval\MS549_Rod_DeValcourt_final_project";
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            //PdfAcroForm
            string sPath = "";
            string sSelectedPath = "";
            sPath = txtPath.Text;
            if (sPath.Length == 0)
            {
                sPath = Application.StartupPath;
            }
            if (sPath.EndsWith("\\") == false)
            {
                sPath += "\\";
            }

            folderBrowserDialog1.SelectedPath = sPath;
            DialogResult result = folderBrowserDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                sSelectedPath = folderBrowserDialog1.SelectedPath;
                if (sSelectedPath.EndsWith("\\") == false)
                {
                    sSelectedPath += "\\";
                }
                txtPath.Text = sSelectedPath;
                this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            string sPath = "";
            string sSelectedFile = "";
            string sFile = "";
            int nStartAt = 0;
            sPath = txtPath.Text;
            if (sPath.Length > 0)
            {
                this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
                if (sPath.EndsWith("\\") == false)
                {
                    sPath += "\\";
                }
                openFileDialog1.Filter = "PDF Files|*.pdf|Text Files|*.txt|All Files|*.*";
                openFileDialog1.DefaultExt = "*.pdf";
                openFileDialog1.InitialDirectory = sPath;
                openFileDialog1.FileName = "";
                DialogResult result = openFileDialog1.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    sSelectedFile = openFileDialog1.FileName;
                    nStartAt = sPath.Length;
                    sFile = sSelectedFile.Substring(nStartAt);
                    txtFile.Text = sFile;
                }
            }
        }

        private string GetFormFieldNames(PdfAcroForm pdfAcroForm)
        {
            return string.Join("\r\n", pdfAcroForm.GetFormFields()
                                           .Select(x => x.Key).ToArray());
        }

        private string GetFormFieldNamesWithValues(PdfAcroForm pdfAcroForm)
        {

            return string.Join("\r\n", pdfAcroForm.GetFormFields()
                                           .Select(x => x.Key + "=" +
                                            pdfAcroForm.GetField(x.Key))
                                           .ToArray());
        }

        private void ProcessForm(PdfAcroForm pdfAcroForm)
        {
            IDictionary<string, PdfFormField> fields = null;
            PdfFormField item = null;
            PdfString pdfString = null;
            PdfName pdfName = null;
            PdfIndirectReference pdfIndirectReference = null;
            string value = "";
            Type type = null;
            string value2 = "";
            string messageText = "";
            StringBuilder stringBuilder = null;
            byte ot = 0;
            if (pdfAcroForm != null)
            {
                fields = pdfAcroForm.GetFormFields();
                if (fields != null)
                {
                    stringBuilder = new StringBuilder();
                    foreach (string key in fields.Keys)
                    {
                        fields.TryGetValue(key,out item);
                        if (item != null)
                        {

                            messageText = string.Format("key: {0}\r\nValue: {1}\r\n", key, item.GetValueAsString());
                            stringBuilder.Append(messageText);
                            stringBuilder.Append("\r\n");
                            Debug.WriteLine(messageText);

                            pdfString = item.GetAlternativeName();
                            if (pdfString != null)
                            {
                                value = pdfString.GetValue();
                                messageText = string.Format("item: pdfString.GetAlternativeName: {0}\r\n", value);
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                Debug.WriteLine(messageText);
                            }

                            pdfName = item.GetFormType();
                            if (pdfName != null)
                            {
                                value = pdfName.GetValue();
                                messageText = string.Format("item: pdfName.GetValue: {0}\r\n", value);
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                Debug.WriteLine(messageText);

                                type = pdfName.GetType();
                                messageText = string.Format("item: pdfName.GetType: {0}\r\n", type.ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                Debug.WriteLine(messageText);

                                ot = pdfName.GetObjectType();
                                value2 = ot.ToString();
                                messageText = string.Format("item: pdfName.GetObjectType: {0}\r\n", value2);
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                Debug.WriteLine(messageText);
                                                                
                                pdfIndirectReference = pdfName.GetIndirectReference();

                                if (pdfIndirectReference != null)
                                {
                                    messageText = string.Format("pdfIndirectReference.IsArray : {0}", pdfIndirectReference.IsArray().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsBoolean : {0}", pdfIndirectReference.IsBoolean().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsDictionary : {0}", pdfIndirectReference.IsDictionary().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsFlushed : {0}", pdfIndirectReference.IsFlushed().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsIndirect : {0}", pdfIndirectReference.IsIndirect().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsIndirectReference : {0}", pdfIndirectReference.IsIndirectReference().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsLiteral : {0}", pdfIndirectReference.IsLiteral().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsModified : {0}", pdfIndirectReference.IsModified().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsName : {0}", pdfIndirectReference.IsName().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsNull : {0}", pdfIndirectReference.IsNull().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsNumber : {0}", pdfIndirectReference.IsNumber().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsReleaseForbidden : {0}", pdfIndirectReference.IsReleaseForbidden().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsStream : {0}", pdfIndirectReference.IsStream().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                    messageText = string.Format("pdfIndirectReference.IsString : {0}", pdfIndirectReference.IsString().ToString());
                                    stringBuilder.Append(messageText);
                                    stringBuilder.Append("\r\n");
                                }

                                messageText = string.Format("pdfName.IsArray : {0}", pdfName.IsArray().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsBoolean : {0}", pdfName.IsBoolean().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsDictionary : {0}", pdfName.IsDictionary().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsFlushed : {0}", pdfName.IsFlushed().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsIndirect : {0}", pdfName.IsIndirect().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsIndirectReference : {0}", pdfName.IsIndirectReference().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsLiteral : {0}", pdfName.IsLiteral().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsModified : {0}", pdfName.IsModified().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsName : {0}", pdfName.IsName().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsNull : {0}", pdfName.IsNull().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsNumber : {0}", pdfName.IsNumber().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsReleaseForbidden : {0}", pdfName.IsReleaseForbidden().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsStream : {0}", pdfName.IsStream().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");
                                messageText = string.Format("pdfName.IsString : {0}", pdfName.IsString().ToString());
                                stringBuilder.Append(messageText);
                                stringBuilder.Append("\r\n");

                            }




                            messageText = "----------\r\n";
                            stringBuilder.Append(messageText);

                            Debug.WriteLine(messageText);

                        }
                    }

                    messageText = stringBuilder.ToString();
                    txtInformation2.Text = messageText;
                }
            }
        }

        private void ProcessFile(string sPath, string sFile)
        {

            string sPathFile = "";
            iText.Kernel.Pdf.PdfReader pdfReader = null;
            iText.Kernel.Pdf.PdfDocument pdfDocument = null;
            PdfAcroForm pdfAcroForm = null;
            string messageText = "";
            StringBuilder stringBuilder = null;

            sPathFile = sPath;
            if (sPathFile.EndsWith("\\") == false)
            {
                sPathFile += "\\";
            }
            sPathFile += sFile;

            if (File.Exists(sPathFile) == true)
            {
                stringBuilder = new StringBuilder();

                pdfReader = new PdfReader(sPathFile);

                pdfDocument = new PdfDocument(pdfReader);

                pdfAcroForm = PdfAcroForm.GetAcroForm(pdfDocument, false);

                if (pdfAcroForm != null)
                {

                    messageText = GetFormFieldNamesWithValues(pdfAcroForm);

                    stringBuilder.Append(messageText);
                    stringBuilder.Append("\r\n----------\r\n");
                    messageText = stringBuilder.ToString();
                    txtInformation.Text = messageText;

                    ProcessForm(pdfAcroForm);

               }
                pdfDocument.Close();
                pdfReader.Close();

            }


        }

        private void ProcessTextFile(string sPath, string sFile)
        {
            string sPathFile = "";
            iText.Kernel.Pdf.PdfReader pdfReader = null;
            iText.Kernel.Pdf.PdfDocument pdfDocument = null;
            ITextExtractionStrategy strategy = null;
            string pageContent = "";
            string messageText = "";
            StringBuilder stringBuilder = null;

            sPathFile = sPath;
            if (sPathFile.EndsWith("\\") == false)
            {
                sPathFile += "\\";
            }
            sPathFile += sFile;

            if (File.Exists(sPathFile) == true)
            {
                stringBuilder = new StringBuilder();

                pdfReader = new PdfReader(sPathFile);

                pdfDocument = new PdfDocument(pdfReader);

                for (int page = 1; page <= pdfDocument.GetNumberOfPages(); page++)
                {
                    strategy = new SimpleTextExtractionStrategy();
                    pageContent = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(page), strategy);
                    messageText = string.Format("Page: {0}\r\n", page);
                    stringBuilder.Append(messageText);
                    stringBuilder.Append(pageContent);
                    stringBuilder.Append("\r\n----------\r\n");
                }
                messageText = stringBuilder.ToString();
                txtInformation.Text = messageText;

                pdfDocument.Close();
                pdfReader.Close();
            }

        }

        private void btnProcessFile_Click(object sender, EventArgs e)
        {
            //PdfAcroForm
            string sPath = "";
            string sFile = "";
            StringBuilder stringBuilder = null;
            string messageText = "";
            Exception exceptionDetails = null;
            bool readText = chkProcessText.Checked;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                sPath = txtPath.Text;
                sFile = txtFile.Text;

                if ((string.IsNullOrEmpty(sPath) == false) &&
                    (string.IsNullOrEmpty(sFile) == false))
                {
                    txtInformation.Text = "";
                    txtInformation2.Text = "";
                    if (readText == false)
                        ProcessFile(sPath, sFile);
                    else
                        ProcessTextFile(sPath, sFile);
                }
                else
                {
                    messageText = "Please provide a path/filename before pressing Process File!";
                    MessageBox.Show(messageText, "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine(messageText);
                }

            }
            catch (Exception exception)
            {
                stringBuilder = new StringBuilder();
                exceptionDetails = exception;

                while (exceptionDetails != null)
                {

                    messageText = "\r\nMessage: " + exceptionDetails.Message + "\r\nSource: " + exceptionDetails.Source + "\r\nStack Trace: " + exceptionDetails.StackTrace + "\r\n----------\r\n";

                    stringBuilder.Append(messageText);

                    exceptionDetails = exceptionDetails.InnerException;

                }

                messageText = stringBuilder.ToString();
                Debug.WriteLine(messageText);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
