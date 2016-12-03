using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JSONToSPParameters
{
    public partial class frmJSONConversion : Form
    {

        public frmJSONConversion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnConvert control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                //Check whether the user has entered any data in to the required fields or not before start processing the data.
                if (ValidationCheck())
                {
                    StringBuilder formattedData = new StringBuilder();
                    formattedData.Append("use t1c;\n");
                    formattedData.Append("exec ");
                    formattedData.Append(txtStoredProcName.Text.Trim());
                    bool parameterNameFound = false;
                    //Looping through the raw json text area.
                    foreach (string lineData in rtbRawJSON.Lines)
                    {
                        if ((lineData.Contains("@") || lineData.Contains("\"Name\"")) && lineData.Contains(":"))
                        {
                            string parameterName = lineData.Split(':').ElementAt(1).Replace("\"", "").Replace("@", "").Replace(",", "").Trim();
                            //Adding parameter name
                            if (!string.IsNullOrEmpty(parameterName))
                            {
                                parameterNameFound = true;
                                formattedData.Append("\n@");
                                formattedData.Append(parameterName);
                            }
                        }
                        else if (parameterNameFound)
                        {
                            parameterNameFound = false;
                            if (!string.IsNullOrEmpty(lineData.Trim()))
                            {
                                string parameterValue = lineData.Split(':').ElementAt(1).Trim();
                                //If the parameter value is of type ignore parameter, then don't include these parameter name and value in the list.
                                if (parameterValue.Contains("Ignored Parameter"))
                                {
                                    //Remove the added parameter name in the above step.
                                    formattedData.Remove(formattedData.ToString().LastIndexOf("\n@"), formattedData.Length - formattedData.ToString().LastIndexOf("\n@"));
                                }
                                else
                                {
                                    long convertedValue;
                                    bool result = Int64.TryParse(parameterValue, out convertedValue);
                                    //For Text values.
                                    if (!result)
                                    {
                                        formattedData.Append(ProcessTextData(parameterValue));
                                    }
                                    else
                                    {
                                        //For numeric values.
                                        formattedData.Append("=");
                                        formattedData.Append(convertedValue);
                                    }
                                    formattedData.Append(",");
                                }
                            }
                        }
                    }
                    //Copy the final formatted parameters data in to converted text area.
                    string[] convertedLinesCount = formattedData.ToString().Substring(0, formattedData.ToString().Length - 1).Split('\n');
                    if (convertedLinesCount.Length == 2)
                    {
                        InValidData("");
                    }
                    else
                    {
                        rtbConvertedData.Text = formattedData.ToString().Substring(0, formattedData.ToString().Length - 1);
                        rtbConvertedData.Enabled = true;
                        rtbConvertedData.Focus();
                        rtbConvertedData.SelectAll();
                        rtbConvertedData.ReadOnly = true;
                        MessageBox.Show("Press Ctrl + C to copy the formatted Stored Procedure parameters.", "Conversion done successfully, Copy Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception exp)
            {

                InValidData(exp.Message, true);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnClear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear all the fields and disable the converted text area.
            ClearFields("");
        }

        /// <summary>
        /// Handles the Click event of the btnExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmJSONConversion.ActiveForm.Close();
        }

        #region Validation Logic methods

        /// <summary>
        /// Processes the text data.
        /// </summary>
        /// <param name="parameterValue">The parameter value.</param>
        /// <returns></returns>
        private string ProcessTextData(string parameterValue)
        {
            //If the parameter value is of type true or false, replace it with 1 or 0.
            parameterValue = parameterValue.Replace("\"", "").Trim();
            StringBuilder textValues = new StringBuilder();
            if (string.Compare(parameterValue, Boolean.TrueString, true) == 0)
            {
                textValues.Append("=");
                textValues.Append(1);
            }
            else if (string.Compare(parameterValue, Boolean.FalseString, true) == 0)
            {
                textValues.Append("=");
                textValues.Append(0);
            }
            else
            {
                //For text value include the data in single quotes.
                textValues.Append("='");
                textValues.Append(parameterValue);
                textValues.Append("'");
            }
            return textValues.ToString();
        }

        /// <summary>
        /// Validations the check.
        /// </summary>
        private Boolean ValidationCheck()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txtStoredProcName.Text.Trim()))
            {
                MessageBox.Show("Please enter a stored procedure name.\n\nFollowing are the steps to use this application.\n\nStep1: Enter the stored procedure name in the above text box.\n\nStep2: Copy and paste the Raw JSON data from the logs application in the below left side text area.\n\nNOTE:You can also use Keyboard short cuts ALT+C to start Conversion and ALT+L to Clear the data, ALT+X to Close the application.", "Stored Procedure Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields("textbox", false);
                isValid = false;
            }
            else if (string.IsNullOrEmpty(rtbRawJSON.Text.Trim()))
            {
                MessageBox.Show("Please copy and paste the raw json data from logs.", "Raw JSON Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields("rawtextarea", false);
                isValid = false;
            }
            return isValid;
        }

        /// <summary>
        /// Ins the valid data.
        /// </summary>
        /// <param name="exceptionMessage">The exception message.</param>
        /// <param name="isException">if set to <c>true</c> [is exception].</param>
        private void InValidData(string exceptionMessage, bool isException = false)
        {
            if (isException)
            {
                string formattedMessage = "An error occured while parsing the JSON data, please cross check.\nErrorMessage:" + exceptionMessage;
                MessageBox.Show(formattedMessage);
            }
            else
            {
                MessageBox.Show("It seems that you have not properly copy pasted the raw json data. \t\t\tPlease cross check", "In Proper JSON data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields("rawtextarea", false);
            }
        }


        /// <summary>
        /// Clears the fields.
        /// </summary>
        /// <param name="controlNameToSetFocus">The control name to set focus.</param>
        /// <param name="allFields">if set to <c>true</c> [all fields].</param>
        private void ClearFields(string controlNameToSetFocus, bool allFields = true)
        {
            if (allFields)
            {
                txtStoredProcName.Text = "";
                rtbRawJSON.Text = "";
                txtStoredProcName.Focus();
            }
            if (controlNameToSetFocus == "textbox")
            {
                txtStoredProcName.Focus();
                txtStoredProcName.SelectAll();
            }
            else if (controlNameToSetFocus == "rawtextarea")
            {
                rtbRawJSON.Focus();
                rtbRawJSON.SelectAll();
            }
            rtbConvertedData.Clear();
            rtbConvertedData.Enabled = false;
        }

        #endregion


    }
}
