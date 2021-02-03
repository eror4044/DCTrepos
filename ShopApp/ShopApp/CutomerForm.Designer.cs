namespace ShopApp
{
    partial class CutomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Backet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addProductInBacket = new System.Windows.Forms.Button();
            this.UserNameLBL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductListDGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BacketList = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.PayMethodCB = new System.Windows.Forms.ComboBox();
            this.AddrLabel = new System.Windows.Forms.Label();
            this.deliveryAddressTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaleNameLabel = new System.Windows.Forms.Label();
            this.DeliveryCB = new System.Windows.Forms.ComboBox();
            this.SetOrder = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.Backet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Backet
            // 
            this.Backet.Controls.Add(this.tabPage1);
            this.Backet.Controls.Add(this.tabPage2);
            this.Backet.Location = new System.Drawing.Point(3, 0);
            this.Backet.Name = "Backet";
            this.Backet.SelectedIndex = 0;
            this.Backet.Size = new System.Drawing.Size(633, 404);
            this.Backet.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addProductInBacket);
            this.tabPage1.Controls.Add(this.UserNameLBL);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ProductListDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addProductInBacket
            // 
            this.addProductInBacket.Location = new System.Drawing.Point(429, 205);
            this.addProductInBacket.Name = "addProductInBacket";
            this.addProductInBacket.Size = new System.Drawing.Size(182, 48);
            this.addProductInBacket.TabIndex = 17;
            this.addProductInBacket.Text = "Добавить товар в корзину";
            this.addProductInBacket.UseVisualStyleBackColor = true;
            this.addProductInBacket.Click += new System.EventHandler(this.addProductInBasket_Click);
            // 
            // UserNameLBL
            // 
            this.UserNameLBL.AutoSize = true;
            this.UserNameLBL.Location = new System.Drawing.Point(551, 405);
            this.UserNameLBL.Name = "UserNameLBL";
            this.UserNameLBL.Size = new System.Drawing.Size(0, 13);
            this.UserNameLBL.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Список товаров";
            // 
            // ProductListDGV
            // 
            this.ProductListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListDGV.Location = new System.Drawing.Point(14, 51);
            this.ProductListDGV.MultiSelect = false;
            this.ProductListDGV.Name = "ProductListDGV";
            this.ProductListDGV.ReadOnly = true;
            this.ProductListDGV.Size = new System.Drawing.Size(603, 148);
            this.ProductListDGV.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteBTN);
            this.tabPage2.Controls.Add(this.BacketList);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.PayMethodCB);
            this.tabPage2.Controls.Add(this.AddrLabel);
            this.tabPage2.Controls.Add(this.deliveryAddressTB);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.SaleNameLabel);
            this.tabPage2.Controls.Add(this.DeliveryCB);
            this.tabPage2.Controls.Add(this.SetOrder);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Корзина";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BacketList
            // 
            this.BacketList.FullRowSelect = true;
            this.BacketList.HideSelection = false;
            this.BacketList.Location = new System.Drawing.Point(14, 50);
            this.BacketList.MultiSelect = false;
            this.BacketList.Name = "BacketList";
            this.BacketList.Size = new System.Drawing.Size(338, 152);
            this.BacketList.TabIndex = 11;
            this.BacketList.UseCompatibleStateImageBehavior = false;
            this.BacketList.View = System.Windows.Forms.View.List;
            this.BacketList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.BacketList_ItemSelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберете способ оплаты";
            // 
            // PayMethodCB
            // 
            this.PayMethodCB.FormattingEnabled = true;
            this.PayMethodCB.Items.AddRange(new object[] {
            "Наложенный платеж",
            "Наличные",
            "Картой"});
            this.PayMethodCB.Location = new System.Drawing.Point(231, 226);
            this.PayMethodCB.Name = "PayMethodCB";
            this.PayMethodCB.Size = new System.Drawing.Size(121, 21);
            this.PayMethodCB.TabIndex = 9;
            // 
            // AddrLabel
            // 
            this.AddrLabel.AutoSize = true;
            this.AddrLabel.Location = new System.Drawing.Point(39, 279);
            this.AddrLabel.Name = "AddrLabel";
            this.AddrLabel.Size = new System.Drawing.Size(82, 13);
            this.AddrLabel.TabIndex = 8;
            this.AddrLabel.Text = "Введите адрес";
            // 
            // deliveryAddressTB
            // 
            this.deliveryAddressTB.Location = new System.Drawing.Point(24, 295);
            this.deliveryAddressTB.Name = "deliveryAddressTB";
            this.deliveryAddressTB.Size = new System.Drawing.Size(121, 20);
            this.deliveryAddressTB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберете способ доставки";
            // 
            // SaleNameLabel
            // 
            this.SaleNameLabel.AutoSize = true;
            this.SaleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaleNameLabel.Location = new System.Drawing.Point(7, 27);
            this.SaleNameLabel.Name = "SaleNameLabel";
            this.SaleNameLabel.Size = new System.Drawing.Size(232, 20);
            this.SaleNameLabel.TabIndex = 5;
            this.SaleNameLabel.Text = "Список товаров в корзине";
            // 
            // DeliveryCB
            // 
            this.DeliveryCB.FormattingEnabled = true;
            this.DeliveryCB.Items.AddRange(new object[] {
            "По адресу",
            "Новая почта",
            "Укр почта"});
            this.DeliveryCB.Location = new System.Drawing.Point(24, 226);
            this.DeliveryCB.Name = "DeliveryCB";
            this.DeliveryCB.Size = new System.Drawing.Size(121, 21);
            this.DeliveryCB.TabIndex = 4;
            // 
            // SetOrder
            // 
            this.SetOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SetOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SetOrder.Location = new System.Drawing.Point(234, 277);
            this.SetOrder.Name = "SetOrder";
            this.SetOrder.Size = new System.Drawing.Size(118, 38);
            this.SetOrder.TabIndex = 3;
            this.SetOrder.Text = "Заказать";
            this.SetOrder.UseVisualStyleBackColor = false;
            this.SetOrder.Click += new System.EventHandler(this.SetOrder_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(383, 50);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(131, 36);
            this.deleteBTN.TabIndex = 12;
            this.deleteBTN.Text = "Удалить выбранный товар";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Visible = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // CutomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 408);
            this.Controls.Add(this.Backet);
            this.Name = "CutomerForm";
            this.Text = "CutomerForm";
            this.Backet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label AddrLabel;
        private System.Windows.Forms.TextBox deliveryAddressTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SaleNameLabel;
        private System.Windows.Forms.ComboBox DeliveryCB;
        private System.Windows.Forms.Button SetOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PayMethodCB;
        private System.Windows.Forms.Button addProductInBacket;
        private System.Windows.Forms.Label UserNameLBL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ProductListDGV;
        public System.Windows.Forms.TabControl Backet;
        private System.Windows.Forms.ListView BacketList;
        private System.Windows.Forms.Button deleteBTN;
    }
}