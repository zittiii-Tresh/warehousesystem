﻿using System;
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
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSpellChecker.Parser;
using warehousesystem.GlobalConnection;

namespace warehousesystem.Forms
{
    public partial class InventoryForm : DevExpress.XtraEditors.XtraUserControl
    {
        private static string GlobalConnection = ConnectionString.ConnString;

        public InventoryForm()
        {
            InitializeComponent();
            LoadCategoriesIntoLookUpEdit();
            //LoadAisleIntoLookUpEdit();
            //LoadContainerIntoLookUpEdit();
            //LoadShelfIntoLookUpEdit();
            dateLabel.Text = DateTime.Now.ToLongDateString();
            FilterAllProducts();
            LoadLocations();
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
            using (var connection = new SqlConnection(ConnectionString.ConnString))
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

        public List<Model.ProductLocation.AisleLocation> GetDistinctAisles()
        {
            using (var connection = new SqlConnection(GlobalConnection))
            {
                connection.Open();
                string query = @"
            SELECT DISTINCT LEFT(LocationCode, CHARINDEX('-', LocationCode) - 1) AS Aisle
            FROM pro.ProductLocations
            WHERE Availability = 'Available';";
                return connection.Query<Model.ProductLocation.AisleLocation>(query).ToList();
            }
        }

        //private void LoadAisleIntoLookUpEdit()
        //{
        //    var aisles = GetDistinctAisles();
        //    if (aisles.Any())
        //    {
        //        aisleLUE.Properties.DataSource = aisles;
        //        aisleLUE.Properties.ValueMember = "Aisle";
        //        aisleLUE.Properties.DisplayMember = "Aisle";
        //    }
        //}

        //public List<Model.ProductLocation.AisleLocation> AisleLocation()
        //{
        //    using (var connection = new SqlConnection(GlobalConnection))
        //    {
        //        connection.Open();

        //        string query = @"SELECT Aisle FROM dbo.AisleLocation;";

        //        return connection.Query<Model.ProductLocation.AisleLocation>(query).ToList();
        //    }
        //}

        //private void LoadAisleIntoLookUpEdit()
        //{
        //    var aisle = AisleLocation();
        //    if (aisle.Any())
        //    {
        //        aisleLUE.Properties.DataSource = aisle;
        //        aisleLUE.Properties.DisplayMember = "Aisle";
        //        aisleLUE.Properties.ValueMember = "Aisle";
        //    }
        //}

        public List<Model.ProductLocation.ContainerLocation> GetDistinctContainers()
        {
            using (var connection = new SqlConnection(GlobalConnection))
            {
                connection.Open();
                string query = @"
            SELECT Container
            FROM (
                SELECT 
                    SUBSTRING(
                        LocationCode, 
                        CHARINDEX('-', LocationCode) + 1, 
                        CHARINDEX('-', LocationCode, CHARINDEX('-', LocationCode) + 1) - CHARINDEX('-', LocationCode) - 1
                    ) AS Container
                FROM pro.ProductLocations
                WHERE Availability = 'Available'
            ) AS ContainerParts
            
            GROUP BY Container
            ORDER BY TRY_CAST(Container AS INT);";

                return connection.Query<Model.ProductLocation.ContainerLocation>(query).ToList();
            }
        }

        //private void LoadContainerIntoLookUpEdit()
        //{
        //    var containers = GetDistinctContainers();
        //    if (containers.Any())
        //    {
        //        containerLUE.Properties.DataSource = containers;
        //        containerLUE.Properties.DisplayMember = "Container";
        //        containerLUE.Properties.ValueMember = "Container";
        //    }
        //}

        //public List<Model.ProductLocation.ContainerLocation> ContainerLocation()
        //{
        //    using (var connection = new SqlConnection(GlobalConnection))
        //    {
        //        connection.Open();

        //        string query = @"SELECT Container FROM dbo.ContainerLocation;";

        //        return connection.Query<Model.ProductLocation.ContainerLocation>(query).ToList();
        //    }
        //}

        //private void LoadContainerIntoLookUpEdit()
        //{
        //    var container = ContainerLocation();
        //    if (container.Any())
        //    {
        //        containerLUE.Properties.DataSource = container;
        //        containerLUE.Properties.DisplayMember = "Container";
        //        containerLUE.Properties.ValueMember = "Container";
        //    }
        //}

        public List<Model.ProductLocation.ShelfLocation> GetDistinctShelves()
        {
            using (var connection = new SqlConnection(GlobalConnection))
            {
                connection.Open();
                string query = @"
            SELECT Shelf
            FROM (
                SELECT 
                    RIGHT(LocationCode, CHARINDEX('-', REVERSE(LocationCode)) - 1) AS Shelf
                FROM pro.ProductLocations
                WHERE Availability = 'Available'
            ) AS ShelfParts
            
            GROUP BY Shelf
            ORDER BY TRY_CAST(Shelf AS INT);";
                return connection.Query<Model.ProductLocation.ShelfLocation>(query).ToList();
            }
        }

        //private void LoadShelfIntoLookUpEdit()
        //{
        //    var shelves = GetDistinctShelves();
        //    if (shelves.Any())
        //    {
        //        shelfLUE.Properties.DataSource = shelves;
        //        shelfLUE.Properties.DisplayMember = "Shelf";
        //        shelfLUE.Properties.ValueMember = "Shelf";
        //    }
        //}

        //public List<Model.ProductLocation.ShelfLocation> ShelfLocation()
        //{
        //    using (var connection = new SqlConnection(GlobalConnection))
        //    {
        //        connection.Open();

        //        string query = @"SELECT Shelf FROM dbo.ShelfLocation;";

        //        return connection.Query<Model.ProductLocation.ShelfLocation>(query).ToList();
        //    }
        //}
        //private void LoadShelfIntoLookUpEdit()
        //{
        //    var shelf = ShelfLocation();
        //    if (shelf.Any())
        //    {
        //        shelfLUE.Properties.DataSource = shelf;
        //        shelfLUE.Properties.DisplayMember = "Shelf";
        //        shelfLUE.Properties.ValueMember = "Shelf";
        //    }
        //}

        private void addBTN_Click(object sender, EventArgs e)
        {
            if (IsProductIdExist(productidTE.Text))
            {
                XtraMessageBox.Show("ProductID already exists. Please use a unique ProductID.", "Duplicate ProductID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Model.Product products = new Model.Product
            {
                ProductID = productidTE.Text,
                ProductName = productnameTE.Text,
                CategoryID = Convert.ToInt32(producttypeLUE.EditValue),
                StockQuantity = Convert.ToInt32(stocksTE.Text),
                LowStockLevel = Convert.ToInt32(lowstocklevelTE.Text),
                ProductPrice = Convert.ToDouble(productpriceTE.Text),
                SupplierName = suppliernameTE.Text,
                SupplierNo = suppliernoTE.Text,
                QuantityPerShelf = Convert.ToInt32(quantitypershelfTE.Text) // ✅ NEW: include in model
            };

            RegisterProductDetail(products); // 🔁 Accepts only 'products' now
            RegisterProductLocation(products); // 🔁 Uses stored procedure to assign shelf slots

            XtraMessageBox.Show("Product Added Successfully!");
            gcProducts.DataSource = FilterAllProducts();
            gcProductLocation.RefreshDataSource();

            // ✅ Clear inputs
            productidTE.Text = string.Empty;
            productnameTE.Text = string.Empty;
            stocksTE.Text = string.Empty;
            lowstocklevelTE.Text = string.Empty;
            productpriceTE.Text = string.Empty;
            suppliernameTE.Text = string.Empty;
            suppliernoTE.Text = string.Empty;
            quantitypershelfTE.Text = string.Empty;

            producttypeLUE.EditValue = null;
            producttypeLUE.Text = string.Empty;
        }

        private static void RegisterProductDetail(Model.Product products)
        {
            using (var connection = new SqlConnection(GlobalConnection))
            {
                connection.Open();

                string stockStatus;
                if (products.StockQuantity == 0)
                {
                    stockStatus = "Out of Stock";
                }
                else if (products.StockQuantity > products.LowStockLevel)
                {
                    stockStatus = "In Stock";
                }
                else 
                {
                    stockStatus = "Low Stock";
                }

                // Insert product info
                var insertProductQuery = @"
            INSERT INTO pro.Product (
                ProductID, 
                ProductName, 
                CategoryID, 
                StockQuantity,
                QuantityPerShelf,
                StockStatus, 
                LowStockLevel, 
                ProductPrice, 
                SupplierName,
                SupplierNo)
            VALUES (
                @ProductID, 
                @ProductName, 
                @CategoryID, 
                @StockQuantity,
                @QuantityPerShelf,
                @StockStatus, 
                @LowStockLevel, 
                @ProductPrice, 
                @SupplierName, 
                @SupplierNo)";

                var insertParams = new
                {
                    products.ProductID,
                    products.ProductName,
                    products.CategoryID,
                    products.StockQuantity,
                    products.QuantityPerShelf,
                    StockStatus = stockStatus,
                    products.LowStockLevel,
                    products.ProductPrice,
                    products.SupplierName,
                    products.SupplierNo
                };

                connection.Execute(insertProductQuery, insertParams);
            }
        }


        private static void RegisterProductLocation(Model.Product products)
        {
            using (var connection = new SqlConnection(GlobalConnection))
            {
                connection.Open();

                var parameters = new
                {
                    ProductID = products.ProductID,
                    QuantityPerShelf = products.QuantityPerShelf,
                    StockQuantity = products.StockQuantity
                };

                connection.Execute("pro.InsertProductIntoLocations", parameters, commandType: CommandType.StoredProcedure);
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
            //aisleLUE.Text = string.Empty;
            //containerLUE.Text = string.Empty;
            //shelfLUE.Text = string.Empty;
        }

        private DataTable FilterAllProducts()
        {
            using (SqlConnection connection = new SqlConnection(GlobalConnection))
            {
                connection.Open();
                string query = @"SELECT p.ProductID,
                    p.ProductName,
                    pc.CategoryName,
                    STRING_AGG(pl.LocationCode, ', ') AS LocationCode,
                    p.LowStockLevel,
                    p.StockQuantity,
                    p.QuantityPerShelf,
                    p.StockStatus,
                    p.ProductPrice,
                    p.SupplierName,
                    p.SupplierNo
                FROM pro.Product p
                LEFT JOIN pro.ProductCategory pc
                ON pc.CategoryID = p.CategoryID
                LEFT JOIN pro.ProductLocations pl
                ON pl.ProductID = p.ProductID
                GROUP BY p.ProductID, p.ProductName, pc.CategoryName, p.LowStockLevel,
                    p.StockQuantity, p.StockStatus, p.ProductPrice, p.SupplierName, p.SupplierNo, p.QuantityPerShelf
                ORDER BY 
                CASE 
                    WHEN p.StockStatus = 'Out of Stock' THEN 0
                    WHEN p.StockStatus = 'Low Stock' THEN 1
                    WHEN p.StockStatus = 'In Stock' THEN 2
                    ELSE 3
                END";
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
            quantitypershelfTE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("QuantityPerShelf"));
            lowstocklevelTE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("LowStockLevel"));
            productpriceTE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("ProductPrice"));
            suppliernameTE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("SupplierName"));
            suppliernoTE.Text = Convert.ToString(gvProducts.GetFocusedRowCellValue("SupplierNo"));

            string locationCode = Convert.ToString(gvProducts.GetFocusedRowCellValue("LocationCode"));
            var parts = locationCode.Split('-');
            if (parts.Length == 3)
            {
                //aisleLUE.Text = parts[0];
                //containerLUE.Text = parts[1];
                //shelfLUE.Text = parts[2];
            }

        }

        public bool Update(string productID, string productName, int categoryID, int stocks, int quantitypershelf, int lowStocklevel, double productPrice, string supplierName, string supplierNo)
        {
            using (var connection = new SqlConnection(GlobalConnection))
            {
                connection.Open();
                var parameters = new
                {
                    ProductID = productID,
                    ProductName = productName,
                    CategoryID = categoryID,
                    StockQuantity = stocks,
                    QuantityPerShelf = quantitypershelf,
                    LowStockLevel = lowStocklevel,
                    ProductPrice = productPrice,
                    SupplierName = supplierName,
                    SupplierNo = supplierNo
                    //LocationID = locationID
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
            int quantitypershelf = Convert.ToInt32(quantitypershelfTE.Text);
            int lowStocklevel = Convert.ToInt32(lowstocklevelTE.Text);
            double productPrice = Convert.ToDouble(productpriceTE.Text);
            string supplierName = suppliernameTE.Text;
            string supplierNo = suppliernoTE.Text;

            bool isUpdated = Update(productID, productName, categoryID, stocks, quantitypershelf, lowStocklevel, productPrice, supplierName, supplierNo);

            if (isUpdated)
            {
                gcProducts.DataSource = FilterAllProducts();
                gvProducts.RefreshData();    
                gvProducts.Invalidate();     
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

                using (var connection = new SqlConnection(GlobalConnection))
                {
                    connection.Open();

                    string deleteLocation = "DELETE FROM pro.ProductLocation WHERE ProductID = @ProductID";
                    string deleteProduct = "DELETE FROM pro.Product WHERE ProductID = @ProductID";

                    connection.Execute(deleteLocation, new { ProductID = deleteId });
                    connection.Execute(deleteProduct, new { ProductID = deleteId });

                    XtraMessageBox.Show("Product successfully deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                gcProducts.DataSource = FilterAllProducts();
                gvProducts.RefreshData();
                gvProducts.Invalidate(); 
            }
            else
            {
                XtraMessageBox.Show("Delete action canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvProducts_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string stockStatus = view.GetRowCellValue(e.RowHandle, "StockStatus").ToString();

                if (stockStatus == "In Stock")
                {
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.ForeColor = Color.Black;
                }
                else if (stockStatus == "Low Stock")
                {
                    e.Appearance.BackColor = Color.Orange;
                    e.Appearance.ForeColor = Color.Black;
                }
                else if (stockStatus == "Out of Stock")
                {
                    e.Appearance.BackColor = Color.IndianRed;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }
        private bool IsProductIdExist(string productId)
        {
            using (var connection = new SqlConnection(GlobalConnection))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM pro.Product WHERE ProductID = @ProductID";

                int count = connection.ExecuteScalar<int>(query, new { ProductID = productId });

                return count > 0;
            }
        }

        private DataTable LoadLocations()
        {
            using (SqlConnection connection = new SqlConnection(GlobalConnection))
            {
                connection.Open();
                string query = @"EXEC RetrieveProductLocations";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        gcProductLocation.DataSource = dataTable;
                        return dataTable;
                    }
                }
            }
        }

      
    }
}

