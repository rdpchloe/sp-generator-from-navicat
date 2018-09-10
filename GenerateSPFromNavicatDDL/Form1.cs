using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateSPFromNavicatDDL
{
    public partial class Form1 : Form
    {

        List<TableData> tableData = new List<TableData>();
        string tableName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateInsert_Click(object sender, EventArgs e)
        {
            if (tfInsert.Text == "")
                return;

            ResetAll();
            tableData = GenerateTableData(tfInsert.Text);
            GetTableName();
            GenerateTableGrid();
            GenerateSP(true);
        }

        private void GenerateSP(bool isInsert)
        {
            string resultParam = "";
            string resultParamCI = "";
            string spType = "INSERT INTO ";
            if (!isInsert)
                spType = "UPDATE ";
            
            tfResult.AppendText(spType + tableName);
            tfResult.AppendText(Environment.NewLine);
            tfResult.AppendText("SET\n");

            for (int i = 0; i < tableData.Count; i++)
            {
                string endCode = ",";
                if (i == (tableData.Count - 1))
                    endCode = ";";
                tfResult.AppendText("\t " + tableData[i].fieldName + " = p_" + tableData[i].fieldName + endCode + "\n");
            }

            for (int i = 0; i < tableData.Count; i++)
            {
                string paramSpe = "";
                if (tableData[i].fieldLength != "")
                    paramSpe = "(" + tableData[i].fieldLength + ")";

                string paramSeparator = ", ";
                if (i == (tableData.Count - 1))
                    paramSeparator = "";
                resultParam += "IN `p_" + tableData[i].fieldName + "` " + tableData[i].fieldType + paramSpe + paramSeparator;
                resultParamCI += "$" + tableData[i].fieldName + paramSeparator;
            }

            tfResultParameter.Text = resultParam;
            tfResultVariableCI.Text = resultParamCI;
        }

        private void ResetAll()
        {
            dgTableData.Rows.Clear();
            tableData.Clear();
            tableName = "";
            tfResult.Clear();
            tfResultParameter.Clear();
            tfResultVariableCI.Clear();
        }

        private void GetTableName()
        {
            var pattern = @"\`(.*?)\`";
            var matches = Regex.Matches(tfInsert.Text, pattern);
            tableName = matches[0].Value.Replace("`", "");
        }

        private void GenerateTableGrid()
        {
            for (int i = 0; i < tableData.Count; i++)
            {
                dgTableData.Rows.Add(tableData[i].fieldName, tableData[i].fieldType, tableData[i].fieldLength);
            }
        }

        private static List<TableData> GenerateTableData(string query)
        {
            string source = GetValueBetweenChar("(", ")", query);
            string[] arrSource = source.Split(',');
            List<TableData> tableData = new List<TableData>();
            for (int i = 0; i < arrSource.Count(); i++)
            {
                string tableFieldRaw = arrSource[i].Trim();
                var pattern = @"\`(.*?)\`";
                var matches = Regex.Matches(tableFieldRaw, pattern);
                string strFieldNameRaw = matches[0].Value;
                string strFieldName = strFieldNameRaw.Replace("`", "");
                tableFieldRaw = tableFieldRaw.Replace(strFieldNameRaw, "").Trim();

                //Get Field Type
                string[] arrFieldType = tableFieldRaw.Split(' ');
                string strFieldTypeRaw = arrFieldType[0];
                int parenthPos = strFieldTypeRaw.IndexOf("(");
                string strFieldLength = "";
                string strFieldType = strFieldTypeRaw;
                if (parenthPos != -1)
                {
                    strFieldType = strFieldTypeRaw.Remove(parenthPos, (strFieldTypeRaw.Length - parenthPos));

                    //Get Field Length
                    strFieldLength = GetValueBetweenChar("(", ")", strFieldTypeRaw);
                }

                //Insert Into Object
                TableData tableDataObj = new TableData
                {
                    fieldName = strFieldName,
                    fieldType = strFieldType,
                    fieldLength = strFieldLength
                };

                tableData.Add(tableDataObj);
            }

            return tableData;
        }

        public static string ReplaceLastOccurrence(string Source, string Find, string Replace, bool isLast)
        {
            int place = Source.IndexOf(Find);
            if (isLast)
                place = Source.LastIndexOf(Find);

            if (place == -1)
                return "";

            string result = Source.Remove(place, Find.Length).Insert(place, Replace);
            return result;
        }

        private static string GetValueBetweenChar(string firstString, string lastString, string source)
        {
            int firstStringPos = source.IndexOf(firstString);
            int lastStringPos = source.LastIndexOf(lastString);
            int sourceLen = source.Length;

            string result = source.Remove(lastStringPos, (sourceLen - lastStringPos));
            result = result.Remove(0, (firstStringPos + 1));
            result = result.Replace("\r\n", "").Trim();

            return result;
        }

        private void btnGenerateUpdate_Click(object sender, EventArgs e)
        {
            if (tfInsert.Text == "")
                return;

            ResetAll();
            tableData = GenerateTableData(tfInsert.Text);
            GetTableName();
            GenerateTableGrid();
            GenerateSP(false);
        }

        private void dgTableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class TableData
    {
        public string fieldName { get; set; }
        public string fieldType { get; set; }
        public string fieldLength { get; set; }
    }
}
