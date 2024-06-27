namespace SistemaGestionUI.FormProducto
{
    partial class FormCRUD_Product
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
            lblProduct = new Label();
            lblDescription = new Label();
            lblCost = new Label();
            lblSellPrice = new Label();
            lblStock = new Label();
            lblSeller = new Label();
            txtDescription = new TextBox();
            txtCost = new TextBox();
            txtSellPrice = new TextBox();
            txtStock = new TextBox();
            txtUserId = new TextBox();
            lblId = new Label();
            txtProductId = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblProduct.ForeColor = Color.Blue;
            lblProduct.Location = new Point(59, 51);
            lblProduct.Margin = new Padding(4, 0, 4, 0);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(191, 35);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Productos";
            lblProduct.Click += lblProduct_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDescription.Location = new Point(66, 239);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(152, 26);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Descripcion";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCost.Location = new Point(66, 335);
            lblCost.Margin = new Padding(4, 0, 4, 0);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(82, 26);
            lblCost.TabIndex = 2;
            lblCost.Text = "Costo";
            // 
            // lblSellPrice
            // 
            lblSellPrice.AutoSize = true;
            lblSellPrice.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSellPrice.Location = new Point(38, 425);
            lblSellPrice.Margin = new Padding(4, 0, 4, 0);
            lblSellPrice.Name = "lblSellPrice";
            lblSellPrice.Size = new Size(195, 26);
            lblSellPrice.TabIndex = 3;
            lblSellPrice.Text = "Precio de Venta";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblStock.Location = new Point(59, 523);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(82, 26);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // lblSeller
            // 
            lblSeller.AutoSize = true;
            lblSeller.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSeller.Location = new Point(59, 611);
            lblSeller.Margin = new Padding(4, 0, 4, 0);
            lblSeller.Name = "lblSeller";
            lblSeller.Size = new Size(156, 26);
            lblSeller.TabIndex = 5;
            lblSeller.Text = "ID Vendedor";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(254, 233);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(340, 31);
            txtDescription.TabIndex = 6;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(254, 330);
            txtCost.Margin = new Padding(4, 5, 4, 5);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(340, 31);
            txtCost.TabIndex = 7;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(254, 424);
            txtSellPrice.Margin = new Padding(4, 5, 4, 5);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(340, 31);
            txtSellPrice.TabIndex = 8;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(254, 518);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(340, 31);
            txtStock.TabIndex = 9;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(254, 611);
            txtUserId.Margin = new Padding(4, 5, 4, 5);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(340, 31);
            txtUserId.TabIndex = 10;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblId.Location = new Point(59, 151);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(160, 26);
            lblId.TabIndex = 11;
            lblId.Text = "ID Producto";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(254, 146);
            txtProductId.Margin = new Padding(4, 5, 4, 5);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(340, 31);
            txtProductId.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(370, 727);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 38);
            btnSave.TabIndex = 15;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Blue;
            btnDelete.Location = new Point(254, 727);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 38);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.Blue;
            btnBack.Location = new Point(139, 727);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 38);
            btnBack.TabIndex = 13;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FormCRUD_Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 857);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(txtProductId);
            Controls.Add(lblId);
            Controls.Add(txtUserId);
            Controls.Add(txtStock);
            Controls.Add(txtSellPrice);
            Controls.Add(txtCost);
            Controls.Add(txtDescription);
            Controls.Add(lblSeller);
            Controls.Add(lblStock);
            Controls.Add(lblSellPrice);
            Controls.Add(lblCost);
            Controls.Add(lblDescription);
            Controls.Add(lblProduct);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCRUD_Product";
            Text = "Productos";
            Load += FormCRUD_Product_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private Label lblDescription;
        private Label lblCost;
        private Label lblSellPrice;
        private Label lblStock;
        private Label lblSeller;
        private TextBox txtDescription;
        private TextBox txtCost;
        private TextBox txtSellPrice;
        private TextBox txtStock;
        private TextBox txtUserId;
        private Label lblId;
        private TextBox txtProductId;
        private Button btnSave;
        private Button btnDelete;
        private Button btnBack;
    }
}