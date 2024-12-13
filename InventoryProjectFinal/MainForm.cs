using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace InventoryProjectFinal
{
    public partial class MainForm : Form
    {
        private ArrayList arrayInventoryList = new ArrayList();
        private string username { get; set; }
        private string affiliation { get; set; }
        public MainForm(string Username, string Affiliation)
        {
            InitializeComponent();
            InitializeDataGrid();
            InitializezComboBox();

            username = Username; affiliation = Affiliation;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (username.Equals("ejay", StringComparison.OrdinalIgnoreCase))
            {
                lbluserRole.Text = $"Affiliation:\n CEO";
                lbluserName.Text = $"BOSS Ejay !!!";
            }
            else
            {
                lbluserRole.Text = affiliation;
                lbluserName.Text = $"Current User:\n{username}";
            }

            // Ensure proper layout adjustments
            lbluserName.AutoSize = true;
            lbluserRole.AutoSize = true;
            lbluserName.MaximumSize = new Size(150, 0); // Adjust width as necessary
        }


        private void InitializeDataGrid()
        {
            dgInventory.Columns.Add("columnID", "ID");
            dgInventory.Columns.Add("columnName", "Product Name");
            dgInventory.Columns.Add("columnCategory", "Category");
            dgInventory.Columns.Add("columnQuantity", "Quantity");
            dgInventory.Columns.Add("columnPrice", "Price");
            dgInventory.Columns.Add("columnStatus", "Status");
        }

        private void InitializezComboBox()
        {
            cbProdCategory.Items.AddRange(new[] { "Shirts", "Pants", "Underwear", "Socks", "Shoes" });
            cbStatus.Items.AddRange(new[] { "Available", "Out of Stock" });
        }
        private void LoadInventory(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    arrayInventoryList.Clear(); // Clear the current list before loading new data
                    int maxId = 0; // Track the highest ID in the file
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 6 &&
                            int.TryParse(parts[0], out int id) &&
                            int.TryParse(parts[3], out int quantity) &&
                            double.TryParse(parts[4], out double price))
                        {
                            InventoryItems newItem = new InventoryItems(id, parts[1], parts[2], quantity, price, parts[5]);
                            arrayInventoryList.Add(newItem);
                            if (id > maxId) maxId = id;
                        }
                        else
                        {
                            ShowError("Error", "Invalid data format in file.");
                            return;
                        }
                    }

                    // Update the static ID counter to prevent duplicates
                    InventoryItems.SetCurrentID(maxId + 1);
                }
                RefreshGrid(); // Refresh the DataGridView with the loaded data
                MessageBox.Show("Inventory loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Error loading inventory", ex.Message);
            }
        }

        private void AddItemFunction(string name, string category, int quantity, double price, string status)
        {
            try
            {
                InventoryItems newItem = new InventoryItems(name, category, quantity, price, status);
                arrayInventoryList.Add(newItem);
                RefreshGrid();
            }
            catch (InvalidExpressionException ex)
            {
                ShowError("Input Error", ex.Message);
            }
            catch (ArgumentException ex)
            {
                ShowError("Invalid Input", ex.Message);
            }
            catch (Exception ex)
            {
                ShowError("An unexpected error occurred:", ex.Message);
            }
        }

        private void RefreshGrid()
        {
            dgInventory.Rows.Clear();
            foreach (InventoryItems items in arrayInventoryList)
            {
                dgInventory.Rows.Add(items.ID, items.Name, items.Category, items.Quantity, items.Price, items.Status);
            }
        }

        private void ClearInput()
        {
            txtProdName.Clear();
            cbProdCategory.SelectedIndex = -1;
            nudProdQuantity.Value = 0;
            txtProdPrice.Clear();
            cbStatus.SelectedIndex = -1;
        }

        private void ShowError(string errorTitle, string errorMessage)
        {
            MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SearchItems(string keyword)
        {
            dgInventory.Rows.Clear();
            foreach (InventoryItems items in arrayInventoryList)
            {
                if (items.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    items.Category.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    items.Status.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    dgInventory.Rows.Add(items.ID, items.Name, items.Category, items.Quantity, items.Price, items.Status);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtProdName.Text;
                string category = cbProdCategory.Text;
                int quantity = (int)nudProdQuantity.Value;
                double price = double.Parse(txtProdPrice.Text);
                string status = cbStatus.Text;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category) || quantity <= 0 || price <= 0 || string.IsNullOrEmpty(status))
                {
                    throw new InvalidExpressionException("All fields must be filled in and valid.");
                }

                AddItemFunction(name, category, quantity, price, status);
            }
            catch (FormatException)
            {
                ShowError("Input Error", "Please enter a valid number for the price and quantity.");
            }
            catch (Exception ex)
            {
                ShowError("An error occurred:", ex.Message);
            }
            ClearInput();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            SearchItems(keyword);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dgInventory.CurrentRow.Index;
                if (selectedRowIndex >= 0 && selectedRowIndex < arrayInventoryList.Count)
                {
                    InventoryItems selectedItem = (InventoryItems)arrayInventoryList[selectedRowIndex];

                    string name = txtProdName.Text;
                    string category = cbProdCategory.Text;
                    int quantity = (int)nudProdQuantity.Value;
                    double price = double.Parse(txtProdPrice.Text);
                    string status = cbStatus.Text;

                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category) || quantity <= 0 || price <= 0 || string.IsNullOrEmpty(status))
                    {
                        throw new InvalidExpressionException("All fields must be filled in and valid.");
                    }

                    selectedItem.Name = name;
                    selectedItem.Category = category;
                    selectedItem.Quantity = quantity;
                    selectedItem.Price = price;
                    selectedItem.Status = status;

                    RefreshGrid();
                }
                else
                {
                    ShowError("Update Error", "Please select an item to update.");
                }
            }
            catch (FormatException)
            {
                ShowError("Input Error", "Please enter a valid number for the price and quantity.");
            }
            catch (Exception ex)
            {
                ShowError("An error occurred:", ex.Message);
            }
            ClearInput();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "inventory.csv");
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (InventoryItems item in arrayInventoryList)
                    {
                        writer.WriteLine($"{item.ID},{item.Name},{item.Category},{item.Quantity},{item.Price},{item.Status}");
                    }
                }
                MessageBox.Show("Inventory saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Error saving inventory", ex.Message);
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadInventory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "inventory.csv"));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserVerificationForm back = new UserVerificationForm();
            MessageBox.Show("Going Back to Login", "Action done", MessageBoxButtons.OK, MessageBoxIcon.Information );
            back.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting Program","Program Terminated", MessageBoxButtons.OK, MessageBoxIcon.Stop );
            this.Close();
            
        }
    }
}
