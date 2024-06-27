namespace SistemaGestionUI.FormProductoVendido
{
    partial class FormCRUD_SellProduct
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
            lblSellProduct = new Label();
            lblIdSellProduct = new Label();
            lblStock = new Label();
            lblIdProduct = new Label();
            lblIdSell = new Label();
            txtIdSellProduct = new TextBox();
            txtStock = new TextBox();
            txtProductId = new TextBox();
            txtSellId = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnBackSellProduct = new Button();
            SuspendLayout();
            // 
            // lblSellProduct
            // 
            lblSellProduct.AutoSize = true;
            lblSellProduct.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSellProduct.ForeColor = Color.Blue;
            lblSellProduct.Location = new Point(38, 43);
            lblSellProduct.Margin = new Padding(4, 0, 4, 0);
            lblSellProduct.Name = "lblSellProduct";
            lblSellProduct.Size = new Size(347, 35);
            lblSellProduct.TabIndex = 0;
            lblSellProduct.Text = "Productos Vendidos";
            // 
            // lblIdSellProduct
            // 
            lblIdSellProduct.AutoSize = true;
            lblIdSellProduct.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblIdSellProduct.Location = new Point(38, 165);
            lblIdSellProduct.Margin = new Padding(4, 0, 4, 0);
            lblIdSellProduct.Name = "lblIdSellProduct";
            lblIdSellProduct.Size = new Size(261, 26);
            lblIdSellProduct.TabIndex = 1;
            lblIdSellProduct.Text = "ID Producto Vendido";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblStock.Location = new Point(49, 244);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(82, 26);
            lblStock.TabIndex = 2;
            lblStock.Text = "Stock";
            // 
            // lblIdProduct
            // 
            lblIdProduct.AutoSize = true;
            lblIdProduct.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblIdProduct.Location = new Point(49, 320);
            lblIdProduct.Margin = new Padding(4, 0, 4, 0);
            lblIdProduct.Name = "lblIdProduct";
            lblIdProduct.Size = new Size(160, 26);
            lblIdProduct.TabIndex = 3;
            lblIdProduct.Text = "ID Producto";
            // 
            // lblIdSell
            // 
            lblIdSell.AutoSize = true;
            lblIdSell.Font = new Font("Showcard Gothic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblIdSell.Location = new Point(49, 417);
            lblIdSell.Margin = new Padding(4, 0, 4, 0);
            lblIdSell.Name = "lblIdSell";
            lblIdSell.Size = new Size(108, 26);
            lblIdSell.TabIndex = 4;
            lblIdSell.Text = "ID Venta";
            // 
            // txtIdSellProduct
            // 
            txtIdSellProduct.Location = new Point(339, 164);
            txtIdSellProduct.Margin = new Padding(4, 5, 4, 5);
            txtIdSellProduct.Name = "txtIdSellProduct";
            txtIdSellProduct.ReadOnly = true;
            txtIdSellProduct.Size = new Size(303, 31);
            txtIdSellProduct.TabIndex = 5;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(339, 238);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(303, 31);
            txtStock.TabIndex = 6;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(339, 314);
            txtProductId.Margin = new Padding(4, 5, 4, 5);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(303, 31);
            txtProductId.TabIndex = 7;
            // 
            // txtSellId
            // 
            txtSellId.Location = new Point(339, 411);
            txtSellId.Margin = new Padding(4, 5, 4, 5);
            txtSellId.Name = "txtSellId";
            txtSellId.Size = new Size(303, 31);
            txtSellId.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(482, 588);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 38);
            btnSave.TabIndex = 18;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Blue;
            btnDelete.Location = new Point(293, 588);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 38);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBackSellProduct
            // 
            btnBackSellProduct.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackSellProduct.ForeColor = Color.Blue;
            btnBackSellProduct.Location = new Point(121, 588);
            btnBackSellProduct.Margin = new Padding(4, 5, 4, 5);
            btnBackSellProduct.Name = "btnBackSellProduct";
            btnBackSellProduct.Size = new Size(107, 38);
            btnBackSellProduct.TabIndex = 16;
            btnBackSellProduct.Text = "Volver";
            btnBackSellProduct.UseVisualStyleBackColor = true;
            btnBackSellProduct.Click += btnBackSellProduct_Click;
            // 
            // FormCRUD_SellProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 750);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnBackSellProduct);
            Controls.Add(txtSellId);
            Controls.Add(txtProductId);
            Controls.Add(txtStock);
            Controls.Add(txtIdSellProduct);
            Controls.Add(lblIdSell);
            Controls.Add(lblIdProduct);
            Controls.Add(lblStock);
            Controls.Add(lblIdSellProduct);
            Controls.Add(lblSellProduct);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCRUD_SellProduct";
            Text = "Productos vendidos";
            Load += FormCRUD_SellProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSellProduct;
        private Label lblIdSellProduct;
        private Label lblStock;
        private Label lblIdProduct;
        private Label lblIdSell;
        private TextBox txtIdSellProduct;
        private TextBox txtStock;
        private TextBox txtProductId;
        private TextBox txtSellId;
        private Button btnSave;
        private Button btnDelete;
        private Button btnBackSellProduct;
    }
}