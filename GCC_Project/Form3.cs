using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCC_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "Dashboard";
            Name = "Dashboard";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            //MANUFACTURING GOODS BUTTONS VISIBILITY....................
            ManufacturingGoodsSubMenuLable.Visible = false;
            MGViewBtn.Visible = false;
            InsertMG.Visible = false;
            EditMG.Visible = false;
            RemoveMG.Visible = false;

            //SELLING GOODS BUTTONS VISIBILITY...........................
            sellingGoodsSubMenuLabel.Visible = false;
            SGSummary.Visible = false;
            SGOrigin.Visible = false;
            SGEditInsert.Visible = false;
            SGRevenueSUmmary.Visible = false;

            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            StockAvailSubMenu.Visible = false;
            SAView.Visible = false;
            SAUsageSummary.Visible = false;
            SAUpdate.Visible = false;
            SAStockOutGoods.Visible = false;
            SAUpcomingStocks.Visible = false;

            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            VBLable.Visible = false;
            VBRegister.Visible = false;
            VBUpdateInsert.Visible = false;
            VBUpdateInsertBuyer.Visible = false;
            VBView.Visible = false;
            VBViewBuyer.Visible = false;

            //ABOUT US BUTTONS VISIBILITY...........................
            AboutUsSubMenuLable.Visible = false;
            AUApp.Visible = false;
            AUContactUs.Visible = false;
            AUDeveloper.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseMenuBtn_Click(object sender, EventArgs e)
        {
            //MANUFACTURING GOODS BUTTONS VISIBILITY....................
            ManufacturingGoodsSubMenuLable.Visible = false;
            MGViewBtn.Visible = false;
            InsertMG.Visible = false;
            EditMG.Visible = false;
            RemoveMG.Visible = false;

            //SELLING GOODS BUTTONS VISIBILITY...........................
            sellingGoodsSubMenuLabel.Visible = false;
            SGSummary.Visible = false;
            SGOrigin.Visible = false;
            SGEditInsert.Visible = false;
            SGRevenueSUmmary.Visible = false;

            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            StockAvailSubMenu.Visible = false;
            SAView.Visible = false;
            SAUsageSummary.Visible = false;
            SAUpdate.Visible = false;
            SAStockOutGoods.Visible = false;
            SAUpcomingStocks.Visible = false;

            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            VBLable.Visible = false;
            VBRegister.Visible = false;
            VBUpdateInsert.Visible = false;
            VBUpdateInsertBuyer.Visible = false;
            VBView.Visible = false;
            VBViewBuyer.Visible = false;

            //ABOUT US BUTTONS VISIBILITY...........................
            AboutUsSubMenuLable.Visible = false;
            AUApp.Visible = false;
            AUContactUs.Visible = false;
            AUDeveloper.Visible = false;
        }

        private void manufacturingGoodsBtn_Click(object sender, EventArgs e)
        {
            //MANUFACTURING GOODS BUTTONS VISIBILITY....................
            ManufacturingGoodsSubMenuLable.Visible = true;
            MGViewBtn.Visible = true;
            InsertMG.Visible = true;
            EditMG.Visible = true;
            RemoveMG.Visible = true;

            //SELLING GOODS BUTTONS VISIBILITY...........................
            sellingGoodsSubMenuLabel.Visible = false;
            SGSummary.Visible = false;
            SGOrigin.Visible = false;
            SGEditInsert.Visible = false;
            SGRevenueSUmmary.Visible = false;

            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            StockAvailSubMenu.Visible = false;
            SAView.Visible = false;
            SAUsageSummary.Visible = false;
            SAUpdate.Visible = false;
            SAStockOutGoods.Visible = false;
            SAUpcomingStocks.Visible = false;

            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            VBLable.Visible = false;
            VBRegister.Visible = false;
            VBUpdateInsert.Visible = false;
            VBUpdateInsertBuyer.Visible = false;
            VBView.Visible = false;
            VBViewBuyer.Visible = false;

            //ABOUT US BUTTONS VISIBILITY...........................
            AboutUsSubMenuLable.Visible = false;
            AUApp.Visible = false;
            AUContactUs.Visible = false;
            AUDeveloper.Visible = false;
        }

        private void SellingGoodsBtn_Click(object sender, EventArgs e)
        {
            //SELLING GOODS BUTTONS VISIBILITY...........................
            sellingGoodsSubMenuLabel.Visible = true;
            SGSummary.Visible = true;
            SGOrigin.Visible = true;
            SGEditInsert.Visible = true;
            SGRevenueSUmmary.Visible = true;

            //MANUFACTURING GOODS BUTTONS VISIBILITY....................
            ManufacturingGoodsSubMenuLable.Visible = false;
            MGViewBtn.Visible = false;
            InsertMG.Visible = false;
            EditMG.Visible = false;
            RemoveMG.Visible = false;

            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            StockAvailSubMenu.Visible = false;
            SAView.Visible = false;
            SAUsageSummary.Visible = false;
            SAUpdate.Visible = false;
            SAStockOutGoods.Visible = false;
            SAUpcomingStocks.Visible = false;

            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            VBLable.Visible = false;
            VBRegister.Visible = false;
            VBUpdateInsert.Visible = false;
            VBUpdateInsertBuyer.Visible = false;
            VBView.Visible = false;
            VBViewBuyer.Visible = false;

            //ABOUT US BUTTONS VISIBILITY...........................
            AboutUsSubMenuLable.Visible = false;
            AUApp.Visible = false;
            AUContactUs.Visible = false;
            AUDeveloper.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StockAvailBtn_Click(object sender, EventArgs e)
        {
            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            StockAvailSubMenu.Visible = true;
            SAView.Visible = true;
            SAUsageSummary.Visible = true;
            SAUpdate.Visible = true;
            SAStockOutGoods.Visible = true;
            SAUpcomingStocks.Visible = true;

            //MANUFACTURING GOODS BUTTONS VISIBILITY....................
            ManufacturingGoodsSubMenuLable.Visible = false;
            MGViewBtn.Visible = false;
            InsertMG.Visible = false;
            EditMG.Visible = false;
            RemoveMG.Visible = false;

            //SELLING GOODS BUTTONS VISIBILITY...........................
            sellingGoodsSubMenuLabel.Visible = false;
            SGSummary.Visible = false;
            SGOrigin.Visible = false;
            SGEditInsert.Visible = false;
            SGRevenueSUmmary.Visible = false;

            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            VBLable.Visible = false;
            VBRegister.Visible = false;
            VBUpdateInsert.Visible = false;
            VBUpdateInsertBuyer.Visible = false;
            VBView.Visible = false;
            VBViewBuyer.Visible = false;

            //ABOUT US BUTTONS VISIBILITY...........................
            AboutUsSubMenuLable.Visible = false;
            AUApp.Visible = false;
            AUContactUs.Visible = false;
            AUDeveloper.Visible = false;
        }

        private void VendorBuyrInfoBtn_Click(object sender, EventArgs e)
        {
            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            VBLable.Visible = true;
            VBRegister.Visible = true;
            VBUpdateInsert.Visible = true;
            VBUpdateInsertBuyer.Visible = true;
            VBView.Visible = true;
            VBViewBuyer.Visible = true;

            //MANUFACTURING GOODS BUTTONS VISIBILITY....................
            ManufacturingGoodsSubMenuLable.Visible = false;
            MGViewBtn.Visible = false;
            InsertMG.Visible = false;
            EditMG.Visible = false;
            RemoveMG.Visible = false;

            //SELLING GOODS BUTTONS VISIBILITY...........................
            sellingGoodsSubMenuLabel.Visible = false;
            SGSummary.Visible = false;
            SGOrigin.Visible = false;
            SGEditInsert.Visible = false;
            SGRevenueSUmmary.Visible = false;

            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            StockAvailSubMenu.Visible = false;
            SAView.Visible = false;
            SAUsageSummary.Visible = false;
            SAUpdate.Visible = false;
            SAStockOutGoods.Visible = false;
            SAUpcomingStocks.Visible = false;

            //ABOUT US BUTTONS VISIBILITY...........................
            AboutUsSubMenuLable.Visible = false;
            AUApp.Visible = false;
            AUContactUs.Visible = false;
            AUDeveloper.Visible = false;
        }

        private void AboutUsBtn_Click(object sender, EventArgs e)
        {
            //ABOUT US BUTTONS VISIBILITY...........................
            AboutUsSubMenuLable.Visible = true;
            AUApp.Visible = true;
            AUContactUs.Visible = true;
            AUDeveloper.Visible = true;

            //MANUFACTURING GOODS BUTTONS VISIBILITY....................
            ManufacturingGoodsSubMenuLable.Visible = false;
            MGViewBtn.Visible = false;
            InsertMG.Visible = false;
            EditMG.Visible = false;
            RemoveMG.Visible = false;

            //SELLING GOODS BUTTONS VISIBILITY...........................
            sellingGoodsSubMenuLabel.Visible = false;
            SGSummary.Visible = false;
            SGOrigin.Visible = false;
            SGEditInsert.Visible = false;
            SGRevenueSUmmary.Visible = false;

            //STOCK AVAILABILITY BUTTONS VISIBILITY...........................
            StockAvailSubMenu.Visible = false;
            SAView.Visible = false;
            SAUsageSummary.Visible = false;
            SAUpdate.Visible = false;
            SAStockOutGoods.Visible = false;
            SAUpcomingStocks.Visible = false;

            //VENDOR/BUYER INFO BUTTONS VISIBILITY...........................
            VBLable.Visible = false;
            VBRegister.Visible = false;
            VBUpdateInsert.Visible = false;
            VBUpdateInsertBuyer.Visible = false;
            VBView.Visible = false;
            VBViewBuyer.Visible = false;
        }
    }
}
