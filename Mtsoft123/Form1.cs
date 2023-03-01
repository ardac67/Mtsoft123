using ExcelDataReader;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;
using Z.Dapper.Plus;

namespace Mtsoft123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         

        }
        DataTableCollection tableCollection;
        List<Products> products = new List<Products>();
        string connectionstring = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        textBox1.Text = ofd.FileName;
                        using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                                comboBox1.Items.Clear();
                                foreach (DataTable table in tableCollection)
                                {
                                    comboBox1.Items.Add(table.TableName);
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             try {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];

                if (dt != null)
                {
                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Products products1 = new Products();
                        products1.ProductCode = dt.Rows[i]["ProductCode"].ToString();
                        products1.A1 = (double)dt.Rows[i]["A1"]; ;
                        products1.AF2 = (double)dt.Rows[i]["AF2"];
                        products1.FRC = (double)dt.Rows[i]["FRC"];
                        products1.FRC_8 = (double)dt.Rows[i]["FRC_8"];
                        products1.FRC_TEK = (double)dt.Rows[i]["FRC_TEK"];
                        products1.INS_12 = (double)dt.Rows[i]["INS_12"];
                        products1.INS_8 = (double)dt.Rows[i]["INS_8"];
                        products1.INS_KK = (double)dt.Rows[i]["INS_KK"];
                        products1.INS_PS = (double)dt.Rows[i]["INS_PS"];
                        products1.INS_TEK = (double)dt.Rows[i]["INS_TEK"];
                        products1.MBL = (double)dt.Rows[i]["MBL"];
                        products1.MBL_12 = (double)dt.Rows[i]["MBL_12"];
                        products1.MBL_8 = (double)dt.Rows[i]["MBL_8"];
                        products1.MBL_KK = (double)dt.Rows[i]["MBL_KK"];
                        products1.SF_12 = (double)dt.Rows[i]["SF_12"];
                        products1.SF = (double)dt.Rows[i]["SF"];
                        products1.SF_KK = (double)dt.Rows[i]["SF_KK"];
                        products1.SF_TEK = (double)dt.Rows[i]["SF_TEK"];

                        products.Add(products1);
                    }
                    productsBindingSource.DataSource = products;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                DapperPlusManager.Entity<Products>().Table("ztPriceListTable");
                List<Products> products = productsBindingSource.DataSource as List<Products>;
                if (products != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionstring))
                    {
                        db.BulkInsert(products);
                    }
                   
                }
                SqlConnection cnn = new SqlConnection(connectionstring);

                cnn.Open();

                SqlCommand motorrr = new SqlCommand("sp_mtPriceListINSERT",cnn);

                motorrr.Parameters.Add("@User", SqlDbType.NVarChar).Value = textBox2.Text;

                motorrr.CommandType = CommandType.StoredProcedure;

                if (textBox2.Text != "")
                {
                    if (motorrr.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Başarılı");
                    }
                    else MessageBox.Show("Hataa");
                }
                else MessageBox.Show("isim boş");

            }
            catch (SqlException ex)
            {   
                if(ex.Number==547 || ex.Number==2627)
                {
                    MessageBox.Show("Hatalı ürünler var");
                    ErrorReport();
                }
                
            }
        }
        private void ErrorReport()
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "\\HatalıKayıtlar";
                string str = AppDomain.CurrentDomain.BaseDirectory + "\\HatalıKayıtlar\\Hata Raporu_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                foreach (Products product in products)
                {
                   ErrorControl(product.ProductCode, path, str);
                   IterationError(product.ProductCode, path, str);
                }
                OpenErrorFile(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ErrorControl(string ProductCode, string path, string filepath)
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.connectionstring);
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT ItemCode FROM cdItem WHERE ItemCode=@ItemCode", connection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.Add("@ItemCode", SqlDbType.NVarChar, 60).Value = (object)ProductCode;
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (!sqlDataReader.HasRows)
                        WriteToFile(ProductCode, "Ürün kartı açılmamış!!", filepath, path);
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WriteToFile(string code, string message, string filepath, string path)
        {
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                if (!File.Exists(filepath))
                {
                    using (StreamWriter text = File.CreateText(filepath))
                        text.WriteLine(code + "------->" + message);
                }
                else
                {
                    using (StreamWriter streamWriter = File.AppendText(filepath))
                        streamWriter.WriteLine(code + "------->" + message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenErrorFile(string filepath)
        {
            try
            {
                if (!File.Exists(filepath))
                    return;
                Process process = new Process();
                process.StartInfo = new ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = filepath
                };
                process.Start();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void IterationError(string productCode, string path, string FilePath)
        {
            try
            {
                int num = 0;
                foreach (Products product in products)
                {
                    if (product.ProductCode == productCode)
                    {
                        ++num;
                        if (num >= 2)
                        {
                            this.WriteToFile(productCode, "Tekrar eden ürün", FilePath, path);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}