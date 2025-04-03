﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
    }
}
