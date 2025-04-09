using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DevExpress.XtraEditors;
using DevExpress.XtraSpellChecker.Parser;

namespace warehousesystem.Forms
{
    public partial class InventoryForm : DevExpress.XtraEditors.XtraUserControl
    {
        private static string connectionString = @"Data Source = LAPTOP-FC9GSM04\SQLEXPRESS;Initial Catalog = SmartWareHouseDB;Integrated Security = True;";
        internal MainForm MdiParent;

        public InventoryForm()
        {
            InitializeComponent();
            LoadCategoriesIntoLookUpEdit();
            LoadAisleIntoLookUpEdit();
            LoadContainerIntoLookUpEdit();
            LoadShelfIntoLookUpEdit();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            FilterAllProducts();
        }

        private void producttypeaddBTN_Click(object sender, EventArgs e)
        {
            Forms.ProductTypeForm productTypeForm = new Forms.ProductTypeForm();
            productTypeForm.CategoryAdded += (s, args) => LoadCategoriesIntoLookUpEdit();
            productTypeForm.ShowDialog();
            RefreshLookupEdit();
        }

        public List<Model.Category> Category()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT CategoryID, CategoryName FROM pro.ProductCategory;";

                return connection.Query<Model.Category>(query).ToList();
            }
        }

        private void LoadCategoriesIntoLookUpEdit()
        {
            var categories = Category();
            if (categories.Any())
            {
                producttypeLUE.Properties.DataSource = categories;
                producttypeLUE.Properties.DisplayMember = "CategoryName";
                producttypeLUE.Properties.ValueMember = "CategoryID";
            }  
        }

        private void RefreshLookupEdit()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(RefreshLookupEdit));
                return;
            }

            LoadCategoriesIntoLookUpEdit();

            producttypeLUE.Properties.ForceInitialize();
            producttypeLUE.RefreshEditValue();
        }

        public List<Model.ProductLocation.AisleLocation> AisleLocation()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT Aisle FROM dbo.AisleLocation;";

                return connection.Query<Model.ProductLocation.AisleLocation>(query).ToList();
            }
        }

        private void LoadAisleIntoLookUpEdit()
        {
            var aisle = AisleLocation();
            if (aisle.Any())
            {
                aisleLUE.Properties.DataSource = aisle;
                aisleLUE.Properties.DisplayMember = "Aisle";
                aisleLUE.Properties.ValueMember = "Aisle";
            }
        }

        public List<Model.ProductLocation.ContainerLocation> ContainerLocation()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT Container FROM dbo.ContainerLocation;";

                return connection.Query<Model.ProductLocation.ContainerLocation>(query).ToList();
            }
        }

        private void LoadContainerIntoLookUpEdit()
        {
            var container = ContainerLocation();
            if (container.Any())
            {
                containerLUE.Properties.DataSource = container;
                containerLUE.Properties.DisplayMember = "Container";
                containerLUE.Properties.ValueMember = "Container";
            }
        }

        public List<Model.ProductLocation.ShelfLocation> ShelfLocation()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT Shelf FROM dbo.ShelfLocation;";

                return connection.Query<Model.ProductLocation.ShelfLocation>(query).ToList();
            }
        }
        private void LoadShelfIntoLookUpEdit()
        {
            var shelf = ShelfLocation();
            if (shelf.Any())
            {
                shelfLUE.Properties.DataSource = shelf;
                shelfLUE.Properties.DisplayMember = "Shelf";
                shelfLUE.Properties.ValueMember = "Shelf";
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            Model.Product products = new Model.Product();
            products.ProductID = productidTE.Text;
            products.ProductName = productnameTE.Text;
            products.CategoryID = Convert.ToInt32(producttypeLUE.EditValue);
            products.StockQuantity = Convert.ToInt32(stocksTE.Text);
            products.LowStockLevel = Convert.ToInt32(lowstocklevelTE.Text);
            products.ProductPrice = Convert.ToDouble(productpriceTE.Text);
            products.SupplierName = suppliernameTE.Text;
            products.SupplierNo = suppliernoTE.Text;

            RegisterProductDetail(products);

            Model.ProductLocation productLocation = new Model.ProductLocation();
            productLocation.ProductID =products.ProductID;

            Model.ProductLocation.AisleLocation aisle = new Model.ProductLocation.AisleLocation();
            aisle.Aisle = aisleLUE.Text;

            Model.ProductLocation.ContainerLocation container = new Model.ProductLocation.ContainerLocation();
            container.Container = containerLUE.Text;

            Model.ProductLocation.ShelfLocation shelf = new Model.ProductLocation.ShelfLocation();
            shelf.Shelf = shelfLUE.Text;

            RegisterProductLocation(productLocation,aisle,container,shelf);
            XtraMessageBox.Show("Product Added Successfully!");

        }

        private static void RegisterProductDetail(Model.Product products)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string stockStatus;
                if (products.StockQuantity == 0)
                {
                    stockStatus = "Out of Stock";
                }
                else if (products.StockQuantity < products.LowStockLevel)
                {
                    stockStatus = "Low Stock";
                }
                else
                {
                    stockStatus = "In Stock";
                }

                var query = @"
                                INSERT INTO pro.Product (ProductID, 
                                                         ProductName, 
                                                         CategoryID, 
                                                         StockQuantity, 
                                                         StockStatus, 
                                                         LowStockLevel, 
                                                         ProductPrice, 
                                                         SupplierName,
                                                         SupplierNo)
                                VALUES (@ProductID, 
                                        @ProductName, 
                                        @CategoryID, 
                                        @StockQuantity, 
                                        @StockStatus, 
                                        @LowStockLevel, 
                                        @ProductPrice, 
                                        @SupplierName, 
                                        @SupplierNo)";
                var parameters = new
                {
                    products.ProductID,
                    products.ProductName,
                    products.CategoryID,
                    products.StockQuantity,
                    StockStatus = stockStatus, 
                    products.LowStockLevel,
                    products.ProductPrice,
                    products.SupplierName,
                    products.SupplierNo
                };

                int rowsAffected = connection.Execute(query, parameters);
            }
        }

        private static void RegisterProductLocation(Model.ProductLocation location, Model.ProductLocation.AisleLocation aisle, Model.ProductLocation.ContainerLocation container, Model.ProductLocation.ShelfLocation shelf)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string locationID = $"{aisle.Aisle}.{container.Container}.{shelf.Shelf}";

                var query = @"
                                INSERT INTO pro.ProductLocation (ProductID, LocationID)
                                VALUES (@ProductID, @LocationID)";

                var parameters = new
                {
                    location.ProductID,
                    LocationID = locationID
                };

                int rowsAffected = connection.Execute(query, parameters);
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            productidTE.Text = string.Empty;
            productnameTE.Text = string.Empty;
            producttypeLUE.Text = string.Empty;
            stocksTE.Text = string.Empty;
            lowstocklevelTE.Text = string.Empty;
            productpriceTE.Text = string.Empty;
            suppliernameTE.Text = string.Empty;
            suppliernoTE.Text = string.Empty;
            aisleLUE.Text = string.Empty;
            containerLUE.Text = string.Empty;
            shelfLUE.Text = string.Empty;
        }

        private DataTable FilterAllProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT p.ProductID,
	                               p.ProductName,
	                               pc.CategoryName,
	                               pl.LocationID,
                                   p.LowStockLevel,
	                               p.StockQuantity,
	                               p.StockStatus,
	                               p.ProductPrice,
	                               p.SupplierName,
	                               p.SupplierNo
	   
                            FROM pro.Product p
                            LEFT JOIN pro.ProductCategory pc
                            ON pc.CategoryID = p.CategoryID
                            LEFT JOIN pro.ProductLocation pl
                            ON pl.ProductID = p.ProductID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        gcProducts.DataSource = dataTable;
                        return dataTable;
                    }
                }
            }
        }

        private void gvProducts_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string productID = (Convert.ToString(gvProducts.GetFocusedRowCellValue("ProductID")));
            productidTE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("ProductID"));
            productnameTE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("ProductName"));
            producttypeLUE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("CategoryName"));
            stocksTE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("StockQuantity"));
            lowstocklevelTE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("LowStockLevel"));
            productpriceTE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("ProductPrice"));
            suppliernameTE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("SupplierName"));
            suppliernoTE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("SupplierNo"));

            string locationID = Convert.ToString(gvProducts.GetFocusedRowCellValue("LocationID"));
            var parts = locationID.Split('.');
            if (parts.Length == 3)
            {
                aisleLUE.Text = parts[0];
                containerLUE.Text = parts[1];
                shelfLUE.Text = parts[2];
            }

        }

        public bool Update(string productID, string productName, int categoryID, int stocks, int lowStocklevel, double productPrice, string supplierName, string supplierNo, string locationID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var parameters = new
                {
                    ProductID = productID,
                    ProductName = productName,
                    CategoryID = categoryID,
                    StockQuantity = stocks,
                    LowStockLevel = lowStocklevel,
                    ProductPrice = productPrice,
                    SupplierName = supplierName,
                    SupplierNo = supplierNo,
                    LocationID = locationID
                };

                int rowsAffected = connection.Execute("UpdateProduct", parameters, commandType: CommandType.StoredProcedure);
                return rowsAffected > 0;
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            string productID = (string)gvProducts.GetFocusedRowCellValue("ProductID");
            string productName = productnameTE.Text;
            int categoryID = Convert.ToInt32(producttypeLUE.EditValue);
            int stocks = Convert.ToInt32(stocksTE.Text);
            int lowStocklevel = Convert.ToInt32(lowstocklevelTE.Text);
            double productPrice = Convert.ToDouble(productpriceTE.Text);
            string supplierName = suppliernameTE.Text;
            string supplierNo = suppliernoTE.Text;

            string locationID = $"{aisleLUE.Text}.{containerLUE.Text}.{shelfLUE.Text}";

            bool isUpdated = Update(productID, productName, categoryID, stocks, lowStocklevel, productPrice, supplierName, supplierNo, locationID);

            if (isUpdated)
            {
                gcProducts.DataSource = FilterAllProducts();
                XtraMessageBox.Show("Product Successfully Updated!");
            }
            else
            {
                XtraMessageBox.Show("No products were updated.");
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show(
             "Are you sure you want to delete this product?",
             "Confirm Delete",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
             );

            if (dialogResult == DialogResult.Yes)
            {
                string deleteId = (string)gvProducts.GetFocusedRowCellValue("ProductID");

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteLocation = "DELETE FROM pro.ProductLocation WHERE ProductID = @ProductID";
                    string deleteProduct = "DELETE FROM pro.Product WHERE ProductID = @ProductID";

                    connection.Execute(deleteLocation, new { ProductID = deleteId });
                    connection.Execute(deleteProduct, new { ProductID = deleteId });

                    XtraMessageBox.Show("Product successfully deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                gcProducts.DataSource = FilterAllProducts();
            }
            else
            {
                XtraMessageBox.Show("Delete action canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

