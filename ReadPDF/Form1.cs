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
            txtPath.Text = Application.ExecutablePath;
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
            string value = "";
            Type type = null;
            string value2 = "";
            if (pdfAcroForm != null)
            {
                fields = pdfAcroForm.GetFormFields();
                if (fields != null)
                {
                    foreach (string key in fields.Keys)
                    {
                        fields.TryGetValue(key,out item);
                        if (item != null)
                        {
                            Debug.WriteLine(string.Format("key: {0}\r\nValue: {1}\r\n",key,item.GetValueAsString()));

                            pdfName= item.GetFormType();
                            if (pdfName != null)
                            {
                                value = pdfName.GetValue();
                                Debug.WriteLine(string.Format("item: pdfName.GetFormType: {0}\r\n", value));

                                type = pdfName.GetType();
                                Debug.WriteLine(string.Format("item: pdfName.GetType: {0}\r\n", type.ToString()));

                                value2 = pdfName.GetValue();
                                Debug.WriteLine(string.Format("item: pdfName.GetValue: {0}\r\n", value2));
                                
                                pdfName.GetObjectType();
                            }

                            pdfString = item.GetAlternativeName();
                            if (pdfString != null)
                            {
                                value = pdfString.GetValue();
                                Debug.WriteLine(string.Format("item: pdfString.GetAlternativeName: {0}\r\n", value));
                            }

                            

                            Debug.WriteLine("----------\r\n");

                        }
                    }
                }
            }
        }

        private void ProcessFile(string sPath, string sFile)
        {

            string sPathFile = "";
            iText.Kernel.Pdf.PdfReader pdfReader = null;
            iText.Kernel.Pdf.PdfDocument pdfDocument = null;
            PdfAcroForm pdfAcroForm = null;
            iText.Forms.Fields.PdfFormField pdfFormField = null;
            PdfString pdfString = null;
            PdfString pdfString2 = null;
            IDictionary<string, iText.Forms.Fields.PdfFormField> fields = null;
            string sValue = "";
            string sValue2 = "";
            string key = "";
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

                    //fields = pdfAcroForm.GetFormFields();

                    //if (fields.Count > 0)
                    //{

                    //    foreach (KeyValuePair<string, iText.Forms.Fields.PdfFormField> keyValue in fields)
                    //    {

                    //        key = keyValue.Key;
                    //        pdfFormField = keyValue.Value;

                    //        if (pdfFormField != null)
                    //        {
                    //            //messageText = string.Format("{0}: {1}\r\n", key, pdfFormField.GetFieldName().ToString());
                    //            //stringBuilder.Append(messageText);

                    //            //pdfString = pdfFormField.GetFieldName();
                    //            //sValue = (pdfString != null) ? pdfString.GetValue() : "";

                    //            //pdfString2 = pdfFormField.GetMappingName();
                    //            //sValue2 = (pdfString2 != null) ? pdfString2.GetValue() : "";

                    //            //messageText = string.Format("Field Name {0}\r\nMapping Name: {1}\r\n----------\r\n", sValue, sValue2);

                    //        }

                    //    }
                    //    messageText = stringBuilder.ToString();
                    //    txtInformation.Text = messageText;

                    //}
                }

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
            try
            {
                this.Cursor = Cursors.WaitCursor;
                sPath = txtPath.Text;
                sFile = txtFile.Text;

                if ((string.IsNullOrEmpty(sPath) == false) &&
                    (string.IsNullOrEmpty(sFile) == false))
                {
                    txtInformation.Text = "";
                    ProcessFile(sPath, sFile);
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
